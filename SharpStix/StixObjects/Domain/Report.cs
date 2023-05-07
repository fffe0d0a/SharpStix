using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

public sealed record Report() : DomainObject()
{
    public required string Name { get; init; }
    public string? Description { get; init; }
    public List<ReportType>? ReportTypes { get; init; }
    public required DateTime Published { get; init; }
    public required List<StixIdentifier> ObjectRefs { get; init; }

    public new static string TypeName => "report";
}