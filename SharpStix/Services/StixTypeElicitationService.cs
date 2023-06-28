using System.Reflection;
using SharpStix.Common;

namespace SharpStix.Services;

public static class StixTypeElicitationService
{
    public static readonly EventHandler<Type>? StixTypeFound;

    static StixTypeElicitationService()
    {
        StixTypeFound += (_, type) => StixTypeDiscriminationService.OnStixTypeFound(type);
        StixTypeFound += (_, type) => StixJsonUpgradeService.OnStixTypeFound(type);

        AppDomain.CurrentDomain.AssemblyLoad += (_, args) => OnAssemblyLoad(args.LoadedAssembly);

        EnumerateLoadedAssemblies();
    }

    public static void Init()
    {
    }

    private static void EnumerateLoadedAssemblies()
    {
        foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            if (assembly.FullName is not null)
            {
                if (assembly.FullName.StartsWith("System") || assembly.FullName.StartsWith("Microsoft"))
                    continue;
            }

            OnAssemblyLoad(assembly);
        }
    }

    private static void OnAssemblyLoad(Assembly assembly)
    {
        foreach (Type type in assembly.GetTypes())
        {
            if (type.IsAssignableTo(typeof(IStixType)) && type is { IsInterface: false, IsAbstract: false })
                StixTypeFound?.Invoke(null, type);
        }
    }
}