using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

public abstract record CoreObject : StixObject
{
    public StixList<StixIdentifier>? ObjectMarkingRefs { get; init; }
    public StixList<GranularMarking>? GranularMarkings { get; init; }

    [JsonExtensionData] public Dictionary<string, JsonElement>? Extensions { get; init; }
}