using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using SharpStix.Serialisation;
using SharpStix.Services;
using SharpStix.StixTypes;

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

    public static bool TryForceResolve(this JsonElement element, [NotNullWhen(true)] out object? instance)
    {
        bool ParseString([NotNullWhen(true)] out object? instance)
        {
            instance = element.GetString();
            return instance is not null;
        }

        bool ParseNumber([NotNullWhen(true)] out object? instance)
        {
            instance = null;
            string numericString = element.ToString();

            if (string.IsNullOrWhiteSpace(numericString))
                return false;

            if (long.TryParse(numericString, out long longNumber))
            {
                instance = new Int54(longNumber);
                return true;
            }

            if (double.TryParse(numericString, out double doubleNumber))
            {
                instance = new StixFloat(doubleNumber);
                return true;
            }

            return false;
        }

        switch (element.ValueKind)
        {
            case JsonValueKind.Undefined:
            case JsonValueKind.Object:
            case JsonValueKind.Array:
                instance = null;
                return false;
            case JsonValueKind.String:
                return ParseString(out instance);
            case JsonValueKind.Number:
                return ParseNumber(out instance);
            case JsonValueKind.True:
                instance = true;
                return true;
            case JsonValueKind.False:
                instance = false;
                return true;
            case JsonValueKind.Null:
                instance = null;
                return false; //warn
            default:
                throw new ArgumentOutOfRangeException(nameof(element), "Element ValueKind is of unhandled type.");
        }

       
    }
}