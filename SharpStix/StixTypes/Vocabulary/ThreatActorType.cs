using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ThreatActorType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ThreatActorType : StixOpenVocab, IFromString<ThreatActorType>
{
    private const string TYPE = "theat-actor-type-ov";
    public static readonly ThreatActorType Activist = FromString("activist");

    public static readonly ThreatActorType Competitor = FromString("competitor");

    public static readonly ThreatActorType CrimeSyndicate = FromString("crime-syndicate");

    public static readonly ThreatActorType Criminal = FromString("criminal");

    public static readonly ThreatActorType Hacker = FromString("hacker");

    public static readonly ThreatActorType InsiderAccidental = FromString("insider-accidental");

    public static readonly ThreatActorType InsiderDisgruntled = FromString("insider-disgruntled");

    public static readonly ThreatActorType NationState = FromString("nation-state");

    public static readonly ThreatActorType Sensationalist = FromString("sensationalist");

    public static readonly ThreatActorType Spy = FromString("spy");

    public static readonly ThreatActorType Terrorist = FromString("terrorist");

    public static readonly ThreatActorType Unknown = FromString("unknown");

    private ThreatActorType(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static ThreatActorType FromString(string value)
    {
        if (OpenVocabManager<ThreatActorType>.TryGetValue(value, out ThreatActorType? vocab))
            return vocab!;

        vocab = new ThreatActorType(value);
        OpenVocabManager<ThreatActorType>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}