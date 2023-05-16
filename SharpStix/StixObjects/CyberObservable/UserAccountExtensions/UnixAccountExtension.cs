using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record UnixAccountExtension : UserAccountExtension
{
    private const string TYPE = "unix-account-ext";

    public Int54? Gid { get; init; }
    public StixList<string>? Groups { get; init; }
    public string? HomeDir { get; init; }
    public string? Shell { get; init; }

    public override string Type => TYPE;
}