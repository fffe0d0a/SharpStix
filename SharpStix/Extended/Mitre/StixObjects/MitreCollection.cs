using System.Text.Json.Serialization;
using SharpStix.Extended.Mitre.StixTypes;
using SharpStix.Services;
using SharpStix.StixObjects;
using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixObjects;

[StixTypeDiscriminator(TYPE)]
public record MitreCollection : StixObject //Mitre objects implemented using the documentation at https://github.com/mitre/cti/blob/master/USAGE.md
{
    private const string TYPE = "x-mitre-collection";

    public required string Name { get; init; }
    public string? Description { get; init; }
    public required DateTime Created { get; init; }
    public required DateTime Modified { get; init; }
    [JsonPropertyName("x_mitre_version")] public required MitreVersion Version { get; init; }
    public required SpecVersion SpecVersion { get; init; }
    [JsonPropertyName("x_mitre_attack_spec_version")] public required MitreAttackSpecVersion AttackSpecVersion { get; init; }
    public required StixIdentifier CreatedByRef { get; init; }
    public required StixList<StixIdentifier> ObjectMarkingRefs { get; init; }
    [JsonPropertyName("x_mitre_contents")]public required StixList<MitreObjectVersionReference> Contents { get; init; }

    public override string Type => TYPE;
}