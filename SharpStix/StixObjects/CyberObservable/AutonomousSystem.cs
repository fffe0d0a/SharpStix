using SharpStix.Services;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record AutonomousSystem : CyberObservableObject
{
    private const string TYPE = "autonomous-system";

    public required int Number { get; init; }
    public string? Name { get; init; }
    public string? Rir { get; init; }

    public override string Type => TYPE;
}