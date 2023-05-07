using System.Xml;
using SharpStix.Common;

namespace SharpStix.StixTypes;

public readonly record struct StixTimestamp(DateTime Value) : IStixDataType
{
    public StixTimestamp(string value) : this(XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.Utc))
    {
    }

    public static string TypeName => "timestamp";

    public override string ToString() => XmlConvert.ToString(Value, XmlDateTimeSerializationMode.Utc);
}