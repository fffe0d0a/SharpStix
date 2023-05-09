using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record PdfFileExtension : CyberObservableObject
{
    private const string TYPE = "pdf-ext";

    public string? Version { get; init; }
    public bool? IsOptimized { get; init; }
    public StixDictionary<string>? DocumentInfoDict { get; init; }

    [JsonPropertyName("pdfid0")] public string? Pdfid0 { get; init; }

    [JsonPropertyName("pdfid1")] public string? Pdfid1 { get; init; }


    public override string Type => TYPE;
}