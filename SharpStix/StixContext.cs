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