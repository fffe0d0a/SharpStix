using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record RasterImageFileExtension : CyberObservableObject
{
    private const string TYPE = "raster-image-ext";

    public Int54? ImageHeight { get; init; }
    public Int54? ImageWidth { get; init; }
    public Int54? BitsPerPixel { get; init; }
    public StixDictionary<ExifTag>? ExifTags { get; init; } //warn not compliant

    public override string Type => TYPE;
}