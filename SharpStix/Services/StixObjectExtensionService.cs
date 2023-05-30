using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using SharpStix.Extension;
using SharpStix.StixObjects;

namespace SharpStix.Services;

internal static class StixObjectExtensionService
{
    private const string GENERIC_EXT_INTER = $"{nameof(IStixObjectExtension)}`2"; //IStixObjectExtension<T, T2>

    private readonly struct ExtensionPackage
    {
        public ExtensionPackage(Type child)
        {
            Child = child;
            TryExtend = child.GetMethod($"{nameof(IStixObjectExtension.TryExtend)}") ?? throw new InvalidOperationException($"Library error. Ensure all types implementing {nameof(IStixObjectExtension)} implement the generic overload, not the untyped interface.");
        }

        public Type Child { get; }
        private MethodBase TryExtend { get; }

        public bool InvokeTryExtend(in StixObject instance, [NotNullWhen(true)] out StixObject? extendedInstance)
        {
            extendedInstance = null;
            return (bool) TryExtend.Invoke(null, new object?[] { instance, extendedInstance })!;
        }
    }

    private static readonly Dictionary<Type, List<ExtensionPackage>> Map = new Dictionary<Type, List<ExtensionPackage>>();

    static StixObjectExtensionService()
    {
        StixTypeElicitationService.Init();
    }

    internal static void OnStixTypeFound(Type type)
    {
        Type? extensionInterface = type.GetInterface(GENERIC_EXT_INTER);
        if (extensionInterface == null) 
            return;

        Type parentType = extensionInterface.GenericTypeArguments[0];
        Type childType = extensionInterface.GenericTypeArguments[1];

        if (!Map.ContainsKey(parentType))
            Map.Add(parentType, new List<ExtensionPackage>());

        Map[parentType].Add(new ExtensionPackage(childType));
    }

    public static bool TryExtendInstance(ref StixObject instance)
    {
        if (!Map.TryGetValue(instance.GetType(), out List<ExtensionPackage>? extendableTypes))
            return false;

        foreach (ExtensionPackage extensionPackage in extendableTypes)
        {
            if (extensionPackage.InvokeTryExtend(instance, out StixObject? extendedInstance))
            {
                instance = extendedInstance;
                return true;
            }
        }

        return false; //No extension possible, instance is hopefully a base type
    }
}

