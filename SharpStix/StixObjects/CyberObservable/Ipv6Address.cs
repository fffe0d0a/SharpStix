using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record Ipv6Address() : CyberObservableObject()
{
    public required string Value { get; init; }
    public List<StixIdentifier>? ResolvesToRefs { get; init; }
    public List<StixIdentifier>? BelongsToRefs { get; init; }

    public new static string TypeName => "ipv6-addr";
}