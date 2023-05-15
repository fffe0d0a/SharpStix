using SharpStix.StixTypes;
using System.Globalization;
using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;

namespace SharpStix.StixObjects;

public record GranularMarking
{
    private const string TYPE = "granular-marking";

    public CultureInfo? Lang { get; set; }
    public StixIdentifier? MarkingRef { get; set; }
    public required StixList<Selector> Selectors { get; set; }
}

//todo improve abstraction
//Selectors contained in the selectors list are strings that consist of multiple components that MUST be separated by the.character.Each component MUST be one of:
//●	A property name or dictionary key, e.g., description, or;
//●	A zero-based list index, specified as a non-negative integer in square brackets, e.g., [4]
[JsonConverter(typeof(SelectorConverter))]
public record Selector
{
    public Selector(string value)
    {
        Values = value.Split('.', StringSplitOptions.RemoveEmptyEntries);
    }

    public string[] Values { get; }

    public override string ToString() => string.Join('.', Values);
}