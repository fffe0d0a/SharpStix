using SharpStix.StixTypes;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record Artifact : CyberObservableObject
{
    public string? MimeType { get; init; }
    public Memory<byte>? PayloadBin { get; init; }
    public string? Url { get; init; }
    public StixHashes? Hashes { get; init; } //warn not compliant //note hashes itself is not compliant afaik
    public EncryptionAlgorithmEnum? EncryptionAlgorithm { get; init; }
    public string? DecryptionKey { get; init; }

    public new static string TypeName => "artifact";
}