using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<IndustrySector>))]
[StixTypeDiscriminator(TYPE)]
public sealed record IndustrySector(string Value) : StixOpenVocab(Value)
{
    public static readonly IndustrySector Agriculture = new IndustrySector("agriculture");

    public static readonly IndustrySector Aerospace = new IndustrySector("aerospace");

    public static readonly IndustrySector Automotive = new IndustrySector("automotive");

    public static readonly IndustrySector Chemical = new IndustrySector("chemical");

    public static readonly IndustrySector Commercial = new IndustrySector("commercial");

    public static readonly IndustrySector Communications = new IndustrySector("communications");

    public static readonly IndustrySector Construction = new IndustrySector("construction");

    public static readonly IndustrySector Defence = new IndustrySector("defense");

    public static readonly IndustrySector Education = new IndustrySector("education");

    public static readonly IndustrySector Energy = new IndustrySector("energy");

    public static readonly IndustrySector Entertainment = new IndustrySector("entertainment");

    public static readonly IndustrySector FinancialServices = new IndustrySector("financial-services");

    public static readonly IndustrySector Government = new IndustrySector("government");

    public static readonly IndustrySector EmergenceServices = new IndustrySector("emergency-services");

    public static readonly IndustrySector GovernmentLocal = new IndustrySector("government-local");

    public static readonly IndustrySector GovernmentNational = new IndustrySector("government-national");

    public static readonly IndustrySector GovernmentPublicServices = new IndustrySector("government-public-services");

    public static readonly IndustrySector GovernmentRegional = new IndustrySector("government-regional");

    public static readonly IndustrySector Healthcare = new IndustrySector("healthcare");

    public static readonly IndustrySector HospitalityLeisure = new IndustrySector("hospitality-leisure");

    public static readonly IndustrySector Infrastructure = new IndustrySector("infrastructure");

    public static readonly IndustrySector Dams = new IndustrySector("dams");

    public static readonly IndustrySector Nuclear = new IndustrySector("nuclear");

    public static readonly IndustrySector Water = new IndustrySector("water");

    public static readonly IndustrySector Insurance = new IndustrySector("insurance");

    public static readonly IndustrySector Manufacturing = new IndustrySector("manufacturing");

    public static readonly IndustrySector Mining = new IndustrySector("mining");

    public static readonly IndustrySector NonProfit = new IndustrySector("non-profit");

    public static readonly IndustrySector Pharmaceuticals = new IndustrySector("pharmaceuticals");

    public static readonly IndustrySector Retail = new IndustrySector("retail");

    public static readonly IndustrySector Technology = new IndustrySector("technology");

    public static readonly IndustrySector Telecommunications = new IndustrySector("telecommunications");

    public static readonly IndustrySector Transportation = new IndustrySector("transportation");

    public static readonly IndustrySector Utilities = new IndustrySector("utilities");

    private const string TYPE = "industry-sector-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}