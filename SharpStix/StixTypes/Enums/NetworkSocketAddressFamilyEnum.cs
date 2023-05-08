using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record NetworkSocketAddressFamilyEnum : Enumeration<NetworkSocketAddressFamilyEnum>, IStixEnum
{
    private const string TYPE = "network-socket-address-family-enum";

    public static readonly NetworkSocketAddressFamilyEnum Unspecified =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_UNSPEC);

    public static readonly NetworkSocketAddressFamilyEnum INet =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_INET);

    public static readonly NetworkSocketAddressFamilyEnum INet6 =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_INET6);

    public static readonly NetworkSocketAddressFamilyEnum IPX =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_IPX);

    public static readonly NetworkSocketAddressFamilyEnum AppleTalk =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_APPLETALK);

    public static readonly NetworkSocketAddressFamilyEnum NetBIOS =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_NETBIOS);

    public static readonly NetworkSocketAddressFamilyEnum IRDA =
        new NetworkSocketAddressFamilyEnum(ENetworkSocketAddressFamily.AF_IRDA);

    public static readonly NetworkSocketAddressFamilyEnum BTH =
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