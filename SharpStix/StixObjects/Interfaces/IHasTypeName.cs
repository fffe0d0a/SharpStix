using SharpStix.Services;

namespace SharpStix.StixObjects;

public interface IHasTypeName
{
    /// <summary>
    ///     A type discriminator to aid serialisation.
    /// </summary>
    public string Type { get; }
}