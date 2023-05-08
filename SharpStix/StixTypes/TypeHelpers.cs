using SharpStix.Common;
using SharpStix.StixObjects;

namespace SharpStix.StixTypes;

internal static class TypeHelpers
{
    /// <summary>
    ///     Tests whether the provided object type can be used as a property in a <see cref="StixObject" />.
    /// </summary>
    /// <typeparam name="T">Type to test.</typeparam>
    /// <param name="obj"></param>
    /// <returns>True if <paramref name="obj" /> is a valid type of Stix object property. Otherwise false.</returns>
    public static bool IsTypeOfStixProperty<T>(T obj)
    {
        if (obj is IStixType or Enum)
            return true;
        return false;

        //if (typeof(T) == typeof(Wrapper<>))
        //    return true;

        //return obj switch
        //{
        //    string => true,
        //    bool => true,
        //    double => true,
        //    byte[] => true,
        //    Enum => true,
        //    DateTime => true,
        //    StixExternalReference => true,
        //    StixIdentifier => true,
        //    StixKillChainPhase => true,
        //    StixOpenVocab => true,
        //    _ => false
        //};
    }
}