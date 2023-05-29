using System.Text.Json.Serialization;
using SharpStix.Extension;
using SharpStix.StixObjects.Domain;

namespace SharpStix.Mitre.Attack.StixObjects;

public sealed record MitreCampaign : Campaign, IStixObjectExtension<Campaign, MitreCampaign>
{
    [JsonPropertyName("x_mitre_first_seen_citation")]
    public required string FirstSeenCitation { get; init; }

    [JsonPropertyName("x_mitre_last_seen_citation")]
    public required string LastSeenCitation { get; init; }

    public static bool IsExtensionOf(Campaign instance) => throw new NotImplementedException();

    public static bool TryExtend(Campaign instance, MitreCampaign? extendedInstance) => throw new NotImplementedException();
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