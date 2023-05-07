namespace SharpStix.StixObjects.CyberObservable;

public sealed record MacAddress() : CyberObservableObject()
{
    public required string Value { get; init; }

    public new static string TypeName => "mac-addr";
}