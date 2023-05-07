﻿using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record X509Certificate() : CyberObservableObject()
{
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
    public int? SubjectPublicKeyExponent { get; init; } //bug e could be > int.Max, this is a flaw with Stix itself
    public X509V3Extensions? X509V3Extensions { get; init; }

    public new static string TypeName => "x509-certificate";
}