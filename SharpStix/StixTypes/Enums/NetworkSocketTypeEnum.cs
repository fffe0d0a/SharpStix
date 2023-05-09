﻿using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record NetworkSocketTypeEnum : Enumeration<NetworkSocketTypeEnum>, IStixEnum
{
    private const string TYPE = "network-socket-type-enum";

    /// <summary>
    ///     Specifies a pipe-like socket which operates over a connection with a particular remote socket and transmits data
    ///     reliably as a stream of bytes.
    /// </summary>
    public readonly static NetworkSocketTypeEnum Stream = new NetworkSocketTypeEnum(ENetworkSocketType.SOCK_STREAM);

    /// <summary>
    ///     Specifies a socket in which individually-addressed packets are sent (datagram).
    /// </summary>
    public readonly static NetworkSocketTypeEnum Datagram = new NetworkSocketTypeEnum(ENetworkSocketType.SOCK_DGRAM);

    /// <summary>
    ///     Specifies raw sockets which allow new IP protocols to be implemented in user space.
    /// </summary>
    public readonly static NetworkSocketTypeEnum Raw = new NetworkSocketTypeEnum(ENetworkSocketType.SOCK_RAW);

    /// <summary>
    ///     Specifies a socket indicating a reliably-delivered message.
    /// </summary>
    public readonly static NetworkSocketTypeEnum ReliableDatagram =
        new NetworkSocketTypeEnum(ENetworkSocketType.SOCK_RDM);

    /// <summary>
    ///     Specifies a datagram congestion control protocol socket.
    /// </summary>
    public readonly static NetworkSocketTypeEnum SeqPacket =
        new NetworkSocketTypeEnum(ENetworkSocketType.SOCK_SEQPACKET);

    private NetworkSocketTypeEnum(ENetworkSocketType value) : base(value)
    {
    }

    public string Type => TYPE;

    private enum ENetworkSocketType
    {
        // ReSharper disable InconsistentNaming

        SOCK_STREAM,
        SOCK_DGRAM,
        SOCK_RAW,
        SOCK_RDM,
        SOCK_SEQPACKET

        // ReSharper restore InconsistentNaming
    }
}