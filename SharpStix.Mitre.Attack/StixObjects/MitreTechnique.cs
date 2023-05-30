using System.Text.Json.Serialization;
using SharpStix.Mitre.Attack.Enums;
using SharpStix.StixObjects.Domain;
using SharpStix.StixTypes;

namespace SharpStix.Mitre.Attack.StixObjects;

public sealed record MitreTechnique : AttackPattern
{
    [JsonPropertyName("x_mitre_detection")]
    public string? Detection { get; init; }

    [JsonPropertyName("x_mitre_platforms")]
    public required StixList<string> Platforms { get; init; }

    [JsonPropertyName("x_mitre_data_sources")]
    public StixList<string>? DataSources { get; init; }

    [JsonPropertyName("x_mitre_is_subtechnique")]
    public bool? IsSubtechnique { get; init; }

    [JsonPropertyName("x_mitre_system_requirements")]
    public StixList<string>? SystemRequirements { get; init; }

    [JsonPropertyName("x_mitre_tactic_type")]
    public StixList<MitreTacticTypeEnum>? TacticType { get; init; }

    [JsonPropertyName("x_mitre_permissions_required")]
    public StixList<string>? PermissionsRequired { get; init; }

    [JsonPropertyName("x_mitre_effective_permissions")]
    public StixList<string>? EffectivePermissions { get; init; }

    [JsonPropertyName("x_mitre_defense_bypassed")]
    public StixList<string>? DefenceBypassed { get; init; }

    [JsonPropertyName("x_mitre_remote_support")]
    public bool? RemoteSupport { get; init; }

    [JsonPropertyName("x_mitre_impact_type")]
    public StixList<string>? ImpactType { get; init; }
}

public static class MitreTechniqueExtensions
{
    public static MitreTechnique MakeTechnique(this AttackPattern attackPattern)
    {
        if (attackPattern is MitreTechnique mt)
            return mt;


        throw new NotImplementedException();
    }
}