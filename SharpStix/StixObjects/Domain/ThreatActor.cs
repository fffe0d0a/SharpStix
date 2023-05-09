using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record ThreatActor : DomainObject
{
    private const string TYPE = "threat-actor";

    public required string Name { get; init; }
    public string? Description { get; init; }
    public StixList<ThreatActorType>? ThreatActorTypes { get; init; }
    public StixList<string>? Aliases { get; init; }
    public DateTime? FirstSeen { get; init; }
    public DateTime? LastSeen { get; init; }
    public StixList<ThreatActorRole>? Roles { get; init; }
    public StixList<string>? Goals { get; init; }
    public ThreatActorSophistication? Sophistication { get; init; }
    public AttackResourceLevel? ResourceLevel { get; init; }
    public AttackMotivation? PrimaryMotivation { get; init; }
    public StixList<AttackMotivation>? SecondaryMotivations { get; init; }
    public StixList<AttackMotivation>? PersonalMotivations { get; init; }

    public override string Type => TYPE;
}