namespace SharpStix.StixObjects.CyberObservable;

public sealed record RasterImageFileExtension() : CyberObservableObject()
{
    public int? ImageHeight { get; init; }
    public int? ImageWidth { get; init; }
    public int? BitsPerPixel { get; init; }
    public Dictionary<string, string>? ExifTags { get; init; } //warn not compliant

    public new static string TypeName => "raster-image-ext";
}