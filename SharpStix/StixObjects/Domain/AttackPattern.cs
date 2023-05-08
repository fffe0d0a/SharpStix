using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record AttackPattern() : DomainObject()
{
    private const string TYPE = "attack-pattern";

    /// <summary>
    ///     A name used to identify the Attack Pattern.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Attack Pattern, potentially including its purpose
    ///     and its key characteristics.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     Alternative names used to identify this Attack Pattern.
    /// </summary>
    public List<string>? Aliases { get; init; }

    /// <summary>
    ///     The list of Kill Chain Phases for which this Attack Pattern is used.
    /// </summary>
    public List<StixKillChainPhase>? KillChainPhases { get; init; }

    public override string Type => TYPE;
}