using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Common.Extensions;
using SharpStix.Services;
using SharpStix.StixObjects;

namespace SharpStix.Serialisation.Json.Converters;

/// <summary>
///     Used as the root converter for deserialising bundles
/// </summary>
public class StixObjectConverter : JsonConverter<StixObject>
{
    public override StixObject? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using JsonDocument document = JsonDocument.ParseValue(ref reader);

        Type? type = document.RootElement.ResolveTypeFromDiscriminator();
        if (type is null)
        {
            Debug.WriteLine($"json document resolved to null value. {document.RootElement.GetRawText()}");
            return null;
        }

        StixObject? instance = (StixObject?)document.Deserialize(type, options);
        if (instance is IHasExtensions extendableInstance)
            extendableInstance.Extensions?.FormatExtensions(); //post-serialisation formatting allows us to work with extension properties automatically collected by system.text.json

        if (instance is not null)
            ObjectLookupService.Register(instance); //register with lookup service

        return instance;
    }

    public override void Write(Utf8JsonWriter writer, StixObject value, JsonSerializerOptions options)
    {
        using JsonDocument
            document = JsonSerializer.SerializeToDocument(value, value.GetType(), options); //get the child type

        document.WriteTo(writer);
    }
}