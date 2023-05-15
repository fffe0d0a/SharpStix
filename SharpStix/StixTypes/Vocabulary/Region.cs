using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<Region>))]
[StixTypeDiscriminator(TYPE)]
public sealed record Region : StixOpenVocab, IFromString<Region>
{
    private const string TYPE = "region-ov";
    public static readonly Region Africa = FromString("africa");

    public static readonly Region EasternAfrica = FromString("eastern-africa");

    public static readonly Region MiddleAfrica = FromString("middle-africa");

    public static readonly Region NorthernAfrica = FromString("northern-africa");

    public static readonly Region SouthernAfrica = FromString("southern-africa");

    public static readonly Region WesternAfrica = FromString("western-africa");

    public static readonly Region Americas = FromString("americas");

    public static readonly Region Caribbean = FromString("caribbean");

    public static readonly Region CentralAmerica = FromString("central-america");

    public static readonly Region LatinAmericaCaribbean = FromString("latin-america-caribbean");

    public static readonly Region NorthernAmerica = FromString("northern-america");

    public static readonly Region SouthAmerica = FromString("south-america");

    public static readonly Region Asia = FromString("asia");

    public static readonly Region CentralAsia = FromString("central-asia");

    public static readonly Region EasternAsia = FromString("eastern-asia");

    public static readonly Region SouthernAsia = FromString("southern-asia");

    public static readonly Region SouthEasternAsia = FromString("south-eastern-asia");

    public static readonly Region WesternAsia = FromString("western-asia");

    public static readonly Region Europe = FromString("europe");

    public static readonly Region EasternEurope = FromString("eastern-europe");

    public static readonly Region NorthernEurope = FromString("northern-europe");

    public static readonly Region SouthernEurope = FromString("southern-europe");

    public static readonly Region WesternEurope = FromString("western-europe");

    public static readonly Region Oceania = FromString("oceania");

    public static readonly Region Antarctica = FromString("antarctica");

    public static readonly Region AustraliaNewZealand = FromString("australia-new-zealand");

    public static readonly Region Melanesia = FromString("melanesia");

    public static readonly Region Micronesia = FromString("micronesia");

    public static readonly Region Polynesia = FromString("polynesia");

    private Region(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static Region FromString(string value)
    {
        if (OpenVocabManager<Region>.TryGetValue(value, out Region? vocab))
            return vocab!;

        vocab = new Region(value);
        OpenVocabManager<Region>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}