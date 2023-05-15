using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<InfrastructureType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record InfrastructureType : StixOpenVocab, IFromString<InfrastructureType>
{
    private const string TYPE = "infrastructure-type-ov";
    public static readonly InfrastructureType Amplification = FromString("amplification");

    public static readonly InfrastructureType Anonymisation = FromString("anonymization");

    public static readonly InfrastructureType Botnet = FromString("botnet");

    public static readonly InfrastructureType CommandAndControl = FromString("command-and-control");

    public static readonly InfrastructureType ControlSystem = FromString("control-system");

    public static readonly InfrastructureType Exfiltration = FromString("exfiltration");

    public static readonly InfrastructureType Firewall = FromString("firewall");

    public static readonly InfrastructureType HostingMalware = FromString("hosting-malware");

    public static readonly InfrastructureType HostingTargetLists = FromString("hosting-target-lists");

    public static readonly InfrastructureType Phishing = FromString("phishing");

    public static readonly InfrastructureType Reconnaissance = FromString("reconnaissance");

    public static readonly InfrastructureType RoutersSwitches = FromString("routers-switches");

    public static readonly InfrastructureType Staging = FromString("staging");

    public static readonly InfrastructureType Workstation = FromString("workstation");

    public static readonly InfrastructureType Unknown = FromString("unknown");

    private InfrastructureType(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static InfrastructureType FromString(string value)
    {
        if (OpenVocabManager<InfrastructureType>.TryGetValue(value, out InfrastructureType? vocab))
            return vocab!;

        vocab = new InfrastructureType(value);
        OpenVocabManager<InfrastructureType>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}