using System.Text.Json.Nodes;
using SharpStix.StixObjects;
using SharpStix.StixTypes;

namespace SharpStix.Services;

public static class StixObjectFactory
{
    static StixObjectFactory()
    {
        // get all stixobjects, map typename, use Json.Deserialise() with typename in params to deseralise with normal constructor, 
    }

    public static StixObject CreateObjectFromJson(JsonNode jsonNode)
    {
        throw new NotImplementedException();
    }

    public static IStixDataType CreateDataTypeFromJson(JsonNode jsonNode)
    {
        throw new NotImplementedException();
    }

    public static Bundle CreateBundleFromJson(JsonNode jsonNode)
    {
        throw new NotImplementedException();
        // this'll be big
    }

}