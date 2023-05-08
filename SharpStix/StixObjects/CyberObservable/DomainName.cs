using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record DomainName : CyberObservableObject
{
    private const string TYPE = "domain-name";

    public required string Value { get; init; }
    public List<StixIdentifier>? ResolvesToRefs { get; init; }

    public override string Type => TYPE;
}