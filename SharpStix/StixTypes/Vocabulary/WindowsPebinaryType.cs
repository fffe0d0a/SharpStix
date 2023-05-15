using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<WindowsPebinaryType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record WindowsPebinaryType : StixOpenVocab, IFromString<WindowsPebinaryType>
{
    private const string TYPE = "windows-pebinary-type-ov";
    public static readonly WindowsPebinaryType Dll = FromString("dll");

    public static readonly WindowsPebinaryType Exe = FromString("exe");

    public static readonly WindowsPebinaryType Sys = FromString("sys");

    private WindowsPebinaryType(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static WindowsPebinaryType FromString(string value)
    {
        if (OpenVocabManager<WindowsPebinaryType>.TryGetValue(value, out WindowsPebinaryType? vocab))
            return vocab!;

        vocab = new WindowsPebinaryType(value);
        OpenVocabManager<WindowsPebinaryType>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}