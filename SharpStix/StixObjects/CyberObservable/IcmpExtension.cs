using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record IcmpExtension() : CyberObservableObject()
{
    public required byte[] IcmpTypeHex { get; init; }
    public required byte[] IcmpCodeHex { get; init; }

    public new static string TypeName => "icmp-ext";
}