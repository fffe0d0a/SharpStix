﻿using SharpStix.Extensions;

namespace SharpStix.StixTypes.Vocabulary;

public sealed record IndustrySector(string Value) : StixOpenVocab(Value)
{
    public enum EIndustrySector
    {
        Agriculture,
        Aerospace,
        Automotive,
        Chemical,
        Commercial,
        Communications,
        Construction,
        Defense,
        Education,
        Energy,
        Entertainment,
        FinancialServices,
        Government,
        EmergencyServices,
        GovernmentLocal,
        GovernmentNational,
        GovernmentPublicServices,
        GovernmentRegional,
        Healthcare,
        HospitalityLeisure,
        Infrastructure,
        Dams,
        Nuclear,
        Water,
        Insurance,
        Manufacturing,
        Mining,
        NonProfit,
        Pharmaceuticals,
        Retail,
        Technology,
        Telecommunications,
        Transportation,
        Utilities
    }

    public IndustrySector(EIndustrySector value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public new static string TypeName => "industry-sector-ov";
}