using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Relationship;

[StixTypeDiscriminator(TYPE)]
public sealed record Relationship() : RelationshipObject()
{
    private const string TYPE = "relationship";

    public required string RelationshipType { get; init; }
    public string? Description { get; init; }
    public required StixIdentifier SourceRef { get; init; }
    public required StixIdentifier TargetRef { get; init; }
    public DateTime? StartTime { get; init; }
    public DateTime? StopTime { get; init; }

    public override string Type => TYPE;
}