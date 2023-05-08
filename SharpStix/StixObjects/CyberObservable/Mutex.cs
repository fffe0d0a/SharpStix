using SharpStix.Services;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record Mutex : CyberObservableObject
{
    private const string TYPE = "mutex";

    public required string Name { get; init; }


    public override string Type => TYPE;
}