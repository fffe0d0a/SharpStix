using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using FluentValidation;
using SharpStix.Common;
using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Location : DomainObject
{
    private const string TYPE = "location";

    [JsonConstructor]
    public Location()
    {

    }

    public Location(Region region)
    {
        Region = region;
    }

    public Location(string country)
    {
        Country = country;
    }

    public Location(GeographicCoordinates coordinates)
    {
        Latitude = new StixFloat(coordinates.Latitude);
        Longitude = new StixFloat(coordinates.Longitude);
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
    public StixFloat? Latitude { get; init; } //warn validate in this class

    /// <summary>
    ///     The longitude of the Location in decimal degrees. Positive numbers describe longitudes east of the prime meridian
    ///     and negative numbers describe longitudes west of the prime meridian.
    /// </summary>
    [Range(-90d, 90d)]
    public StixFloat? Longitude { get; init; }

    /// <summary>
    ///     Defines the precision of the coordinates specified by the latitude and longitude properties. This is measured in
    ///     meters. The actual Location may be anywhere up to precision meters from the defined point.
    /// </summary>
    public StixFloat? Precision { get; init; }

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

    public GeographicCoordinates? GetCoordinates()
    {
        if (Latitude is null || Longitude is null)
            return null;
        return Precision is not null
            ? new GeographicCoordinates(Latitude.Value, Longitude.Value, Precision.Value) 
            : new GeographicCoordinates(Latitude.Value, Longitude.Value);
    }
}

public class LocationValidator : AbstractValidator<Location>
{
    private const string MISSING_ONE_OF_MESSAGE =
        $"One of {nameof(Location.Region)}, {nameof(Location.Country)}, or {nameof(Location.Latitude)} & {nameof(Location.Longitude)} must be set.";

    public LocationValidator()
    {
        RuleFor(x => x.Region)
            .NotNull()
            .When(x => x.Country is null && (x.Longitude is null || x.Latitude is null))
            .WithSeverity(Severity.Error)
            .WithMessage(MISSING_ONE_OF_MESSAGE);

        RuleFor(x => x.Country)
            .NotNull()
            .When(x => x.Region is null && (x.Longitude is null || x.Latitude is null))
            .WithSeverity(Severity.Error)
            .WithMessage(MISSING_ONE_OF_MESSAGE);

        RuleFor(x => x.Longitude)
            .NotNull()
            .When(x => x.Country is null && x.Region is null)
            .WithSeverity(Severity.Error)
            .WithMessage(MISSING_ONE_OF_MESSAGE);

        RuleFor(x => x.Latitude)
            .NotNull()
            .When(x => x.Country is null && x.Region is null)
            .WithSeverity(Severity.Error)
            .WithMessage(MISSING_ONE_OF_MESSAGE);

        RuleFor(x => x.Longitude)
            .NotNull()
            .When(x => x.Latitude is not null)
            .WithSeverity(Severity.Error)
            .WithMessage($"{nameof(Location.Longitude)} must be set when {nameof(Location.Latitude)} is set.");

        RuleFor(x => x.Latitude)
            .NotNull()
            .When(x => x.Longitude is not null)
            .WithSeverity(Severity.Error)
            .WithMessage($"{nameof(Location.Latitude)} must be set when {nameof(Location.Longitude)} is set.");

        RuleFor(x => x.Latitude!.Value.Value)
            .InclusiveBetween(-90d, 90d)
            .When(x => x.Latitude is not null)
            .WithSeverity(Severity.Error)
            .WithMessage("Latitude must be between -90 and 90");

        RuleFor(x => x.Longitude!.Value.Value)
            .InclusiveBetween(-180d, 180d)
            .When(x => x.Longitude is not null)
            .WithSeverity(Severity.Error)
            .WithMessage("Longitude must be between -180 and 180");
    }
}