using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(EnumerationConverterFactory))]
public sealed record ExtensionTypeEnum : Enumeration<ExtensionTypeEnum>, IStixEnum
{
    private const string TYPE = "extension-type-enum";

    public static readonly ExtensionTypeEnum NewStixDomainObject = new ExtensionTypeEnum(0, "new-sdo");

    public static readonly ExtensionTypeEnum
        NewStixCyberObservableObject = new ExtensionTypeEnum(1, "new-sco");

    public static readonly ExtensionTypeEnum NewStixRelationshipObject = new ExtensionTypeEnum(2, "new-sro");

    public static readonly ExtensionTypeEnum
        PropertyExtension = new ExtensionTypeEnum(3, "property-extension");

    public static readonly ExtensionTypeEnum ToplevelPropertyExtension =
        new ExtensionTypeEnum(4, "toplevel-property-extension");

    private ExtensionTypeEnum(int value, string displayName) : base(value, displayName)
    {
    }

    public string Type => TYPE;
}