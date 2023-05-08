using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record Ipv6Address : CyberObservableObject
{
    private const string TYPE = "ipv6-addr";

    public required string Value { get; init; }
    public List<StixIdentifier>? ResolvesToRefs { get; init; }
    public List<StixIdentifier>? BelongsToRefs { get; init; }

    public override string Type => TYPE;
}