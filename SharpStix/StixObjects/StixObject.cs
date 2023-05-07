using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

[JsonConverter(typeof(StixObjectConverter))]
public abstract record StixObject : IStixType, IHasId
{
    public required StixIdentifier Id { get; init; }
    public static string TypeName => "stix-object";
}