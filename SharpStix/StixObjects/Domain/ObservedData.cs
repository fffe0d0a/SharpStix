using System.ComponentModel.DataAnnotations;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record ObservedData() : DomainObject
{
    private const string TYPE = "observed-data";

    //[Obsolete]
    //public ObservedData(object objects) : this()
    //{
    //    Objects = objects;
    //}

    public ObservedData(params StixIdentifier[] objectRefs) : this()
    {
        ObjectRefs = new StixList<StixIdentifier>(objectRefs);
    }

    /// <summary>
    ///     The beginning of the time window during which the data was seen.
    /// </summary>
    public required DateTime FirstObserved { get; init; }

    /// <summary>
    ///     The end of the time window during which the data was seen.
    /// </summary>
    public required DateTime LastObserved { get; init; }

    /// <summary>
    ///     The number of times that each Cyber-observable object represented in the objects or object_ref property was seen.
    /// </summary>
    [Range(1, 999999999)]
    public required StixInteger NumberObserved { get; init; } //warn validate in class

    //[Obsolete] public object? Objects { get; init; } //todo observable-container

    /// <summary>
    ///     A list of SCOs and SROs representing the observation.
    /// </summary>
    public StixList<StixIdentifier>? ObjectRefs { get; init; }

    public override string Type => TYPE;
}