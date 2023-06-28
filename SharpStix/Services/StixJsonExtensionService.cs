using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json;
using SharpStix.StixObjects;
using SharpStix.StixObjects.Meta;

namespace SharpStix.Services;

internal static class StixJsonUpgradeService
{
    private static readonly ConcurrentDictionary<Type, List<Type>>
        Map = new ConcurrentDictionary<Type, List<Type>>(); //Parent, Children

    static StixJsonUpgradeService()
    {
        StixTypeElicitationService.Init();
    }

    internal static void OnStixTypeFound(Type type) //type is not abstract or interface and derives from IStixType
    {
        if (type.BaseType!.IsAbstract)
            return;

        if (!type.IsAssignableTo(typeof(StixObject)))
            return;

        if (!type.BaseType.IsAssignableTo(typeof(IHasExtensions)))
            return;

        if (type.BaseType == typeof(MarkingDefinition)) //warn remove
            return;

        if (!TypeAmbiguitySanityCheck(type.BaseType, type))
            throw new Exception($"The json representation of {type.BaseType} and {type} is ambiguous.");

        if (!Map.ContainsKey(type.BaseType))
            Map.TryAdd(type.BaseType, new List<Type>());

        Map[type.BaseType].Add(type);
    }

    internal static bool TryUpgrade(Type type, in JsonDocument document, in JsonSerializerOptions options,
        [NotNullWhen(true)]
        out StixObject? instance) //bug this will not work when extension properties are in the predefined Extension property
    {
        instance = null;
        if (!Map.TryGetValue(type, out List<Type>? upgrades))
            return false;

        foreach (Type upgrade in upgrades)
        {
            try //this does the work of a custom json deserialiser
            {
                instance = (StixObject)document.Deserialize(upgrade,
                        options)
                    !; //todo pester MS to add TryDeserialize() or pester STIX maintainers to enforce type discriminators on extended types
                return true;
            }
            catch (JsonException)
            {
            }
        }

        return false;
    }

    private static bool TypeAmbiguitySanityCheck(Type parent, Type child)
    {
        return child
            .GetProperties()
            .ExceptBy(parent
                .GetProperties()
                .Select(x => x.Name), y => y.Name)
            .Any();
    }
}

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class InterceptUpgradeAttribute<T> : Attribute where T : IStixUpgradeIntercept, new()
{
}

public interface IStixUpgradeIntercept
{
    internal static bool TryGetDelegateFromType(Type stixType, [NotNullWhen(true)] out DTryDetermineType? del)
    {
        del = null;

        Attribute? attribute = stixType.GetCustomAttribute(typeof(InterceptUpgradeAttribute<>));
        if (attribute == null)
            return false;

        Type interceptType = attribute.GetType().GenericTypeArguments[0];
        del = interceptType.GetMethod(nameof(TryDetermineType))!.CreateDelegate<DTryDetermineType>();
        return true;
    }

    public abstract static bool TryDetermineType(in JsonDocument document, [NotNullWhen(true)] out Type? type);

    internal delegate bool DTryDetermineType(in JsonDocument document, [NotNullWhen(true)] out Type? type);
}