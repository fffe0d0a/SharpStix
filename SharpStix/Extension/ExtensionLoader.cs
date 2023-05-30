using System.Reflection;

namespace SharpStix.Extension;

public static class ExtensionLoader
{
    public static void Load(string path)
    {
        AssemblyName assemblyName = AssemblyName.GetAssemblyName(path);
        AppDomain.CurrentDomain.Load(assemblyName);
    }

    public static void LoadFromName(string name)
    {
        AppDomain.CurrentDomain.Load(name);
    }
}