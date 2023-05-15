using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<IdentityClass>))]
[StixTypeDiscriminator(TYPE)]
public sealed record IdentityClass : StixOpenVocab, IFromString<IdentityClass>
{
    private const string TYPE = "identity-class-ov";
    public static readonly IdentityClass Individual = FromString("individual");

    public static readonly IdentityClass Group = FromString("group");

    public static readonly IdentityClass System = FromString("system");

    public static readonly IdentityClass Organisational = FromString("organizational");

    public static readonly IdentityClass Class = FromString("class");

    public static readonly IdentityClass Unknown = FromString("unknown");

    private IdentityClass(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static IdentityClass FromString(string value)
    {
        if (OpenVocabManager<IdentityClass>.TryGetValue(value, out IdentityClass? vocab))
            return vocab!;

        vocab = new IdentityClass(value);
        OpenVocabManager<IdentityClass>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}