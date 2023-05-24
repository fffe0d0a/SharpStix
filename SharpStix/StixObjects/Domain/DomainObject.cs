using SharpStix.StixTypes;
using System.Globalization;

namespace SharpStix.StixObjects.Domain;

public abstract record DomainObject : CoreObject, IVersioned
{
    private const string TYPE = "domain-object";

    public required SpecVersion SpecVersion { get; init; }
    public StixList<string>? Labels { get; init; }

    public Confidence? Confidence { get; init; }

    public CultureInfo? Lang { get; init; }
    public StixList<StixExternalReference>? ExternalReferences { get; init; }
    public StixIdentifier? CreatedByRef { get; init; }
    public required DateTime Created { get; init; }
    public required DateTime Modified { get; init; }
    public bool? Revoked { get; init; }
}