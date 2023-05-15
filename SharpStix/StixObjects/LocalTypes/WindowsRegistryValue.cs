using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixObjects.CyberObservable;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsRegistryValue : CyberObservableObject
{
    private const string TYPE = "windows-registry-value-type";

    public string? Name { get; init; }
    public string? Data { get; init; }
    public WindowsRegistryDatatypeEnum? DataType { get; init; }

    [JsonIgnore]
    public override string Type => TYPE;
}