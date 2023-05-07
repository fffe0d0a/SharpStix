namespace SharpStix.StixObjects.CyberObservable;

public sealed record UnixAccountExtension() : CyberObservableObject()
{
    public int? Gid { get; init; }
    public List<string>? Groups { get; init; }
    public string? HomeDir { get; init; }
    public string? Shell { get; init; }

    public new static string TypeName => "unix-account-ext";
}