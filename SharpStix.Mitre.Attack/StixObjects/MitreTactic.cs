using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixObjects.Domain;

namespace SharpStix.Mitre.Attack.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record MitreTactic : DomainObject
{
    private const string TYPE = "x-mitre-tactic";

    [JsonPropertyName("x_mitre_shortname")]
    public required string ShortName { get; init; }

    public override string Type => TYPE;
}