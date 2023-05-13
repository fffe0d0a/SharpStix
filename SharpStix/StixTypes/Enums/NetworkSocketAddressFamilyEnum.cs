using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(EnumerationConverterFactory))]
public sealed record NetworkSocketAddressFamilyEnum : Enumeration<NetworkSocketAddressFamilyEnum>, IStixEnum
{
    private const string TYPE = "network-socket-address-family-enum";

    public static readonly NetworkSocketAddressFamilyEnum Unspecified =
        new NetworkSocketAddressFamilyEnum(0, "AF_UNSPEC");

    public static readonly NetworkSocketAddressFamilyEnum INet =
        new NetworkSocketAddressFamilyEnum(1, "AF_INET");

    public static readonly NetworkSocketAddressFamilyEnum IPX =
        new NetworkSocketAddressFamilyEnum(2, "AF_IPX");

    public static readonly NetworkSocketAddressFamilyEnum AppleTalk =
        new NetworkSocketAddressFamilyEnum(3, "AF_APPLETALK");

    public static readonly NetworkSocketAddressFamilyEnum NetBIOS =
        new NetworkSocketAddressFamilyEnum(4, "AF_NETBIOS");

    public static readonly NetworkSocketAddressFamilyEnum INet6 =
        new NetworkSocketAddressFamilyEnum(5, "AF_INET6");

    public static readonly NetworkSocketAddressFamilyEnum IRDA =
        new NetworkSocketAddressFamilyEnum(6, "AF_IRDA");

    public static readonly NetworkSocketAddressFamilyEnum BTH =
        new NetworkSocketAddressFamilyEnum(7, "AF_BTH");

    private NetworkSocketAddressFamilyEnum(int value, string displayName) : base(value, displayName)
    {
    }

    public string Type => TYPE;
}