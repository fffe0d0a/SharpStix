using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(StixOpenVocabConverter<DefinitionType>))]
[Obsolete("Deprecated per STIX 2.1.")]
public sealed record DefinitionType : StixOpenVocab, IFromString<DefinitionType>
{
    private const string TYPE = "definition-type";

    public static readonly DefinitionType Statement = FromString("statement");

    public static readonly DefinitionType Tlp = FromString("tlp");

    private DefinitionType(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static DefinitionType FromString(string value)
    {
        if (OpenVocabManager<DefinitionType>.TryGetValue(value, out DefinitionType? vocab))
            return vocab!;

        vocab = new DefinitionType(value);
        OpenVocabManager<DefinitionType>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}