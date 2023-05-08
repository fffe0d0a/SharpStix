using SharpStix.Services;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record IntrusionSet : DomainObject
{
    private const string TYPE = "intrusion-set";

    /// <summary>
    ///     A name used to identify this Intrusion Set.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Intrusion Set, potentially including its purpose and
    ///     its key characteristics.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     Alternative names used to identify this Intrusion Set.
    /// </summary>
    public List<string>? Aliases { get; init; }

    /// <summary>
    ///     The time that this Intrusion Set was first seen.
    /// </summary>
    public DateTime? FirstSeen { get; init; }

    /// <summary>
    ///     The time that this Intrusion Set was last seen.
    /// </summary>
    public DateTime? LastSeen { get; init; }

    /// <summary>
    ///     The high-level goals of this Intrusion Set, namely, what are they trying to do. For example, they may be motivated
    ///     by personal gain, but their goal is to steal credit card numbers. To do this, they may execute specific Campaigns
    ///     that have detailed objectives like compromising point of sale systems at a large retailer.
    /// </summary>
    public List<string>? Goals { get; init; }

    /// <summary>
    ///     This property specifies the organizational level at which this Intrusion Set typically works, which in turn
    ///     determines the resources available to this Intrusion Set for use in an attack.
    /// </summary>
    public AttackResourceLevel? ResourceLevel { get; init; }

    /// <summary>
    ///     The primary reason, motivation, or purpose behind this Intrusion Set. The motivation is why the Intrusion Set
    ///     wishes to achieve the goal (what they are trying to achieve).
    /// </summary>
    public AttackMotivation? PrimaryMotivation { get; init; }

    /// <summary>
    ///     The secondary reasons, motivations, or purposes behind this Intrusion Set. These motivations can exist as an equal
    ///     or near-equal cause to the primary motivation.
    /// </summary>
    public List<AttackMotivation>? SecondaryMotivations { get; init; }

    public override string Type => TYPE;
}