using System.ComponentModel.DataAnnotations;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Relationship;

public sealed record Sighting() : RelationshipObject()
{
    public string? Description { get; init; }
    public DateTime? FirstSeen { get; init; }
    public DateTime? LastSeen { get; init; }

    [Range(0, 999999999)] public int? Count { get; init; }

    public required StixIdentifier SightingOfRef { get; init; }
    public List<StixIdentifier>? ObservedDataRefs { get; init; }
    public List<StixIdentifier>? WhereSighedRefs { get; init; }
    public bool? Summary { get; init; } = false;

    public new static string TypeName => "sighting";
}