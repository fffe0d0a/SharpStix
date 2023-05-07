namespace SharpStix.StixObjects.Domain;

public sealed record Incident() : DomainObject()
{
    /// <summary>
    ///     A name used to identify the Incident.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Incident, potentially including its purpose and its
    ///     key characteristics.
    /// </summary>
    public string? Description { get; init; }

    public new static string TypeName => "incident";
}