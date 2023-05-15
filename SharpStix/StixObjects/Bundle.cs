using SharpStix.Common;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record Bundle : IStixType, IHasTypeName, IHasId //keep in mind that this is not a StixObject
{
    private const string TYPE = "bundle";
    public StixList<StixObject>? Objects { get; init; }
    public required StixIdentifier Id { get; init; }

    public string Type => TYPE;
}