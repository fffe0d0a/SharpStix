namespace SharpStix.StixObjects.CyberObservable;

public sealed record X509V3Extensions() : CyberObservableObject()
{
    public string? BasicConstraints { get; init; }
    public string? NameConstraints { get; init; }
    public string? PolicyConstraints { get; init; }
    public string? KeyUsage { get; init; }
    public string? ExtendedKeyUsage { get; init; }
    public string? SubjectKeyUsage { get; init; }
    public string? AuthorityKeyIdentifier { get; init; }
    public string? SubjectAlternativeName { get; init; }
    public string? IssuerAlternativeName { get; init; }
    public string? SubjectDirectoryAttributes { get; init; }
    public string? CrlDistributionPoints { get; init; }
    public string? InhibitAnyPolicy { get; init; }
    public DateTime? PrivateKeyUsagePeriodNotBefore { get; init; }
    public DateTime? PrivateKeyUsagePeriodNotAfter { get; init; }
    public string? CertificatePolicies { get; init; }
    public string? PolicyMappings { get; init; }

    public new static string TypeName => "x509-v3-extensions-type";
}