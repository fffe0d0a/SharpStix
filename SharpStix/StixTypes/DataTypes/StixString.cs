namespace SharpStix.StixTypes;

public readonly record struct StixString(string Value) : IStixDataType
{
    private const string TYPE = "string";
}

