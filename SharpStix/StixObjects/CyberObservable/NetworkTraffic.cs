using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record NetworkTraffic : CyberObservableObject
{
    private const string TYPE = "network-traffic";

    public new Dictionary<string, string>? Extensions { get; init; } //warn not compliant
    public DateTime? Start { get; init; }
    public DateTime? End { get; init; }
    public bool? IsActive { get; init; }
    public StixIdentifier? SrcRef { get; init; }
    public StixIdentifier? DstRef { get; init; }
    public StixInteger? SrcPort { get; init; }
    public StixInteger? DstPort { get; init; }
    public required StixList<string> Protocols { get; init; }
    public StixInteger? SrcByteCount { get; init; }
    public StixInteger? DstByteCount { get; init; }
    public StixInteger? SrcPackets { get; init; }
    public StixInteger? DstPackets { get; init; }
    public StixDictionary<string>? Ipfix { get; init; }
    public StixIdentifier? SrcPayloadRef { get; init; }
    public StixIdentifier? DstPayloadRef { get; init; }
    public StixList<StixIdentifier>? EncapsulatesRefs { get; init; }
    public StixIdentifier? EncapsulatedByRef { get; init; }

    public override string Type => TYPE;
}