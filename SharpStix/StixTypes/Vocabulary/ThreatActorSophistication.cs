using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ThreatActorSophistication>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ThreatActorSophistication : StixOpenVocab, IFromString<ThreatActorSophistication>
{
    private const string TYPE = "threat-actor-sophistication-ov";
    public static readonly ThreatActorSophistication None = FromString("none");

    public static readonly ThreatActorSophistication Minimal = FromString("minimal");

    public static readonly ThreatActorSophistication Intermediate = FromString("intermediate");

    public static readonly ThreatActorSophistication Advanced = FromString("advanced");

    public static readonly ThreatActorSophistication Expert = FromString("expert");

    public static readonly ThreatActorSophistication Innovator = FromString("innovator");

    public static readonly ThreatActorSophistication Strategic = FromString("strategic");

    private ThreatActorSophistication(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static ThreatActorSophistication FromString(string value)
    {
        if (OpenVocabManager<ThreatActorSophistication>.TryGetValue(value, out ThreatActorSophistication? vocab))
            return vocab!;

        vocab = new ThreatActorSophistication(value);
        OpenVocabManager<ThreatActorSophistication>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}