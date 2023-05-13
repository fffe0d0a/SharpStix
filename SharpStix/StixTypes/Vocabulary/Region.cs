using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<Region>))]
[StixTypeDiscriminator(TYPE)]
public sealed record Region(string Value) : StixOpenVocab(Value)
{
    public static readonly Region Africa = new Region("africa");

    public static readonly Region EasternAfrica = new Region("eastern-africa");

    public static readonly Region MiddleAfrica = new Region("middle-africa");

    public static readonly Region NorthernAfrica = new Region("northern-africa");

    public static readonly Region SouthernAfrica = new Region("southern-africa");

    public static readonly Region WesternAfrica = new Region("western-africa");

    public static readonly Region Americas = new Region("americas");

    public static readonly Region Caribbean = new Region("caribbean");

    public static readonly Region CentralAmerica = new Region("central-america");

    public static readonly Region LatinAmericaCaribbean = new Region("latin-america-caribbean");

    public static readonly Region NorthernAmerica = new Region("northern-america");

    public static readonly Region SouthAmerica = new Region("south-america");

    public static readonly Region Asia = new Region("asia");

    public static readonly Region CentralAsia = new Region("central-asia");

    public static readonly Region EasternAsia = new Region("eastern-asia");

    public static readonly Region SouthernAsia = new Region("southern-asia");

    public static readonly Region SouthEasternAsia = new Region("south-eastern-asia");

    public static readonly Region WesternAsia = new Region("western-asia");

    public static readonly Region Europe = new Region("europe");

    public static readonly Region EasternEurope = new Region("eastern-europe");

    public static readonly Region NorthernEurope = new Region("northern-europe");

    public static readonly Region SouthernEurope = new Region("southern-europe");

    public static readonly Region WesternEurope = new Region("western-europe");

    public static readonly Region Oceania = new Region("oceania");

    public static readonly Region Antarctica = new Region("antarctica");

    public static readonly Region AustraliaNewZealand = new Region("australia-new-zealand");

    public static readonly Region Melanesia = new Region("melanesia");

    public static readonly Region Micronesia = new Region("micronesia");

    public static readonly Region Polynesia = new Region("polynesia");

    private const string TYPE = "region-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}