using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Opinion : DomainObject
{
    private const string TYPE = "opinion";

    public string? Explanation { get; init; }
    public StixList<string>? Authors { get; init; }

    [JsonPropertyName("opinion")]
    public required OpinionEnum
        OpinionEnum { get; init; } //A type with a property of same name is not great, blame the STIX documentation

    public required StixList<StixIdentifier> ObjectRefs { get; init; }

    public override string Type => TYPE;
}