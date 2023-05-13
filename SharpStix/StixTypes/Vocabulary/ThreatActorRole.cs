using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ThreatActorRole>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ThreatActorRole(string Value) : StixOpenVocab(Value)
{
    public static readonly ThreatActorRole Agent = new ThreatActorRole("agent");

    public static readonly ThreatActorRole Director = new ThreatActorRole("director");

    public static readonly ThreatActorRole Independent = new ThreatActorRole("independent");

    public static readonly ThreatActorRole InfrastructureArchitect = new ThreatActorRole("infrastructure-architect");

    public static readonly ThreatActorRole InfrastructureOperator = new ThreatActorRole("infrastructure-operator");

    public static readonly ThreatActorRole MalwareAuthor = new ThreatActorRole("malware-author");

    public static readonly ThreatActorRole Sponsor = new ThreatActorRole("sponsor");

    private const string TYPE = "threat-actor-role-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}