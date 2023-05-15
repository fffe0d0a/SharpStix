using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ThreatActorRole>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ThreatActorRole : StixOpenVocab, IFromString<ThreatActorRole>
{
    private const string TYPE = "threat-actor-role-ov";
    public static readonly ThreatActorRole Agent = FromString("agent");

    public static readonly ThreatActorRole Director = FromString("director");

    public static readonly ThreatActorRole Independent = FromString("independent");

    public static readonly ThreatActorRole InfrastructureArchitect = FromString("infrastructure-architect");

    public static readonly ThreatActorRole InfrastructureOperator = FromString("infrastructure-operator");

    public static readonly ThreatActorRole MalwareAuthor = FromString("malware-author");

    public static readonly ThreatActorRole Sponsor = FromString("sponsor");

    private ThreatActorRole(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static ThreatActorRole FromString(string value)
    {
        if (OpenVocabManager<ThreatActorRole>.TryGetValue(value, out ThreatActorRole? vocab))
            return vocab!;

        vocab = new ThreatActorRole(value);
        OpenVocabManager<ThreatActorRole>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}