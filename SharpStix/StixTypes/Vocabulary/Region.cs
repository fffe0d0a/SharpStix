using System.Text.Json.Serialization;
using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<Region>))]
[StixTypeDiscriminator(TYPE)]
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

    private const string TYPE = "region-ov";

    public Region(ERegion value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public override string Type => TYPE;
}