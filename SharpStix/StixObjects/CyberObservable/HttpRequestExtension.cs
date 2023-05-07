using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record HttpRequestExtension() : CyberObservableObject
{
    public required string RequestMethod { get; init; }
    public required string RequestValue { get; init; }
    public string? RequestVersion { get; init; }
    public Dictionary<string, string>? RequestHeader { get; init; }
    public int? MessageBodyLength { get; init; }
    public StixIdentifier? MessageBodyDataRef { get; init; }

    public new static string TypeName => "http-request-ext";
}