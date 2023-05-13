using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(EnumerationConverterFactory))]
public sealed record WindowsIntegrityLevelEnum : Enumeration<WindowsIntegrityLevelEnum>, IStixEnum
{
    private const string TYPE = "windows-integrity-level-enum";

    public static readonly WindowsIntegrityLevelEnum Low = new WindowsIntegrityLevelEnum(0, "low");

    public static readonly WindowsIntegrityLevelEnum Medium = new WindowsIntegrityLevelEnum(1, "medium");

    public static readonly WindowsIntegrityLevelEnum High = new WindowsIntegrityLevelEnum(2, "high");

    public static readonly WindowsIntegrityLevelEnum System = new WindowsIntegrityLevelEnum(3, "system");

    private WindowsIntegrityLevelEnum(int value, string displayName) : base(value, displayName)
    {
    }

    public string Type => TYPE;
}