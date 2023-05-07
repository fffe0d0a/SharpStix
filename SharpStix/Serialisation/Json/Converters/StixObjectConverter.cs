using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SharpStix.Services;
using SharpStix.StixObjects;

namespace SharpStix.Serialisation.Json.Converters
{
    public class StixObjectConverter : JsonConverter<StixObject>
    {
        private static Type GetTypeFromJsonDocument(in JsonDocument document)
        {
            string typeName = document.RootElement
                .EnumerateObject()
                .FirstOrDefault(x => x.Name == "type").Value
                .ToString();

            if (string.IsNullOrWhiteSpace(typeName)) //todo, untested no idea what default of JsonProperty.Value is
                throw new Exception("missing type discriminator");

            return StixTypeDiscriminationService.GetTypeFromString(typeName) ?? throw new Exception($"Unknown type {typeName}."); //todo this should be much more graceful
        }

        public override StixObject? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument document = JsonDocument.ParseValue(ref reader))
            {
                Type t = GetTypeFromJsonDocument(document);
                //get the typename property
                // get type from typename
                // ask the type's static serialiser to create this from the value
                // return it
            }
           

            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, StixObject value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
