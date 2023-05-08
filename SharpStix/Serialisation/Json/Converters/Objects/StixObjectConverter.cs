﻿using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixObjects;

namespace SharpStix.Serialisation.Json.Converters;

public class StixObjectConverter : JsonConverter<StixObject>
{
    private static Type? GetTypeFromJsonDocument(in JsonDocument document)
    {
        string typeName = document.RootElement
            .EnumerateObject()
            .FirstOrDefault(x => x.Name == "type").Value
            .ToString();

        if (string.IsNullOrWhiteSpace(typeName)) //typeName is string.Empty when type property does not exist
            throw new Exception("missing type discriminator");

        return StixTypeDiscriminationService.GetTypeFromDiscriminator(typeName); //may return null
    }

    public override StixObject? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using JsonDocument document = JsonDocument.ParseValue(ref reader);

        Type? type = GetTypeFromJsonDocument(document);
        return type is not null
            ? (StixObject?)document.Deserialize(type, options)
            : null;
    }

    public override void Write(Utf8JsonWriter writer, StixObject value, JsonSerializerOptions options)
    {
        using JsonDocument document = JsonSerializer.SerializeToDocument(value, value.GetType(), options); //get the child type

        document.WriteTo(writer);
    }
}