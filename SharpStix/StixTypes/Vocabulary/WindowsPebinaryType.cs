using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<WindowsPebinaryType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record WindowsPebinaryType(string Value) : StixOpenVocab(Value)
{
    public static readonly WindowsPebinaryType Dll = new WindowsPebinaryType("dll");

    public static readonly WindowsPebinaryType Exe = new WindowsPebinaryType("exe");

    public static readonly WindowsPebinaryType Sys = new WindowsPebinaryType("sys");

    private const string TYPE = "windows-pebinary-type-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}