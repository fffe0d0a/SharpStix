using System.Text.Json.Serialization;
using System.Xml;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes;

[JsonConverter(typeof(StixTimestampConverter))]
[StixTypeDiscriminator(TYPE)]
public readonly record struct StixTimestamp(DateTime Value) : IStixDataType
{
    private const string TYPE = "timestamp";

    public StixTimestamp(string value) : this(XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.Utc))
    {
    }


    public override string ToString() => XmlConvert.ToString(Value, XmlDateTimeSerializationMode.Utc);
    public string Type => TYPE;
}