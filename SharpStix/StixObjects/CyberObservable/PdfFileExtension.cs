using System.Text.Json.Serialization;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record PdfFileExtension() : CyberObservableObject()
{
    public string? Version { get; init; }
    public bool? IsOptimized { get; init; }
    public Dictionary<string, string>? DocumentInfoDict { get; init; }

    [JsonPropertyName("pdfid0")] public string? Pdfid0 { get; init; }

    [JsonPropertyName("pdfid1")] public string? Pdfid1 { get; init; }

    public new static string TypeName => "pdf-ext";
}