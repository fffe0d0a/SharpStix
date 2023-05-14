using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(StixOpenVocabConverter<DefinitionType>))]
[Obsolete("Deprecated per STIX 2.1.")]
public sealed record DefinitionType(string Value) : StixOpenVocab(Value)
{
    private const string TYPE = "definition-type";

    public static readonly DefinitionType Statement = new DefinitionType("statement");

    public static readonly DefinitionType Tlp = new DefinitionType("tlp");

    public override string ToString() => base.ToString();

    public override string Type => TYPE;
}