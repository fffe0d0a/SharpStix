using SharpStix.Extensions;

namespace SharpStix.StixTypes.Vocabulary;

public sealed record Region(string Value) : StixOpenVocab(Value)
{
    public enum ERegion
    {
        Africa,
        EasternAfrica,
        MiddleAfrica,
        NorthernAfrica,
        SouthernAfrica,
        WesternAfrica,
        Americas,
        Caribbean,
        CentralAmerica,
        LatinAmericaCaribbean,
        NorthernAmerica,
        SouthAmerica,
        Asia,
        CentralAsia,
        EasternAsia,
        SouthernAsia,
        SouthEasternAsia,
        WesternAsia,
        Europe,
        EasternEurope,
        NorthernEurope,
        SouthernEurope,
        WesternEurope,
        Oceania,
        Antarctica,
        AustraliaNewZealand,
        Melanesia,
        Micronesia,
        Polynesia
    }

    public Region(ERegion value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public new static string TypeName => "region-ov";
}