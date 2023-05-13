using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<InfrastructureType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record InfrastructureType(string Value) : StixOpenVocab(Value)
{
    public static readonly InfrastructureType Amplification = new InfrastructureType("amplification");

    public static readonly InfrastructureType Anonymisation = new InfrastructureType("anonymization");

    public static readonly InfrastructureType Botnet = new InfrastructureType("botnet");

    public static readonly InfrastructureType CommandAndControl = new InfrastructureType("command-and-control");

    public static readonly InfrastructureType ControlSystem = new InfrastructureType("control-system");

    public static readonly InfrastructureType Exfiltration = new InfrastructureType("exfiltration");

    public static readonly InfrastructureType Firewall = new InfrastructureType("firewall");

    public static readonly InfrastructureType HostingMalware = new InfrastructureType("hosting-malware");

    public static readonly InfrastructureType HostingTargetLists = new InfrastructureType("hosting-target-lists");

    public static readonly InfrastructureType Phishing = new InfrastructureType("phishing");

    public static readonly InfrastructureType Reconnaissance = new InfrastructureType("reconnaissance");

    public static readonly InfrastructureType RoutersSwitches = new InfrastructureType("routers-switches");

    public static readonly InfrastructureType Staging = new InfrastructureType("staging");

    public static readonly InfrastructureType Workstation = new InfrastructureType("workstation");

    public static readonly InfrastructureType Unknown = new InfrastructureType("unknown");

    private const string TYPE = "infrastructure-type-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}