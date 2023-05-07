namespace SharpStix.StixTypes;

//todo
public record GranularMarking
{
    public Lang? Lang { get; set; }
    public StixIdentifier? MarkingRef { get; set; }
    public List<string> Selectors { get; set; }
}