using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ToolType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ToolType(string Value) : StixOpenVocab(Value)
{
    public static readonly ToolType DenialOfService = new ToolType("denial-of-service");

    public static readonly ToolType Exploitation = new ToolType("exploitation");

    public static readonly ToolType InformationGathering = new ToolType("information-gathering");

    public static readonly ToolType NetworkCapture = new ToolType("network-capture");

    public static readonly ToolType CredentialExploitation = new ToolType("credential-exploitation");

    public static readonly ToolType RemoteAccess = new ToolType("remote-access");

    public static readonly ToolType VulnerabilityScanning = new ToolType("vulnerability-scanning");

    public static readonly ToolType Unknown = new ToolType("unknown");

    private const string TYPE = "tool-type-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}