using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

public sealed record ThreatActor() : DomainObject()
{
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

    public new static string TypeName => "threat-actor";
}