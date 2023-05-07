namespace SharpStix.StixObjects.CyberObservable;

public sealed record Software() : CyberObservableObject()
{
    public required string Name { get; init; }
    public string? Cpe { get; init; }
    public string? Swid { get; init; }
    public List<string>? Languages { get; init; }
    public string? Vendor { get; init; }
    public string? Version { get; init; }

    public new static string TypeName => "software";
}