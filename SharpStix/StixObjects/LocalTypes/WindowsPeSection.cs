using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixObjects.CyberObservable;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsPeSection : CyberObservableObject
{
    private const string TYPE = "windows-pe-section-type";

    public required string Name { get; init; }
    public Int54? Size { get; init; }

    [Range(0, 8)] public StixFloat? Entropy { get; init; } //todo validate in this obj

    public StixHashes? Hashes { get; init; }

    [JsonIgnore] public override string Type => TYPE;
}