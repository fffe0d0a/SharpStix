using SharpStix.Extended.Mitre.StixTypes;
using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre;

public interface IMitreAttackObject
{
    public MitreVersion? MitreVersion { get; init; }
    public StixList<string>? MitreContributors { get; init; }
    public bool? MitreDeprecated { get; init; }
}