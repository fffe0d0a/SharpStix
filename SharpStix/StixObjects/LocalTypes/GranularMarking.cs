using SharpStix.StixTypes;
using System.Globalization;

namespace SharpStix.StixObjects;

//todo

//Selectors contained in the selectors list are strings that consist of multiple components that MUST be separated by the.character.Each component MUST be one of:

//●	A property name or dictionary key, e.g., description, or;
//●	A zero-based list index, specified as a non-negative integer in square brackets, e.g., [4]

public record GranularMarking
{
    private const string TYPE = "granular-marking";

    public CultureInfo? Lang { get; set; }
    public StixIdentifier? MarkingRef { get; set; }
    public required StixList<string> Selectors { get; set; } //Selectors contained in the selectors list are strings that consist of multiple components that MUST be separated by the . character.
}