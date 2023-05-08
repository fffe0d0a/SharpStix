using System.ComponentModel.DataAnnotations;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Relationship;

public abstract record RelationshipObject : CoreObject, IVersioned
{
    private const string TYPE = "relationship-object";

    public required SpecVersion SpecVersion { get; init; }
    public List<string>? Labels { get; init; }

    [Range(0, 100)] public int? Confidence { get; init; }

    public Lang? Lang { get; init; }
    public List<StixExternalReference>? ExternalReferences { get; init; }
    public StixIdentifier? CreatedByRef { get; init; }
    public required DateTime Created { get; init; }
    public required DateTime Modified { get; init; }
    public bool? Revoked { get; init; }
}