namespace SharpStix.StixTypes;

public interface IStixEnum : IStixDataType
{
    protected string DisplayName { get; }
}