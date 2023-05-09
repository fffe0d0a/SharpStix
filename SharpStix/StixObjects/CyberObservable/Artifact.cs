using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record Artifact : CyberObservableObject
{
    private const string TYPE = "artifact";

    public string? MimeType { get; init; }
    public StixBinary? PayloadBin { get; init; }
    public string? Url { get; init; }
    public StixHashes? Hashes { get; init; } //warn not compliant
    public EncryptionAlgorithmEnum? EncryptionAlgorithm { get; init; }
    public string? DecryptionKey { get; init; }

    public override string Type => TYPE;
}