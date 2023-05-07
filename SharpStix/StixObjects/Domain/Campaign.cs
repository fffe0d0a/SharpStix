namespace SharpStix.StixObjects.Domain;

public sealed record Campaign() : DomainObject()
{
    /// <summary>
    ///     A name used to identify the Campaign.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Campaign, potentially including its purpose and its
    ///     key characteristics.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     Alternative names used to identify this Campaign
    /// </summary>
    public List<string>? Aliases { get; init; }

    /// <summary>
    ///     The time that this Campaign was first seen.
    /// </summary>
    public DateTime? FirstSeen { get; init; }

    /// <summary>
    ///     The time that this Campaign was last seen.
    /// </summary>
    public DateTime? LastSeen { get; init; }

    /// <summary>
    ///     The Campaign’s primary goal, objective, desired outcome, or intended effect — what the Threat Actor or Intrusion
    ///     Set hopes to accomplish with this Campaign.
    /// </summary>
    public string? Objective { get; init; }

    public new static string TypeName => "campaign";
}