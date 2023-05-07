using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record TcpExtension() : CyberObservableObject()
{
    public byte[]? SrcFlagsHex { get; init; }
    public byte[]? DstFlagsHex { get; init; }

    public new static string TypeName => "tcp-ext";
}