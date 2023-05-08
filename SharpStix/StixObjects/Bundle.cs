using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

public sealed record Bundle : IStixType, IHasId //warn this is not a StixObject
{
    public List<StixObject>? Objects { get; init; }
    public required StixIdentifier Id { get; init; }
    public static string TypeName => "bundle";
}