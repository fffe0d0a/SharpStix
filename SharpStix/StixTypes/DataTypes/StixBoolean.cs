using SharpStix.Services;

namespace SharpStix.StixTypes;

[StixTypeDiscriminator(TYPE)]
public readonly record struct StixBoolean(bool Value) : IStixDataType
{
    private const string TYPE = "boolean";

    public string Type => TYPE;

    public override string ToString()
    {
        return Value ? "true" : "false";
    }
}