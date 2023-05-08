using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Infrastructure() : DomainObject()
{
    private const string TYPE = "infrastructure";

    /// <summary>
    ///     A name or characterizing text used to identify the Infrastructure.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Infrastructure, potentially including its purpose,
    ///     how it is being used, how it relates to other intelligence activities captured in related objects, and its key
    ///     characteristics.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     The type of infrastructure being described.
    /// </summary>
    public List<InfrastructureType>? InfrastructureTypes { get; init; }

    /// <summary>
    ///     Alternative names used to identify this Infrastructure.
    /// </summary>
    public List<string>? Aliases { get; init; }

    /// <summary>
    ///     The list of Kill Chain Phases for which this Infrastructure is used.
    /// </summary>
    public List<StixKillChainPhase>? KillChainPhases { get; init; }

    /// <summary>
    ///     The time that this Infrastructure was first seen performing malicious activities.
    /// </summary>
    public DateTime? FirstSeen { get; init; }

    /// <summary>
    ///     The time that this Infrastructure was last seen performing malicious activities.
    /// </summary>
    public DateTime? LastSeen { get; init; }

    public override string Type => TYPE;
}