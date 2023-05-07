using SharpStix.Common;

namespace SharpStix.StixTypes;

public readonly record struct StixString(string Value) : IStixDataType
{
    public static string TypeName => "string";
}