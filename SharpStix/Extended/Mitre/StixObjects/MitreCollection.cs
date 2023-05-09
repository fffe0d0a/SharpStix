using SharpStix.Extended.Mitre.StixTypes;
using SharpStix.Services;
using SharpStix.StixObjects;
using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixObjects;

[StixTypeDiscriminator(TYPE)]
public record MitreCollection : StixObject
{
    private const string TYPE = "x-mitre-collection";

    public required string Name { get; init; }
    public string? Description { get; init; }
    public required DateTime Created { get; init; }
    public required DateTime Modified { get; init; }
    public required MitreVersion XMitreVersion { get; init; }
    public required SpecVersion SpecVersion { get; init; }
    public required MitreAttackSpecVersion XMitreAttackSpecVersion { get; init; }
    public required StixIdentifier CreatedByRef { get; init; }
    public required StixList<StixIdentifier> ObjectMarkingRefs { get; init; }
    public required StixList<MitreObjectVersionReference> XMitreContents { get; init; }

    public override string Type => TYPE;
}