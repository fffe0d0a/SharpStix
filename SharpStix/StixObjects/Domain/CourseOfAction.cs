using SharpStix.Services;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public record CourseOfAction : DomainObject
{
    private const string TYPE = "course-of-action";

    /// <summary>
    ///     A name used to identify the Course of Action.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Course of Action, potentially including its purpose
    ///     and its key characteristics.
    /// </summary>
    public string? Description { get; init; }

    ///// <summary>
    /////     RESERVED – To capture structured/automated courses of action.
    ///// </summary>
    //public byte? Action { get; init; } //note reserved

    public override string Type => TYPE;
}