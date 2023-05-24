using System.Text.Json;
using SharpStix.Services;

namespace SharpStix.Common.Extensions;

public static class JsonElementExtensions
{
    public static Type? ResolveTypeFromDiscriminator(this JsonElement element)
    {
        if (element.ValueKind != JsonValueKind.Object)
            return null;

        string typeName = element
            .EnumerateObject() //can throw if element is array
            .FirstOrDefault(x => x.Name == "type").Value
            .ToString();

        if (string.IsNullOrWhiteSpace(typeName)) //typeName is string.Empty when type property does not exist
            throw new Exception("missing type discriminator");

        return StixTypeDiscriminationService.GetTypeFromDiscriminator(typeName); //may return null
    }
}