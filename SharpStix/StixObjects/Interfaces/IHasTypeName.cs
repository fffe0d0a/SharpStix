using System.Text.Json.Serialization;

namespace SharpStix.StixObjects;

public interface IHasTypeName
{
    [JsonPropertyName("type")]
    public static abstract string TypeName { get; }
}