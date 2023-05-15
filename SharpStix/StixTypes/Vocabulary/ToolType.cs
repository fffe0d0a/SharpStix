using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ToolType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ToolType : StixOpenVocab, IFromString<ToolType>
{
    private const string TYPE = "tool-type-ov";
    public static readonly ToolType DenialOfService = FromString("denial-of-service");

    public static readonly ToolType Exploitation = FromString("exploitation");

    public static readonly ToolType InformationGathering = FromString("information-gathering");

    public static readonly ToolType NetworkCapture = FromString("network-capture");

    public static readonly ToolType CredentialExploitation = FromString("credential-exploitation");

    public static readonly ToolType RemoteAccess = FromString("remote-access");

    public static readonly ToolType VulnerabilityScanning = FromString("vulnerability-scanning");

    public static readonly ToolType Unknown = FromString("unknown");

    private ToolType(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static ToolType FromString(string value)
    {
        if (OpenVocabManager<ToolType>.TryGetValue(value, out ToolType? vocab))
            return vocab!;

        vocab = new ToolType(value);
        OpenVocabManager<ToolType>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}