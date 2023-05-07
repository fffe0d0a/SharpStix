namespace SharpStix.StixObjects.Domain;

public sealed record CourseOfAction() : DomainObject()
{
    /// <summary>
    ///     A name used to identify the Course of Action.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Course of Action, potentially including its purpose
    ///     and its key characteristics.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     RESERVED – To capture structured/automated courses of action.
    /// </summary>
    public object? Action { get; init; } //warn

    public new static string TypeName => "course-of-action";
}