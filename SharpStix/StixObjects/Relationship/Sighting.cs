using System.ComponentModel.DataAnnotations;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Relationship;

[StixTypeDiscriminator(TYPE)]
public sealed record Sighting : RelationshipObject
{
    private const string TYPE = "sighting";

    public string? Description { get; init; }
    public DateTime? FirstSeen { get; init; }
    public DateTime? LastSeen { get; init; }

    [Range(0, 999999999)] public Int54? Count { get; init; } //todo validate in class

    public required StixIdentifier SightingOfRef { get; init; }
    public StixList<StixIdentifier>? ObservedDataRefs { get; init; }
    public StixList<StixIdentifier>? WhereSightedRefs { get; init; }
    public bool? Summary { get; init; }

    public override string Type => TYPE;
}