using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Relationship;

public sealed record Relationship() : RelationshipObject()
{
    public required string RelationshipType { get; init; }
    public string? Description { get; init; }
    public required StixIdentifier SourceRef { get; init; }
    public required StixIdentifier TargetRef { get; init; }
    public DateTime? StartTime { get; init; }
    public DateTime? StopTime { get; init; }

    public new static string TypeName => "relationship";
}