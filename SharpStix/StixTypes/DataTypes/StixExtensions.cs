using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using SharpStix.Common.Extensions;
using SharpStix.Serialisation;
using SharpStix.Services;
using SharpStix.StixObjects.CyberObservable;

namespace SharpStix.StixTypes;

public class StixExtensions : Dictionary<string, JsonElement> //not a STIX type
{
    private bool _formatted;

    private void AddExtension(string key, in JsonElement value, bool canBePredefined = false)
    {
        UnresolvedExtension unresolvedExtension = new UnresolvedExtension(key, value);

        if (unresolvedExtension.TryResolve(out ResolvedExtension? extension))
        {
            if (canBePredefined && extension.Value is IPredefinedExtension predefined)
            {
                Predefined.Add(predefined);
            }
            else
            {
                Resolved.Add(extension);
            }
        }
        else
        {
            Unresolved.Add(unresolvedExtension);
        }
    }

    internal void FormatExtensions() //smelly but effective
    {
        if (_formatted) return;
        _formatted = true;

        foreach (KeyValuePair<string, JsonElement> item in this)
        {
            if (item.Key == "extensions") //this is the extensions property of the object, which can contain predefined and resolvable extensions
            {
                foreach (JsonProperty jsonProperty in item.Value.EnumerateObject())
                {
                    AddExtension(jsonProperty.Name, jsonProperty.Value, true);
                }
            }
            else
            {
                AddExtension(item.Key, item.Value); //this is an inline extension, it will not contain predefined //bug item.Key is property name not discriminator for inline extensions
            }
        }
    }

    [JsonIgnore] public List<IPredefinedExtension> Predefined { get; } = new List<IPredefinedExtension>();
    [JsonIgnore] public List<ResolvedExtension> Resolved { get; } = new List<ResolvedExtension>();
    [JsonIgnore] public List<UnresolvedExtension> Unresolved { get; } = new List<UnresolvedExtension>();

    /// <summary>
    ///     Attempts to assign the out value by enumerating the <see cref="Resolved"/> and <see cref="Unresolved"/> properties.
    ///     The <see cref="Resolved"/> property is searched first.
    ///     If no <see cref="ResolvedExtension"/> matches the <see cref="propertyName"/> argument, the <see cref="Unresolved"/> property will be searched.
    ///     If a match is found in the <see cref="Unresolved"/> property and said match is successfully deserialised to the provided type argument <see cref="T"/>,
    ///     the matching <see cref="UnresolvedExtension"/> will be converted to a <see cref="ResolvedExtension"/>.
    /// </summary>
    /// <typeparam name="T">The type of value</typeparam>
    /// <param name="propertyName"></param>
    /// <param name="value"></param>
    /// <returns>True if <see cref="value"/> is assigned, otherwise false.</returns>
    public bool TryGetValue<T>(string propertyName, [NotNullWhen(true)] out T? value) where T : notnull
    {
        value = default;

        lock (Resolved)
        {
            ResolvedExtension? resolvedExtension = Resolved.FirstOrDefault(x => x.Name == propertyName);
            if (resolvedExtension != null)
            {
                if (resolvedExtension.Type.IsAssignableTo(typeof(T)))
                {
                    value = (T)resolvedExtension.Value;
                    return true;
                }

                Debug.WriteLine($"Extension {propertyName} is not assignable to type of {typeof(T)}", nameof(T));
                return false;
            }
            
            lock (Unresolved)
            {
                UnresolvedExtension? unresolvedExtension = Unresolved.FirstOrDefault(x => x.Key == propertyName);
                if (unresolvedExtension == null)
                    return false;
                if (!unresolvedExtension.TryForceResolve(out value))
                    return false;

                Resolved.Add(new ResolvedExtension(propertyName, typeof(T), value));
                Unresolved.Remove(unresolvedExtension);
                return true;
            }
        }
    }

    public T GetValue<T>(string propertyName) where T : notnull
    {
        lock (Resolved)
        {
            ResolvedExtension? resolvedExtension = Resolved.FirstOrDefault(x => x.Name == propertyName);
            if (resolvedExtension != null)
                return (T)resolvedExtension.Value;
            
            lock (Unresolved)
            {
                UnresolvedExtension? unresolvedExtension = Unresolved.First(x => x.Key == propertyName);
                if (unresolvedExtension == null)
                    throw new KeyNotFoundException(
                        $"Property by name of {propertyName} does not exist in {Resolved} or {Unresolved}.");

                if (!unresolvedExtension.TryForceResolve(out T? returnValue))
                    throw new InvalidCastException($"Property by name of {propertyName} cannot be converted to type {typeof(T)}.");

                Resolved.Add(new ResolvedExtension(propertyName, typeof(T), returnValue));
                Unresolved.Remove(unresolvedExtension);
                return returnValue;
            }
        }
    }

    public bool HasExtensions(string name)
    {
        if (Unresolved.Any(x => x.Key == name))
            return true;
        if (Resolved.Any(x => x.Name == name))
            return true;
        return false;
    }

    public bool HasExtensions(params string[] names)
    {
        return names.All(HasExtensions);
    }
}



public class ResolvedExtension
{
    public ResolvedExtension(string name, Type type, object value)
    {
        Name = name;
        Type = type;
        Value = value;
    }

    public string Name { get; }
    public Type Type { get; }
    public object Value { get; }
}

public class UnresolvedExtension
{
    public UnresolvedExtension(string key, JsonElement value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public JsonElement Value { get; }

    
    internal bool TryResolve([NotNullWhen(true)] out ResolvedExtension? extension)
    {
        bool NotifyAndReturn()
        {
#if DEBUG
            Debug.WriteLine($"Could not resolve extension using discriminator '{Key}'.");
#endif
            return false;
        }

        extension = null;

        Type? type = StixTypeDiscriminationService.GetTypeFromDiscriminator(Key);
        if (type == null) //try force resolve to basic type
        {
            if (!Value.TryForceResolve(out object? instance))
                return NotifyAndReturn();

            extension = new ResolvedExtension(Key, instance.GetType(), instance);
            return true;
        }

        object? value = Value.Deserialize(type, StixJsonSerialiser.Options);
        if (value == null) 
            return NotifyAndReturn();

        extension = new ResolvedExtension(Key, type, value);
        return true;
    }

    public bool TryForceResolve<T>([NotNullWhen(true)] out T? value) where T : notnull
    {
        value = default;
        try
        {
            value = (T?)Value.Deserialize(typeof(T), StixJsonSerialiser.Options);
            if (value != null)
                return true;
        }
        catch (Exception)
        {
            Debug.WriteLine($"Failed to force resolve value '{Value}' to type '{typeof(T)}'.");
            return false;
        }

        return false;
    }
}
