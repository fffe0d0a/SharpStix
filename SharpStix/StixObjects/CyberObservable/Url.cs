using SharpStix.Services;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record Url : CyberObservableObject
{
    private const string TYPE = "url";

    public required string Value { get; init; }

    public override string Type => TYPE;
}