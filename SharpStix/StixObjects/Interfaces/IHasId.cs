using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

public interface IHasId
{
    public StixIdentifier Id { get; init; }
}