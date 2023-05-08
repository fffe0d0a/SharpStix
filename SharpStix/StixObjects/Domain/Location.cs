using System.ComponentModel.DataAnnotations;
using SharpStix.Services;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Location() : DomainObject
{
    private const string TYPE = "location";

    public Location(Region region) : this()
    {
        Region = region;
    }

    public Location(string country) : this()
    {
        Country = country;
    }

    public Location(double latitude, double longitude) : this()
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    /// <summary>
    ///     A name used to identify the Location.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    ///     A textual description of the Location.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     The latitude of the Location in decimal degrees. Positive numbers describe latitudes north of the equator, and
    ///     negative numbers describe latitudes south of the equator.
    /// </summary>
    [Range(-90d, 90d)]
    public double? Latitude { get; init; }

    /// <summary>
    ///     The longitude of the Location in decimal degrees. Positive numbers describe longitudes east of the prime meridian
    ///     and negative numbers describe longitudes west of the prime meridian.
    /// </summary>
    [Range(-90d, 90d)]
    public double? Longitude { get; init; }

    /// <summary>
    ///     Defines the precision of the coordinates specified by the latitude and longitude properties. This is measured in
    ///     meters. The actual Location may be anywhere up to precision meters from the defined point.
    /// </summary>
    public double? Precision { get; init; }

    /// <summary>
    ///     The region that this Location describes.
    /// </summary>
    public Region? Region { get; init; }

    /// <summary>
    ///     The country that this Location describes.
    /// </summary>
    public string? Country { get; init; }

    /// <summary>
    ///     The state, province, or other sub-national administrative area that this Location describes.
    /// </summary>
    public string? AdministrativeArea { get; init; }

    /// <summary>
    ///     The city that this Location describes.
    /// </summary>
    public string? City { get; init; }

    /// <summary>
    ///     The street address that this Location describes. This property includes all aspects or parts of the street address.
    /// </summary>
    public string? StreetAddress { get; init; }

    /// <summary>
    ///     The postal code for this Location.
    /// </summary>
    public string? PostalCode { get; init; }

    public override string Type => TYPE;
}