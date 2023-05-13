using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record AutonomousSystem : CyberObservableObject
{
    private const string TYPE = "autonomous-system";

    public required Int54 Number { get; init; }
    public string? Name { get; init; }
    public string? Rir { get; init; }

    public override string Type => TYPE;
}