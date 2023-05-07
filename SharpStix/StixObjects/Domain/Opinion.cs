using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Domain;

public sealed record Opinion() : DomainObject()
{
    public string? Explanation { get; init; }
    public List<string>? Authors { get; init; }

    [JsonPropertyName("opinion")] public required StixTypes.Enums.OpinionEnum EOpinionEnum { get; init; } //warn

    public required List<StixIdentifier> ObjectRefs { get; init; }

    public new static string TypeName => "opinion";
}