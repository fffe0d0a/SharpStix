using System.Text.Json.Nodes;
using SharpStix.StixObjects;
using SharpStix.StixTypes;

namespace SharpStix.Services;

public static class StixObjectFactory
{
    public static StixObject CreateObjectFromJson(JsonNode jsonNode) => throw new NotImplementedException();

    public static IStixDataType CreateDataTypeFromJson(JsonNode jsonNode) => throw new NotImplementedException();

    public static Bundle CreateBundleFromJson(JsonNode jsonNode) => throw new NotImplementedException();
    // this'll be big
}