using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record Ipv4Address : CyberObservableObject
{
    private const string TYPE = "ipv4-addr";

    public required string Value { get; init; }
    public StixList<StixIdentifier>? ResolvesToRefs { get; init; }
    public StixList<StixIdentifier>? BelongsToRefs { get; init; }

    public override string Type => TYPE;
}