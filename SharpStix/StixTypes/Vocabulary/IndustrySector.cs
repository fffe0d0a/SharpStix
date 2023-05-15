using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<IndustrySector>))]
[StixTypeDiscriminator(TYPE)]
public sealed record IndustrySector : StixOpenVocab, IFromString<IndustrySector>
{
    private const string TYPE = "industry-sector-ov";
    public static readonly IndustrySector Agriculture = FromString("agriculture");

    public static readonly IndustrySector Aerospace = FromString("aerospace");

    public static readonly IndustrySector Automotive = FromString("automotive");

    public static readonly IndustrySector Chemical = FromString("chemical");

    public static readonly IndustrySector Commercial = FromString("commercial");

    public static readonly IndustrySector Communications = FromString("communications");

    public static readonly IndustrySector Construction = FromString("construction");

    public static readonly IndustrySector Defence = FromString("defense");

    public static readonly IndustrySector Education = FromString("education");

    public static readonly IndustrySector Energy = FromString("energy");

    public static readonly IndustrySector Entertainment = FromString("entertainment");

    public static readonly IndustrySector FinancialServices = FromString("financial-services");

    public static readonly IndustrySector Government = FromString("government");

    public static readonly IndustrySector EmergenceServices = FromString("emergency-services");

    public static readonly IndustrySector GovernmentLocal = FromString("government-local");

    public static readonly IndustrySector GovernmentNational = FromString("government-national");

    public static readonly IndustrySector GovernmentPublicServices = FromString("government-public-services");

    public static readonly IndustrySector GovernmentRegional = FromString("government-regional");

    public static readonly IndustrySector Healthcare = FromString("healthcare");

    public static readonly IndustrySector HospitalityLeisure = FromString("hospitality-leisure");

    public static readonly IndustrySector Infrastructure = FromString("infrastructure");

    public static readonly IndustrySector Dams = FromString("dams");

    public static readonly IndustrySector Nuclear = FromString("nuclear");

    public static readonly IndustrySector Water = FromString("water");

    public static readonly IndustrySector Insurance = FromString("insurance");

    public static readonly IndustrySector Manufacturing = FromString("manufacturing");

    public static readonly IndustrySector Mining = FromString("mining");

    public static readonly IndustrySector NonProfit = FromString("non-profit");

    public static readonly IndustrySector Pharmaceuticals = FromString("pharmaceuticals");

    public static readonly IndustrySector Retail = FromString("retail");

    public static readonly IndustrySector Technology = FromString("technology");

    public static readonly IndustrySector Telecommunications = FromString("telecommunications");

    public static readonly IndustrySector Transportation = FromString("transportation");

    public static readonly IndustrySector Utilities = FromString("utilities");

    private IndustrySector(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static IndustrySector FromString(string value)
    {
        if (OpenVocabManager<IndustrySector>.TryGetValue(value, out IndustrySector? vocab))
            return vocab!;

        vocab = new IndustrySector(value);
        OpenVocabManager<IndustrySector>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}