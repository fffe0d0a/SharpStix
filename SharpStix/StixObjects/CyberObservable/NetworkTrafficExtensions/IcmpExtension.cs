using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record IcmpExtension : NetworkTrafficExtension
{
    private const string TYPE = "icmp-ext";

    public required StixHex IcmpTypeHex { get; init; }
    public required StixHex IcmpCodeHex { get; init; }

    public override string Type => TYPE;
    public override string Protocol => "icmp";
}