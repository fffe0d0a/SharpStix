using SharpStix.Services;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record Software : CyberObservableObject
{
    private const string TYPE = "software";

    public required string Name { get; init; }
    public string? Cpe { get; init; }
    public string? Swid { get; init; }
    public List<string>? Languages { get; init; }
    public string? Vendor { get; init; }
    public string? Version { get; init; }

    public override string Type => TYPE;
}