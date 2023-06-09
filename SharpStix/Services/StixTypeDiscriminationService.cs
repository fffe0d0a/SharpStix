﻿using System.Diagnostics;
using System.Reflection;
using SharpStix.StixObjects;

namespace SharpStix.Services;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
//Like a fine cheese
public class StixTypeDiscriminatorAttribute : Attribute
{
    public StixTypeDiscriminatorAttribute(string typeName)
    {
        TypeName = typeName;
    }

    public string TypeName { get; }
}

public static class StixTypeDiscriminationService
{
    private static readonly Dictionary<string, Type> TypeMap = new Dictionary<string, Type>();
    private static readonly Dictionary<Type, string> DiscriminatorMap = new Dictionary<Type, string>();

    static StixTypeDiscriminationService()
    {
        StixTypeElicitationService.Init();
    }

    internal static void OnStixTypeFound(Type type)
    {
        string? typeDiscriminator = GetTypeDiscriminator(type);

        if (typeDiscriminator == null) //null if GenericTypeNameHelperAttribute is missing on generic type
            return;

        TypeMap.Add(typeDiscriminator, type); //if this throws, someone's making a duplicate type somewhere
        DiscriminatorMap.Add(type, typeDiscriminator); // ||
    }

    private static string? GetTypeDiscriminator(Type type)
    {
        if (!type.IsAssignableTo(typeof(IHasTypeName)))
            return null;

        StixTypeDiscriminatorAttribute? typeDiscriminator =
            (StixTypeDiscriminatorAttribute?)type.GetCustomAttribute(typeof(StixTypeDiscriminatorAttribute));

        if (typeDiscriminator == null)
        {
            Debug.WriteLine(
                $"Stix type {type} implementing {typeof(IHasTypeName)} is missing {typeof(StixTypeDiscriminatorAttribute)}.");
            return null;
        }

        return typeDiscriminator.TypeName;
    }


    /// <summary>
    ///     Returns the <see cref="Type" /> related to the provided Stix type name.
    /// </summary>
    /// <param name="discriminator">The standard Stix name of the type to get.</param>
    /// <returns>A type, which when instanced implements <see cref="IHasTypeName" />.</returns>
    public static Type? GetTypeFromDiscriminator(string discriminator)
    {
        TypeMap.TryGetValue(discriminator, out Type? type);
        return type;
    }

    public static string? GetDiscriminatorFromType(Type type)
    {
        DiscriminatorMap.TryGetValue(type, out string? value);
        return value;
    }

    public static string? GetDiscriminatorFromType<T>() where T : IHasTypeName
    {
        DiscriminatorMap.TryGetValue(typeof(T), out string? value);
        return value;
    }

    public static string? GetDiscriminatorFromObject<T>(T instance) where T : IHasTypeName
    {
        DiscriminatorMap.TryGetValue(instance.GetType(), out string? value);
        return value;
    }
}