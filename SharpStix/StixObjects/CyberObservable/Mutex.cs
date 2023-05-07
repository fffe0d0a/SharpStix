namespace SharpStix.StixObjects.CyberObservable;

public sealed record Mutex() : CyberObservableObject()
{
    public required string Name { get; init; }

    public new static string TypeName => "mutex";
}