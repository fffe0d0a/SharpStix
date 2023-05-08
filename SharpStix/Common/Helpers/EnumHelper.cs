using System.Collections.Frozen;

namespace SharpStix.Common.Helpers;

internal static class EnumHelper<T> where T : Enum
{
    static EnumHelper()
    {
        Map = Enum.GetNames(typeof(T)).ToFrozenDictionary(x => x, x => (T)Enum.Parse(typeof(T), x));
    }

    private static FrozenDictionary<string, T> Map { get; }

    public static T FromString(string value)
    {
        return Map[value];
    }
}