using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record Ipv4Address() : CyberObservableObject()
{
    private const string TYPE = "ipv4-addr";

    public required string Value { get; init; }
    public List<StixIdentifier>? ResolvesToRefs { get; init; }
    public List<StixIdentifier>? BelongsToRefs { get; init; }

    public override string Type => TYPE;
}