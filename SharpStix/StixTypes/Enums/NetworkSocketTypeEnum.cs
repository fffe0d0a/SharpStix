using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(EnumerationConverterFactory))]
public sealed record NetworkSocketTypeEnum : Enumeration<NetworkSocketTypeEnum>, IStixEnum
{
    private const string TYPE = "network-socket-type-enum";

    /// <summary>
    ///     Specifies a pipe-like socket which operates over a connection with a particular remote socket and transmits data
    ///     reliably as a stream of bytes.
    /// </summary>
    public static readonly NetworkSocketTypeEnum Stream = new NetworkSocketTypeEnum(0, "SOCK_STREAM");

    /// <summary>
    ///     Specifies a socket in which individually-addressed packets are sent (datagram).
    /// </summary>
    public static readonly NetworkSocketTypeEnum Datagram = new NetworkSocketTypeEnum(1, "SOCK_DGRAM");

    /// <summary>
    ///     Specifies raw sockets which allow new IP protocols to be implemented in user space.
    /// </summary>
    public static readonly NetworkSocketTypeEnum Raw = new NetworkSocketTypeEnum(2, "SOCK_RAW");

    /// <summary>
    ///     Specifies a socket indicating a reliably-delivered message.
    /// </summary>
    public static readonly NetworkSocketTypeEnum ReliableDatagram = new NetworkSocketTypeEnum(3, "SOCK_RDM");

    /// <summary>
    ///     Specifies a datagram congestion control protocol socket.
    /// </summary>
    public static readonly NetworkSocketTypeEnum SeqPacket = new NetworkSocketTypeEnum(4, "SOCK_SEQPACKET");

    private NetworkSocketTypeEnum(int value, string displayName) : base(value, displayName)
    {
    }

    public string Type => TYPE;
}