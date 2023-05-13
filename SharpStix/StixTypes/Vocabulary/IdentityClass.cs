using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<IdentityClass>))]
[StixTypeDiscriminator(TYPE)]
public sealed record IdentityClass(string Value) : StixOpenVocab(Value)
{
    public static readonly IdentityClass Individual = new IdentityClass("individual");

    public static readonly IdentityClass Group = new IdentityClass("group");

    public static readonly IdentityClass System = new IdentityClass("system");

    public static readonly IdentityClass Organisational = new IdentityClass("organizational");

    public static readonly IdentityClass @Class = new IdentityClass("class");

    public static readonly IdentityClass Unknown = new IdentityClass("unknown");

    private const string TYPE = "identity-class-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}