using System.Text.Json.Serialization;
using SharpStix.StixObjects;
using SharpStix.StixObjects.Domain;

namespace SharpStix.Extended.Mitre.StixObjects;

public sealed record MitreCampaign : Campaign
{
    [JsonPropertyName("x_mitre_first_seen_citation")] public required string FirstSeenCitation { get; init; }
    [JsonPropertyName("x_mitre_last_seen_citation")] public required string LastSeenCitation { get; init; }
}

public static class MitreCampaignExtensions
{
    public static MitreCampaign AsMitreCampaign(this Campaign campaign)
    {
        if (campaign is MitreCampaign mc)
            return mc;

        throw new NotImplementedException();
    }
}
