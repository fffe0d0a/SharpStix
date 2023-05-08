using SharpStix.Services;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record ThreatActor() : DomainObject()
{
    private const string TYPE = "threat-actor";

    public required string Name { get; init; }
    public string? Description { get; init; }
    public List<ThreatActorType>? ThreatActorTypes { get; init; }
    public List<string>? Aliases { get; init; }
    public DateTime? FirstSeen { get; init; }
    public DateTime? LastSeen { get; init; }
    public List<ThreatActorRole>? Roles { get; init; }
    public List<string>? Goals { get; init; }
    public ThreatActorSophistication? Sophistication { get; init; }
    public AttackResourceLevel? ResourceLevel { get; init; }
    public AttackMotivation? PrimaryMotivation { get; init; }
    public List<AttackMotivation>? SecondaryMotivations { get; init; }
    public List<AttackMotivation>? PersonalMotivations { get; init; }

    public override string Type => TYPE;
}