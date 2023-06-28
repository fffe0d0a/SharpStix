using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixObjects.CyberObservable;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record AlternateDataStream : CyberObservableObject
{
    private const string TYPE = "alternate-data-stream-type";

    public required string Name { get; init; }
    public StixHashes? Hashes { get; init; }
    public Int54? Size { get; init; }

    [JsonIgnore] public override string Type => TYPE;
}