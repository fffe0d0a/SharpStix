using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record RasterImageFileExtension : CyberObservableObject
{
    private const string TYPE = "raster-image-ext";

    public StixInteger? ImageHeight { get; init; }
    public StixInteger? ImageWidth { get; init; }
    public StixInteger? BitsPerPixel { get; init; }
    public StixDictionary<ExifTag>? ExifTags { get; init; } //warn not compliant

    public override string Type => TYPE;
}