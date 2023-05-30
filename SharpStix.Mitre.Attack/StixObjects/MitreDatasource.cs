using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixObjects.Domain;
using SharpStix.StixTypes;

namespace SharpStix.Mitre.Attack.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record MitreDataSource : DomainObject //warn this may not be implemented correctly
{
    private const string TYPE = "x-mitre-data-source";

    [JsonPropertyName("x_mitre_platforms")]
    public required StixList<string> Platforms { get; init; }

    [JsonPropertyName("x_mitre_collection_layers")]
    public required StixList<string> CollectionLayers { get; init; }

    public override string Type => TYPE;
}