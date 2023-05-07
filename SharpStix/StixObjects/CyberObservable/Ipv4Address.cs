using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record Ipv4Address() : CyberObservableObject()
{
    public required string Value { get; init; }
    public List<StixIdentifier>? ResolvesToRefs { get; init; }
    public List<StixIdentifier>? BelongsToRefs { get; init; }

    public new static string TypeName => "ipv4-addr";
}