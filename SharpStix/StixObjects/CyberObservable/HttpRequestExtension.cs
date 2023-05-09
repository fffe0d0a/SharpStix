using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record HttpRequestExtension : CyberObservableObject
{
    private const string TYPE = "http-request-ext";

    public required string RequestMethod { get; init; }
    public required string RequestValue { get; init; }
    public string? RequestVersion { get; init; }
    public StixDictionary<string>? RequestHeader { get; init; }
    public StixInteger? MessageBodyLength { get; init; }
    public StixIdentifier? MessageBodyDataRef { get; init; }

    public override string Type => TYPE;
}