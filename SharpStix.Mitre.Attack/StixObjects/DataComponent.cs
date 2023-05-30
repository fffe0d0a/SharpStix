using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixObjects.Domain;
using SharpStix.StixTypes;

namespace SharpStix.Mitre.Attack.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record DataComponent : DomainObject
{
    private const string TYPE = "x-mitre-data-component";

    [JsonPropertyName("x_mitre_data_source_ref")]
    public required StixIdentifier DataSourceRef { get; init; }

    public override string Type => TYPE;
}