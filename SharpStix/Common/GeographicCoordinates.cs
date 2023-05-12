namespace SharpStix.Common;

public readonly record struct GeographicCoordinates
{
    public GeographicCoordinates(double latitude, double longitude)
    {
        if (latitude is < -90d or > 90d)
            throw new ArgumentOutOfRangeException(nameof(latitude), latitude, "Latitude must be between -90d and 90d.");
        if (longitude is < -180d or > 180d)
            throw new ArgumentOutOfRangeException(nameof(longitude), longitude, "Longitude must be between -180d and 180d.");

        Latitude = latitude;
        Longitude = longitude;
    }

    public GeographicCoordinates(double latitude, double longitude, double precision) : this(latitude, longitude)
    {
        Precision = precision;
    }

    public double Latitude { get; }
    public double Longitude { get; }

    /// <summary>
    ///     Defines the precision of the coordinates specified by the latitude and longitude properties. This is measured in
    ///     meters. The actual location may be anywhere up to precision meters from the defined point.
    /// </summary>
    public double? Precision { get; }
}