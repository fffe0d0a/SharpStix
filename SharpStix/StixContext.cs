using System.Text.Json;
using SharpStix.Common;
using SharpStix.StixObjects;
using SharpStix.StixTypes;

namespace SharpStix;

public class StixContext
{
    public StixContext(string? name = null)
    {
        Name = name;
    }

    public string Id { get; } = Guid.NewGuid().ToString();
    public string? Name { get; }


    public int AddObjects(params IStixType[] stixObjects) => throw new NotImplementedException();

    public int AddObjectsFromJson(string jsonString)
    {
        JsonDocument document = JsonDocument.Parse(jsonString);

        throw new NotImplementedException();
    }
}

internal static class StixIdentityService<T> where T : IStixType, IHasId
{
    private static Dictionary<StixIdentifier, T> IdentityMap { get; } = new Dictionary<StixIdentifier, T>();

    public static bool Register(T stixObject) => IdentityMap.TryAdd(stixObject.Id, stixObject);

    public static bool Unregister(T stixObject) => IdentityMap.Remove(stixObject.Id);

    public static T GetById(StixIdentifier id) => IdentityMap[id];
    //todo may throw
}