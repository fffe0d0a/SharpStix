using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes;

[StixTypeDiscriminator(TYPE)]
public readonly record struct StixString(string Value) : IStixDataType
{
    private const string TYPE = "string";

    public  string Type => TYPE;
}