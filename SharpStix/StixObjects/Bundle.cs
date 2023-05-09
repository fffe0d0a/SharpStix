using SharpStix.Common;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record Bundle : IStixType, IHasTypeName, IHasId //warn this is not a StixObject
{
    private const string TYPE = "bundle";
    public List<StixObject>? Objects { get; init; }
    public required StixIdentifier Id { get; init; }

    public string Type => TYPE;
}