using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record Ipv6Address : CyberObservableObject
{
    private const string TYPE = "ipv6-addr";

    public required string Value { get; init; }
    public StixList<StixIdentifier>? ResolvesToRefs { get; init; }
    public StixList<StixIdentifier>? BelongsToRefs { get; init; }

    public override string Type => TYPE;
}