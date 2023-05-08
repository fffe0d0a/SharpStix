using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

public abstract record CoreObject : StixObject
{
    public List<StixIdentifier>? ObjectMarkingRefs { get; init; }
    public List<GranularMarking>? GranularMarkings { get; init; }
    [JsonExtensionData]
    public Dictionary<string, object>? Extensions { get; init; } //warn, object
}