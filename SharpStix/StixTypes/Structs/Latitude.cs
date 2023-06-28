using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;

namespace SharpStix.StixTypes;

[JsonConverter(typeof(LatitudeConverter))]
public readonly record struct Latitude
{
    public Latitude(double value)
    {
        if (value is < -90 or > 90)
            throw new ArgumentOutOfRangeException(nameof(value),
                "Latitude must be within the range of [-90, 90] inclusive.");

        Value = value;
    }

    public double Value { get; }

    public static implicit operator double(Latitude value) => value.Value;
}