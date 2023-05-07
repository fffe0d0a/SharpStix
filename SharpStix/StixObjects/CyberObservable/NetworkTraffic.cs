using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record NetworkTraffic() : CyberObservableObject()
{
    public new Dictionary<string, string>? Extensions { get; init; } //warn not compliant
    public DateTime? Start { get; init; }
    public DateTime? End { get; init; }
    public bool? IsActive { get; init; }
    public StixIdentifier? SrcRef { get; init; }
    public StixIdentifier? DstRef { get; init; }
    public int? SrcPort { get; init; }
    public int? DstPort { get; init; }
    public required List<string> Protocols { get; init; }
    public int? SrcByteCount { get; init; }
    public int? DstByteCount { get; init; }
    public int? SrcPackets { get; init; }
    public int? DstPackets { get; init; }
    public Dictionary<string, string>? Ipfix { get; init; }
    public StixIdentifier? SrcPayloadRef { get; init; }
    public StixIdentifier? DstPayloadRef { get; init; }
    public List<StixIdentifier>? EncapsulatesRefs { get; init; }
    public StixIdentifier? EncapsulatedByRef { get; init; }

    public new static string TypeName => "network-traffic";
}