using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record Bundle : IStixType, IHasTypeName, IHasId, IHasExtensions //keep in mind that this is not a StixObject
{
    private const string TYPE = "bundle";
    public StixList<StixObject>? Objects { get; init; }
    public required StixIdentifier Id { get; init; }
    [JsonExtensionData] public StixExtensions? Extensions { get; init; }

    public string Type => TYPE;
}