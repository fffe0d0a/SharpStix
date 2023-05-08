using SharpStix.Services;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record RasterImageFileExtension : CyberObservableObject
{
    private const string TYPE = "raster-image-ext";

    public int? ImageHeight { get; init; }
    public int? ImageWidth { get; init; }
    public int? BitsPerPixel { get; init; }
    public Dictionary<string, string>? ExifTags { get; init; } //warn not compliant

    public override string Type => TYPE;
}