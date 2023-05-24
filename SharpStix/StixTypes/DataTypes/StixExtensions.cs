using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Serialisation;
using SharpStix.Services;

namespace SharpStix.StixTypes;

public class StixExtensions : Dictionary<string, JsonElement> //not a STIX type
{
    private bool _formatted;

    private void AddExtension(string discriminator, in JsonElement value)
    {
        UnresolvedExtension unresolvedExtension = new UnresolvedExtension(discriminator, value);

        if (unresolvedExtension.TryResolve(out ResolvedExtension? extension))
        {
            Resolved.Add(extension!);
        }
        else
        {
            Unresolved.Add(unresolvedExtension);
        }
    }

    internal void FormatExtensions()
    {
        if (_formatted) return;
        _formatted = true;

        foreach (KeyValuePair<string, JsonElement> item in this)
        {
            if (item.Key == "extensions") //this is the extensions property of the object
            {
                foreach (JsonProperty jsonProperty in item.Value.EnumerateObject())
                {
                    AddExtension(jsonProperty.Name, jsonProperty.Value);
                }
            }
            else
            {
                AddExtension(item.Key, item.Value); //this is an inline extension
            }
        }
    }

    [JsonIgnore] public List<ResolvedExtension> Resolved { get; } = new List<ResolvedExtension>();
    [JsonIgnore] public List<UnresolvedExtension> Unresolved { get; } = new List<UnresolvedExtension>();
}

public class ResolvedExtension
{
    public ResolvedExtension(Type type, object value)
    {
        Type = type;
        Value = value;
    }

    public Type Type { get; }
    public object Value { get; }
}

public class UnresolvedExtension
{
    public UnresolvedExtension(string discriminator, JsonElement value)
    {
        Discriminator = discriminator;
        Value = value;
    }

    public string Discriminator { get; }
    public JsonElement Value { get; }

    public bool TryResolve(out ResolvedExtension? extension)
    {
        bool NotifyAndReturn()
        {
            Debug.WriteLine($"Could not resolve extension discriminator '{Discriminator}'.");
            return false;
        }

        extension = null;

        Type? type = StixTypeDiscriminationService.GetTypeFromDiscriminator(Discriminator);
        if (type == null)
            return NotifyAndReturn();

        object? value = Value.Deserialize(type, StixJsonSerialiser.Options);
        if (value == null) 
            return NotifyAndReturn();

        extension = new ResolvedExtension(type, value);
        return true;
    }
}