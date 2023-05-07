using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

public abstract record CoreObject : StixObject
{
    public List<StixIdentifier>? ObjectMarkingRefs { get; init; }
    public List<GranularMarking>? GranularMarkings { get; init; }
    public Dictionary<StixIdentifier, object>? Extensions { get; init; }
    public new static string TypeName => "core-object";
}