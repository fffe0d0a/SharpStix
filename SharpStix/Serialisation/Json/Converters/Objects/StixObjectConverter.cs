using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixObjects;
using SharpStix.StixObjects.CyberObservable;
using SharpStix.StixObjects.Meta;

namespace SharpStix.Serialisation.Json.Converters;

public class StixObjectConverter : JsonConverter<StixObject>
{
    private class ExtensionPackage
    {
        public readonly Dictionary<string, ExtensionDefinition> DefinitionReferences = new Dictionary<string, ExtensionDefinition>();
        public readonly Dictionary<string, JsonNode> Extensions = new Dictionary<string, JsonNode>();
        public readonly Dictionary<Type, object> PredefinedExtensions = new Dictionary<Type, object>();

        public bool IsEmpty() => DefinitionReferences.Count == 0 && Extensions.Count == 0 && PredefinedExtensions.Count == 0;
    }

    private static Type? GetTypeFromJsonObject(in JsonObject jsonObject)
    {
        string? typeName = jsonObject["type"]?.ToString();

        if (string.IsNullOrWhiteSpace(typeName)) //typeName is string.Empty when type property does not exist
            throw new Exception("missing type discriminator");

        return StixTypeDiscriminationService.GetTypeFromDiscriminator(typeName); //may return null when the discriminator is unrecognised
    }

    private static ExtensionPackage? ExtractExtensions(ref JsonObject rootObject, JsonSerializerOptions options)
    {
        if (!rootObject.Remove("extensions", out JsonNode? extensionsNode))
            return null;

        ExtensionPackage package = new ExtensionPackage();

        foreach (KeyValuePair<string, JsonNode?> element in extensionsNode.AsObject())
        {
            if (element.Value == null)
                continue;
            Type? type = StixTypeDiscriminationService.GetTypeFromDiscriminator(element.Key);
            if (type == null) //is unknown type
            {
                package.Extensions.Add(element.Key, element.Value);
            }
            else if (type == typeof(ExtensionDefinition)) //is an extension definition
            {
                ExtensionDefinition? instance = element.Value.Deserialize<ExtensionDefinition>();
                if (instance == null)
                {
                    Debug.WriteLine($"bad extension definition. {element.Key}");
                    continue;
                }
                package.DefinitionReferences.Add(element.Key, instance);
            }
            else if (type.IsAssignableTo(typeof(IPredefinedExtension))) //is a predefined extension
            {
                object? instance = element.Value.Deserialize(type, options);
                if (instance == null)
                {
                    Debug.WriteLine($"bad {type.Name}. {element.Key}");
                    continue;
                }
                package.PredefinedExtensions.Add(type, instance);
            }
        }

        return package.IsEmpty()
            ? null 
            : package;
    }

    private static void ApplyExtensions(ref StixObject stixObject, in ExtensionPackage package)
    {
        if (stixObject.GetType().IsAssignableTo(typeof(IHasExtensions)))
        {

        }
    }

    public override StixObject? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        JsonObject rootObject = JsonNode.Parse(ref reader) as JsonObject ?? throw new InvalidOperationException("Input json was malformed.");

        Type? type = GetTypeFromJsonObject(rootObject);

        if (type is null)
        {
            Debug.WriteLine($"json object resolved to null value. {rootObject.ToJsonString(options)}");
            return null;
        }

        ExtensionPackage? extensionPackage = ExtractExtensions(ref rootObject, options);
        StixObject? stixObject = (StixObject?)rootObject.Deserialize(type, options);
        if (extensionPackage is null || stixObject is null)
            return stixObject;

        ApplyExtensions(ref stixObject, extensionPackage);
        return stixObject;
    }

    public override void Write(Utf8JsonWriter writer, StixObject value, JsonSerializerOptions options)
    {
        using JsonDocument
            document = JsonSerializer.SerializeToDocument(value, value.GetType(), options); //get the child type

        document.WriteTo(writer);
    }
}