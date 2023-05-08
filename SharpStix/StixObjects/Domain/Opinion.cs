using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Opinion() : DomainObject()
{
    private const string TYPE = "opinion";

    public string? Explanation { get; init; }
    public List<string>? Authors { get; init; }

    [JsonPropertyName("opinion")] public required StixTypes.Enums.OpinionEnum OpinionEnum { get; init; } //warn

    public required List<StixIdentifier> ObjectRefs { get; init; }

    public override string Type => TYPE;
}