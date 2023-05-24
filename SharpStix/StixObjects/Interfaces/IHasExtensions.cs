using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

public interface IHasExtensions
{
    [JsonExtensionData] public StixExtensions? Extensions { get; init; }
}