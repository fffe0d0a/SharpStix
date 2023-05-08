using SharpStix.Services;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Incident : DomainObject
{
    private const string TYPE = "incident";

    /// <summary>
    ///     A name used to identify the Incident.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Incident, potentially including its purpose and its
    ///     key characteristics.
    /// </summary>
    public string? Description { get; init; }

    public override string Type => TYPE;
}