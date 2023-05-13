using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ThreatActorType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ThreatActorType(string Value) : StixOpenVocab(Value)
{
    public static readonly ThreatActorType Activist = new ThreatActorType("activist");

    public static readonly ThreatActorType Competitor = new ThreatActorType("competitor");

    public static readonly ThreatActorType CrimeSyndicate = new ThreatActorType("crime-syndicate");

    public static readonly ThreatActorType Criminal = new ThreatActorType("criminal");

    public static readonly ThreatActorType Hacker = new ThreatActorType("hacker");

    public static readonly ThreatActorType InsiderAccidental = new ThreatActorType("insider-accidental");

    public static readonly ThreatActorType InsiderDisgruntled = new ThreatActorType("insider-disgruntled");

    public static readonly ThreatActorType NationState = new ThreatActorType("nation-state");

    public static readonly ThreatActorType Sensationalist = new ThreatActorType("sensationalist");

    public static readonly ThreatActorType Spy = new ThreatActorType("spy");

    public static readonly ThreatActorType Terrorist = new ThreatActorType("terrorist");

    public static readonly ThreatActorType Unknown = new ThreatActorType("unknown");

    private const string TYPE = "theat-actor-type-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}