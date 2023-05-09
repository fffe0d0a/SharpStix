using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Indicator : DomainObject
{
    private const string TYPE = "indicator";

    /// <summary>
    ///     A name used to identify the Indicator.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Indicator, potentially including its purpose and its
    ///     key characteristics.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     A set of categorizations for this indicator.
    /// </summary>
    public StixList<IndicatorType>? IndicatorTypes { get; init; }

    /// <summary>
    ///     The detection pattern for this Indicator.
    /// </summary>
    public required string Pattern { get; init; }

    /// <summary>
    ///     The pattern language used in this indicator.
    /// </summary>
    public required PatternType PatternType { get; init; }

    /// <summary>
    ///     The version of the pattern language that is used for the data in the pattern property.
    /// </summary>
    public string? PatternVersion { get; init; }

    /// <summary>
    ///     The time from which this Indicator is considered a valid indicator of the behaviours it is related or represents.
    /// </summary>
    public required DateTime ValidFrom { get; init; }

    /// <summary>
    ///     The time at which this Indicator should no longer be considered a valid indicator of the behaviours it is related
    ///     to or represents.
    /// </summary>
    public DateTime? ValidUntil { get; init; }

    /// <summary>
    ///     The kill chain phase(s) to which this Indicator corresponds.
    /// </summary>
    public StixList<StixKillChainPhase>? KillChainPhases { get; init; }

    public override string Type => TYPE;
}