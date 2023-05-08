using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes;

[StixTypeDiscriminator(TYPE)]
public readonly record struct StixBoolean(bool Value) : IStixDataType
{
    private const string TYPE = "boolean";

    public override string ToString() => Value ? "true" : "false";

    public string Type => TYPE;
}