using SharpStix.Services;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record MacAddress : CyberObservableObject
{
    private const string TYPE = "mac-addr";

    public required string Value { get; init; }

    public override string Type => TYPE;
}