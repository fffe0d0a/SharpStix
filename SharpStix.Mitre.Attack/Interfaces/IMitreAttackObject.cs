using SharpStix.Mitre.Attack.StixTypes;
using SharpStix.StixTypes;

namespace SharpStix.Mitre.Attack.Interfaces;

public interface IMitreAttackObject
{
    public MitreVersion? MitreVersion { get; init; }
    public StixList<string>? MitreContributors { get; init; }
    public bool? MitreDeprecated { get; init; }
}