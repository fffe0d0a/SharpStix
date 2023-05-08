using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Meta;

public abstract record MetaObject : StixObject
{
    private const string TYPE = "meta-object";

    public required SpecVersion SpecVersion { get; init; }
    public StixIdentifier? CreatedByRef { get; init; }
    public required DateTime Created { get; init; }
    public List<StixIdentifier>? ExternalReferences { get; init; }
    public List<StixIdentifier>? ObjectMarkingRefs { get; init; }
    public List<GranularMarking>? GranularMarkings { get; init; }
}