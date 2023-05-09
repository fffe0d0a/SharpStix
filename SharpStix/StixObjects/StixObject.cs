using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

[JsonConverter(typeof(StixObjectConverter))]
public abstract record StixObject : IStixType, IHasTypeName, IHasId
{
    private const string TYPE = "stix-object";

    public required StixIdentifier Id { get; init; }
    public abstract string Type { get; }
}