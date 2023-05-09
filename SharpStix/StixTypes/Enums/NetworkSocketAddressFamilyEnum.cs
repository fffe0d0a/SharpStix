using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record NetworkSocketAddressFamilyEnum : Enumeration<NetworkSocketAddressFamilyEnum>, IStixEnum
{
    private const string TYPE = "network-socket-address-family-enum";

    public readonly static NetworkSocketAddressFamilyEnum Unspecified =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_UNSPEC);

    public readonly static NetworkSocketAddressFamilyEnum INet =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_INET);

    public readonly static NetworkSocketAddressFamilyEnum INet6 =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_INET6);

    public readonly static NetworkSocketAddressFamilyEnum IPX =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_IPX);

    public readonly static NetworkSocketAddressFamilyEnum AppleTalk =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_APPLETALK);

    public readonly static NetworkSocketAddressFamilyEnum NetBIOS =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_NETBIOS);

    public readonly static NetworkSocketAddressFamilyEnum IRDA =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_IRDA);

    public readonly static NetworkSocketAddressFamilyEnum BTH =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_BTH);

    private NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily value) : base(value)
    {
    }

    public string Type => TYPE;

    private enum ENetworkSocketAddressFamily
    {
        // ReSharper disable InconsistentNaming

        AF_UNSPEC,
        AF_INET,
        AF_IPX,
        AF_APPLETALK,
        AF_NETBIOS,
        AF_INET6,
        AF_IRDA,
        AF_BTH

        // ReSharper restore InconsistentNaming
    }
}