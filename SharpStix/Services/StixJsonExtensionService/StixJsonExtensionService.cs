using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json;
using SharpStix.StixObjects;
using SharpStix.StixObjects.Meta;

namespace SharpStix.Services;

internal static partial class StixJsonUpgradeService
{
    private static readonly Dictionary<Type, List<TypeExtension>> Map = new Dictionary<Type, List<TypeExtension>>(); //Parent, Children

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

        if (!Map.ContainsKey(type.BaseType))
            Map.Add(type.BaseType, new List<TypeExtension>());

        Map[type.BaseType].Add(TypeExtension.FromTypePair(type.BaseType, type));
    }

    internal static bool TryUpgradeType(Type type, in JsonDocument document, [NotNullWhen(true)] out Type? upgradeType) //document assumed to be a StixObject
    {
        upgradeType = null;

        if (!Map.TryGetValue(type, out List<TypeExtension>? upgrades))
            return false;

        foreach (TypeExtension upgrade in upgrades)
        {
            if (CanFit(document, upgrade))
            {
                upgradeType = upgrade.Type;
                return true;
            }
        }

        return false;
    }


    private static bool CanFit(in JsonDocument document, in TypeExtension upgrade)
    {
        


        throw new NotImplementedException();
    }
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class InterceptUpgradeAttribute<T> : Attribute where T : IStixUpgradeIntercept, new() { }

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

    internal delegate bool DTryDetermineType(in JsonDocument document, [NotNullWhen(true)] out Type? type);

    public abstract static bool TryDetermineType(in JsonDocument document, [NotNullWhen(true)] out Type? type);
}