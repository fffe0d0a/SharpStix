using SharpStix.Services;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record UnixAccountExtension() : CyberObservableObject()
{
    private const string TYPE = "unix-account-ext";

    public int? Gid { get; init; }
    public List<string>? Groups { get; init; }
    public string? HomeDir { get; init; }
    public string? Shell { get; init; }

    public override string Type => TYPE;
}