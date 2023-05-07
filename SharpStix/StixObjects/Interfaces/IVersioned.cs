using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

public interface IVersioned
{
    public StixIdentifier? CreatedByRef { get; init; }
    public DateTime Created { get; init; }
    public DateTime Modified { get; init; }
    public bool? Revoked { get; init; }
}