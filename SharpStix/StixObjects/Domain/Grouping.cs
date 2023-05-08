using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Grouping() : DomainObject()
{
    private const string TYPE = "grouping";

    /// <summary>
    ///     A name used to identify the Grouping.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Grouping, potentially including its purpose and its
    ///     key characteristics.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     A short descriptor of the particular context shared by the content referenced by the Grouping.
    /// </summary>
    public required GroupingContext Context { get; init; }

    /// <summary>
    ///     Specifies the STIX Objects that are referred to by this Grouping.
    /// </summary>
    public required List<StixIdentifier> ObjectRefs { get; init; }

    public override string Type => TYPE;
}