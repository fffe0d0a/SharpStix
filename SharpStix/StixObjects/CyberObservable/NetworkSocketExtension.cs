using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record NetworkSocketExtension : CyberObservableObject
{
    private const string TYPE = "socket-ext";

    public required NetworkSocketAddressFamilyEnum AddressFamilyEnum { get; init; }
    public bool? IsBlocking { get; init; }
    public bool? IsListening { get; init; }
    public StixDictionary<int>? Options { get; init; } //todo this can be an string, enum
    public NetworkSocketTypeEnum? SocketType { get; init; }
    public Int54? SocketDescriptor { get; init; }
    public Int54? SocketHandle { get; init; }

    public override string Type => TYPE;
}