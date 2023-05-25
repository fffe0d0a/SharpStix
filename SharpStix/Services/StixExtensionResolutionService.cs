using SharpStix.StixTypes;
using System.Collections.Concurrent;

namespace SharpStix.Services;

internal static class StixExtensionResolutionService<T>
{
    // ReSharper disable once StaticMemberInGenericType
    private static readonly ConcurrentDictionary<string, Type> Map = new ConcurrentDictionary<string, Type>();
    //Dictionary<Class, Dictionary<Property, Type>>

    //so can access -> className, <propertyName, type> //faciliates duplicate propertyNames with different types

    public static ResolvedExtension Resolve(UnresolvedExtension unresolvedExtension)
    {
        throw new NotImplementedException();
        //have a map that can be used to identify types from the extension property name
    }

    public static bool Register(string propertyName, Type type) => Map.TryAdd(propertyName, type);
}