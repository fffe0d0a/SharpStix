using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Text.Json.Serialization;
using SharpStix.Extension;
using SharpStix.StixObjects.Domain;

namespace SharpStix.Mitre.Attack.StixObjects;

public sealed record MitreCampaign : Campaign, IStixObjectExtension<Campaign, MitreCampaign>
{
    private const string FIRST_CITATION = "x_mitre_first_seen_citation";
    private const string LAST_CITATION = "x_mitre_last_seen_citation";

    [JsonPropertyName(FIRST_CITATION)]
    public required string FirstSeenCitation { get; init; }

    [JsonPropertyName(LAST_CITATION)]
    public required string LastSeenCitation { get; init; }

    public static bool CanExtend(Campaign instance)
    {
        if (instance.Extensions == null)
            return false;

        if (!instance.Extensions.HasExtensions(FIRST_CITATION, LAST_CITATION))
            return false;

        return true;
    }

    public static bool TryExtend(Campaign instance, [NotNullWhen(true)] out MitreCampaign? extendedInstance)
    {
        extendedInstance = null;
        if (!CanExtend(instance))
            return false;

        if (!instance.Extensions!.TryGetValue(FIRST_CITATION, out string? firstSeenCitation))
            return false;

        if (!instance.Extensions!.TryGetValue(LAST_CITATION, out string? lastSeenCitation))
            return false;

        throw new Exception();

        return true;
    }
}

public static class MitreCampaignExtensions
{
    public static bool TryAsMitreCampaign(this Campaign campaign, [NotNullWhen(true)] out MitreCampaign? mitreCampaign)
    {
        if (campaign is MitreCampaign mc)
        {
            mitreCampaign = mc;
            return true;
        }
        

        throw new NotImplementedException();
    }
}