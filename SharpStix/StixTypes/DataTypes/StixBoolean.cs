namespace SharpStix.StixTypes;

public readonly record struct StixBoolean(bool Value) : IStixDataType
{
    private const string TYPE = "boolean";

    public override string ToString()
    {
        return Value ? "true" : "false";
    }
}