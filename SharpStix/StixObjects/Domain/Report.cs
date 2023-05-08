using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Report() : DomainObject()
{
    private const string TYPE = "report";

    public required string Name { get; init; }
    public string? Description { get; init; }
    public List<ReportType>? ReportTypes { get; init; }
    public required DateTime Published { get; init; }
    public required List<StixIdentifier> ObjectRefs { get; init; }

    public override string Type => TYPE;
}