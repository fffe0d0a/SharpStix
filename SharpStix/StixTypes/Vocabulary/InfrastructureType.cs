using SharpStix.Extensions;

namespace SharpStix.StixTypes.Vocabulary;

public sealed record InfrastructureType(string Value) : StixOpenVocab(Value)
{
    public enum EInfrastructureType
    {
        /// <summary>
        ///     Specifies infrastructure used for conducting amplification attacks.
        /// </summary>
        Amplification,

        /// <summary>
        ///     Specific infrastructure used for anonymization, such as a proxy.
        /// </summary>
        Anonymization,

        /// <summary>
        ///     Specifies the membership/makeup of a botnet, in terms of the network addresses of the hosts that comprise the
        ///     botnet.
        /// </summary>
        Botnet,

        /// <summary>
        ///     Specifies infrastructure used for command and control (C2). This is typically a domain name or IP address.
        /// </summary>
        CommandAndControl,

        /// <summary>
        ///     Specifies equipment such as IoT, HMI, RTU, PLC or other ICS devices.
        /// </summary>
        ControlSystem,

        /// <summary>
        ///     Specifies infrastructure used as an endpoint for data exfiltration.
        /// </summary>
        Exfiltration,

        /// <summary>
        ///     Specifies a device that inspects network traffic and restricts it based upon defined policies.
        /// </summary>
        Firewall,

        /// <summary>
        ///     Specifies infrastructure used for hosting malware.
        /// </summary>
        HostingMalware,

        /// <summary>
        ///     Specifies infrastructure used for hosting a list of targets for DDOS attacks, phishing, and other malicious
        ///     activities. This is typically a domain name or IP address.
        /// </summary>
        HostingTargetLists,

        /// <summary>
        ///     Specifies infrastructure used for conducting phishing attacks.
        /// </summary>
        Phishing,

        /// <summary>
        ///     Specifies infrastructure used for conducting reconnaissance activities.
        /// </summary>
        Reconnaissance,

        /// <summary>
        ///     Specifies IT infrastructure used to connect devices to the network.
        /// </summary>
        RoutersSwitches,

        /// <summary>
        ///     Specifies infrastructure used for staging.
        /// </summary>
        Staging,

        /// <summary>
        ///     Specifies an endpoint machine used for work by an organization that needs protection.
        /// </summary>
        Workstation,

        /// <summary>
        ///     Specifies an infrastructure of some unknown type.
        /// </summary>
        Unknown
    }

    public InfrastructureType(EInfrastructureType value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public new static string TypeName => "infrastructure-type-ov";
}