using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record TcpExtension : CyberObservableObject
{
    private const string TYPE = "tcp-ext";

    public StixHex? SrcFlagsHex { get; init; }
    public StixHex? DstFlagsHex { get; init; }

    public override string Type => TYPE;
}