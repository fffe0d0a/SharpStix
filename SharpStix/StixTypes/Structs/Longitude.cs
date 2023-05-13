using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;

namespace SharpStix.StixTypes;

[JsonConverter(typeof(LongitudeConverter))]
public readonly record struct Longitude
{
    public Longitude(double value)
    {
        if (value is < -180 or > 180)
            throw new ArgumentOutOfRangeException(nameof(value), "Longitude must be within the range of [-180, 180] inclusive.");

        Value = value;
    }

    public double Value { get; }

    public static implicit operator double(Longitude value) => value.Value;
}