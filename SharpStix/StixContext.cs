using System.Text.Json;
using SharpStix.Common;
using SharpStix.Serialisation;
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


    public int AddFromBundleFile(StixSerialiser serialiser, string filePath)
    {
        Bundle? thing = serialiser.DeserialiseFromFile<Bundle>(filePath);

        throw new NotImplementedException();
    }

}