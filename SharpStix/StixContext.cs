using SharpStix.Common;
using SharpStix.Extended.Mitre.StixObjects;
using SharpStix.Serialisation;
using SharpStix.Services;
using SharpStix.StixObjects;

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
        int x = ObjectLookupService.Count;

        return x;
        throw new NotImplementedException();
    }

}