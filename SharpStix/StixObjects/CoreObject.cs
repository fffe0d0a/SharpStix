using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

public abstract record CoreObject : StixObject
{
    public StixList<StixIdentifier>? ObjectMarkingRefs { get; init; }
    public StixList<GranularMarking>? GranularMarkings { get; init; }

    [JsonExtensionData] public Dictionary<string, object>? Extensions { get; init; } //warn, object and not stixdict
}