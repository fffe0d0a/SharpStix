using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record DomainName() : CyberObservableObject()
{
    public required string Value { get; init; }
    public List<StixIdentifier>? ResolvesToRefs { get; init; }

    public new static string TypeName => "domain-name";
}