using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

public abstract record StixObject : IStixType, IHasId
{

    public required StixIdentifier Id { get; init; }
    public static string TypeName => "stix-object";
}