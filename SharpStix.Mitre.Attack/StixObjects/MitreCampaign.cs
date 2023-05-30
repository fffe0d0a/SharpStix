using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Extension;
using SharpStix.Services;
using SharpStix.StixObjects.Domain;

namespace SharpStix.Mitre.Attack.StixObjects;

public sealed record MitreCampaign : Campaign
{
    private const string FIRST_CITATION = "x_mitre_first_seen_citation";
    private const string LAST_CITATION = "x_mitre_last_seen_citation";

    [JsonPropertyName(FIRST_CITATION)]
    public required string FirstSeenCitation { get; init; }

    [JsonPropertyName(LAST_CITATION)]
    public required string LastSeenCitation { get; init; }

}