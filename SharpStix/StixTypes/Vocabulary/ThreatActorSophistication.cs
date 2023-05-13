using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ThreatActorSophistication>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ThreatActorSophistication(string Value) : StixOpenVocab(Value)
{
    public static readonly ThreatActorSophistication None = new ThreatActorSophistication("none");

    public static readonly ThreatActorSophistication Minimal = new ThreatActorSophistication("minimal");

    public static readonly ThreatActorSophistication Intermediate = new ThreatActorSophistication("intermediate");

    public static readonly ThreatActorSophistication Advanced = new ThreatActorSophistication("advanced");

    public static readonly ThreatActorSophistication Expert = new ThreatActorSophistication("expert");

    public static readonly ThreatActorSophistication Innovator = new ThreatActorSophistication("innovator");

    public static readonly ThreatActorSophistication Strategic = new ThreatActorSophistication("strategic");

    private const string TYPE = "threat-actor-sophistication-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}