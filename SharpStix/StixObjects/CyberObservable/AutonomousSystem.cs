namespace SharpStix.StixObjects.CyberObservable;

public sealed record AutonomousSystem() : CyberObservableObject()
{
    public required int Number { get; init; }
    public string? Name { get; init; }
    public string? Rir { get; init; }

    public new static string TypeName => "autonomous-system";
}