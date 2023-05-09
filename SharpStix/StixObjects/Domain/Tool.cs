using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Tool : DomainObject
{
    private const string TYPE = "tool";

    public required string Name { get; init; }
    public string? Description { get; init; }
    public StixList<ToolType>? ToolTypes { get; init; }
    public StixList<string>? Aliases { get; init; }
    public StixList<StixKillChainPhase>? KillChainPhases { get; init; }
    public string? ToolVersion { get; init; }

    public override string Type => TYPE;
}