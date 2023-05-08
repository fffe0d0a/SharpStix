using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using System.Text.Json.Serialization;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ToolType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ToolType(string Value) : StixOpenVocab(Value)
{
    private const string TYPE = "tool-type-ov";

    public enum EToolType
    {
        /// <summary>
        ///     Tools used to perform denial of service attacks or DDoS attacks, such as Low Orbit Ion Cannon (LOIC) and DHCPig.
        /// </summary>
        DenialOfService,

        /// <summary>
        ///     Tools used to exploit software and systems, such as sqlmap and Metasploit.
        /// </summary>
        Exploitation,

        /// <summary>
        ///     Tools used to enumerate system and network information, e.g., NMAP.
        /// </summary>
        InformationGathering,

        /// <summary>
        ///     Tools used to capture network traffic, such as Wireshark and Kismet.
        /// </summary>
        NetworkCapture,

        /// <summary>
        ///     Tools used to crack password databases or otherwise exploit/discover credentials, either locally or remotely, such
        ///     as John the Ripper and NCrack.
        /// </summary>
        CredentialExploitation,

        /// <summary>
        ///     Tools used to access machines remotely, such as VNC and Remote Desktop.
        /// </summary>
        RemoteAccess,

        /// <summary>
        ///     Tools used to scan systems and networks for vulnerabilities, e.g., Nessus.
        /// </summary>
        VulnerabilityScanning,

        /// <summary>
        ///     There is not enough information available to determine the type of tool.
        /// </summary>
        Unknown
    }

    public ToolType(EToolType value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public override string Type => TYPE;
}