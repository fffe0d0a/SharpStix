using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record X509Certificate : CyberObservableObject
{
    private const string TYPE = "x509-certificate";

    public bool? IsSelfSigned { get; init; }
    public StixHashes? Hashes { get; init; }
    public string? Version { get; init; }
    public string? SerialNumber { get; init; }
    public string? SignatureAlgorithm { get; init; }
    public string? Issuer { get; init; }
    public DateTime? ValidityNotBefore { get; init; }
    public DateTime? ValidityNotAfter { get; init; }
    public string? Subject { get; init; }
    public string? SubjectPublicKeyAlgorithm { get; init; }
    public string? SubjectPublicKeyModules { get; init; }
    public Int54? SubjectPublicKeyExponent { get; init; } //bug surely e can be much larger than 2^54. This is a flaw with Stix itself
    public X509V3Extensions? X509V3Extensions { get; init; }

    public override string Type => TYPE;
}