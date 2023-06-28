using System.Collections.Concurrent;
using System.Diagnostics;
using SharpStix.StixObjects;
using SharpStix.StixTypes;

namespace SharpStix.Services;

public static class ObjectLookupService
{
    private static readonly ConcurrentDictionary<StixIdentifier, StixObject> Map =
        new ConcurrentDictionary<StixIdentifier, StixObject>();

    public static int Count => Map.Count;

    internal static bool Register(StixObject stixObject)
    {
        bool success = Map.TryAdd(stixObject.Id, stixObject);

        if (!success)
            Debug.WriteLine($"Attempted to register a StixObject that already exists. {stixObject.Id}");
        return success;
    }

    public static bool Lookup(StixIdentifier identifier, out StixObject? stixObject) =>
        Map.TryGetValue(identifier, out stixObject);
}