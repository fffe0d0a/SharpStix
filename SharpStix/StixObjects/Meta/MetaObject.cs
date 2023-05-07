using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Meta;

public abstract record MetaObject() : StixObject()
{
    public required SpecVersion SpecVersion { get; init; }
    public StixIdentifier? CreatedByRef { get; init; }
    public required DateTime Created { get; init; }
    public List<StixIdentifier>? ExternalReferences { get; init; }
    public List<StixIdentifier>? ObjectMarkingRefs { get; init; }
    public List<GranularMarking>? GranularMarkings { get; init; }

    public new static string TypeName => "meta-object";
}