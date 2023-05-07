using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixTypes;

public record MitreObjectVersionReference : IStixDataType
{
    public required StixIdentifier ObjectRef { get; init; }
    public required StixTimestamp ObjectModified { get; init; }

    public static string TypeName => "object-version-ref";
}

//public class MitreObjectVersionReferenceConverter : JsonConverter<MitreObjectVersionReference>
//{
//    public override MitreObjectVersionReference? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
//    {
//        return new MitreObjectVersionReference()
//    }

//    public override void Write(Utf8JsonWriter writer, MitreObjectVersionReference value, JsonSerializerOptions options)
//    {
//        throw new NotImplementedException();
//    }
//}