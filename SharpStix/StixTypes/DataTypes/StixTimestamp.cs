using System.Text.Json.Serialization;
using System.Xml;
using SharpStix.Serialisation.Json.Converters;

namespace SharpStix.StixTypes;

[JsonConverter(typeof(StixTimestampConverter))]
public readonly record struct StixTimestamp(DateTime Value) : IStixDataType
{
    public StixTimestamp(string value) : this(XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.Utc))
    {
    }

    public static string TypeName => "timestamp";

    public override string ToString() => XmlConvert.ToString(Value, XmlDateTimeSerializationMode.Utc);
}