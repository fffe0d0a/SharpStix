using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

public sealed record Tool() : DomainObject()
{
    public required string Name { get; init; }
    public string? Description { get; init; }
    public List<ToolType>? ToolTypes { get; init; }
    public List<string>? Aliases { get; init; }
    public List<StixKillChainPhase>? KillChainPhases { get; init; }
    public string? ToolVersion { get; init; }

    public new static string TypeName => "tool";
}