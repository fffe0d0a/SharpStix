namespace SharpStix.StixObjects.CyberObservable;

public sealed record Url() : CyberObservableObject()
{
    public required string Value { get; init; }

    public new static string TypeName => "url";
}