using System.Diagnostics;
using System.Reflection;
using SharpStix.Common;
using SharpStix.StixObjects;

namespace SharpStix.Services;

public static class StixTypeDiscriminationService
{
    private static readonly Dictionary<string, Type> TypeMap = new Dictionary<string, Type>();

    static StixTypeDiscriminationService()
    {
        foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies()
                     .Where(x => x.GetCustomAttribute<StixTypeProviderAttribute>() != null)) MapTypes(assembly);

        AppDomain.CurrentDomain.AssemblyLoad += (_, args) =>
        {
            Assembly asm = args.LoadedAssembly;
            if (asm.GetCustomAttribute<StixTypeProviderAttribute>() != null)
                MapTypes(asm);
        };
    }

    private static void MapTypes(Assembly assembly)
    {
        foreach (Type type in assembly.GetTypes().Where(x =>
                     x.IsAssignableTo(typeof(IStixType)) && x is { IsInterface: false, IsAbstract: false }))
        {
            if (!type.IsAssignableTo(typeof(IHasTypeName)))
                throw new InvalidOperationException(
                    "Theoretically, this should be impossible if StixObject implements IHasTypeName.");

            string? typeName = type.IsGenericType
                ? GetTypeNameFromGenericType(type)
                : GetTypeNameFromNoneGenericType(type);

            if (typeName == null) //null if GenericTypeNameHelperAttribute is missing on generic type
                continue;

            TypeMap.Add(typeName, type); //if this throws, someone's making a duplicate type somewhere
        }
    }

    private static string? GetTypeNameFromGenericType(Type type)
    {
        try
        {
            return type.GetCustomAttribute<GenericTypeNameHelperAttribute>(false)?.TypeName ??
                   throw new InvalidOperationException(
                       $"Type {type} does not contain the attribute {typeof(GenericTypeNameHelperAttribute)}.");
        }
        catch (InvalidOperationException e)
        {
            Debug.WriteLine(
                $"Type {type} was missing the expected {nameof(GenericTypeNameHelperAttribute)}. Which is used to reflect the {nameof(IHasTypeName.TypeName)} property from generic implementers of {nameof(IHasTypeName)}. Please add it. Until then, it will be ignored.");
            Debug.WriteLine(e);
            return null;
        }
    }

    private static string GetTypeNameFromNoneGenericType(Type type)
    {
        try
        {
            return type.GetProperty(nameof(IHasTypeName.TypeName))?.GetValue(null)?.ToString() ??
                   throw new InvalidOperationException(
                       $"Type {type} does not contain the static property {nameof(IHasTypeName.TypeName)}.");
        }
        catch (InvalidOperationException e)
        {
            Debug.WriteLine(
                $"Type {type} has somehow implemented {typeof(IHasTypeName)} without implementing the static property {nameof(IHasTypeName.TypeName)}. This should be impossible without a bad refactor.");
            Debug.WriteLine(e);
            throw;
        }
    }


    /// <summary>
    ///     Returns the <see cref="Type" /> related to the provided Stix type name.
    /// </summary>
    /// <param name="stixTypeName">The standard Stix name of the type to get.</param>
    /// <returns>A type, which when instanced implements <see cref="IHasTypeName" />.</returns>
    public static Type? GetTypeFromString(string stixTypeName)
    {
        TypeMap.TryGetValue(stixTypeName, out Type? type);
        return type;
    }
}