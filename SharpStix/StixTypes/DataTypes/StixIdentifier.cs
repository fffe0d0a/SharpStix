using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters.DataTypes;
using SharpStix.Services;
using SharpStix.StixObjects;

namespace SharpStix.StixTypes;

//todo the Stix documentation recommends that CyberObservableObjects have a UUID5.
//todo I think this can be a struct, it's also very important, and should faciliate object lookup where this exists in more than 1 object
// should this be generic? Identifiers have a T for use by created_by_ref and object_markings_refs
// i.e. Identifier<AttackPattern> created_by_ref;
// i.e. List<Identifier<MarkingDefinition>> ObjectMarkingRefs
// every stix object and bundle has an ID

/// <summary>
///     A UUID4 for STIX object types.
/// </summary>
[JsonConverter(typeof(StixIdentifierConverter))]
public record StixIdentifier : IStixDataType
{
    private const string TYPE = "identifier";

    internal StixIdentifier(string value)
    {
        string[] split = value.Split("--");
        TypeHalf = split[0];
        UuidHalf = split[1];
    }

    internal StixIdentifier(string typeHalf, string uuidHalf)
    {
        TypeHalf = typeHalf;
        UuidHalf = uuidHalf;
    }


    [JsonIgnore] public string TypeHalf { get; }

    [JsonIgnore] public string UuidHalf { get; }

    [JsonIgnore] public string Value => $"{TypeHalf}--{UuidHalf}";


    public static StixIdentifier CreateNew<T>() where T : IHasTypeName
    {
        return new StixIdentifier(StixTypeDiscriminationService.GetDiscriminatorFromType<T>()!,
            Guid.NewGuid().ToString());
    }


    public override string ToString()
    {
        return Value;
    }
}

//public static class StixIdentifierExtensions
//{
//    public static StixIdentifier<T>? WithReference<T>(this StixIdentifier identifier) where T : IStixType
//    {
//        throw new NotImplementedException();
//    }
//}

//[GenericTypeNameHelper("identifier'1")] //bad
//public record StixIdentifier<T> : StixIdentifier where T : IStixType
//{
//    public StixIdentifier(T stixObject) : base(T.TypeName, Guid.NewGuid().ToString())
//    {
//        Reference = stixObject;
//    }

//    [JsonIgnore]
//    public T Reference { get; }
//}