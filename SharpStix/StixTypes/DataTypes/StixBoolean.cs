using SharpStix.Common;

namespace SharpStix.StixTypes;

public readonly record struct StixBoolean(bool Value) : IStixDataType
{
    public static string TypeName => "boolean";

    public override string ToString() => Value ? "true" : "false";
}