namespace SharpStix.StixObjects.Meta;

public sealed record StatementMarking : MarkingDefinition;

public sealed record StatementDefinition : ObjectDefinition
{
    public required string Statement { get; init; }

    public override string ToString() => Statement;
}