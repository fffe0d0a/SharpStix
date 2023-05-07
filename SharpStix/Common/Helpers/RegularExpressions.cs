using System.Text.RegularExpressions;

namespace SharpStix.Common.Helpers;

internal static partial class RegularExpressions
{
    [GeneratedRegex("^[A-Za-z0-9\\-_]{1,250}$")]
    public static partial Regex ValidDictionaryKey();

    [GeneratedRegex("^[A-Za-z0-9\\-_]{3,250}$")]
    public static partial Regex ValidHashesKey();

    [GeneratedRegex("^[a-z0-9\\-]{0,}$")]
    public static partial Regex LowercaseHyphenated();

    [GeneratedRegex(@"(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z0-9])")]
    internal static partial Regex MatchPascalRegex();

    [GeneratedRegex(@"[^A-Za-z0-9\-_]")]
    internal static partial Regex MatchForbiddenDictKeyChars();
}