using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record TcpExtension() : CyberObservableObject()
{
    private const string TYPE = "tcp-ext";

    public byte[]? SrcFlagsHex { get; init; }
    public byte[]? DstFlagsHex { get; init; }

    public override string Type => TYPE;
}