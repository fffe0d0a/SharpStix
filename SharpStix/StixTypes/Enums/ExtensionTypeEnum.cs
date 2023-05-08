using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record ExtensionTypeEnum : Enumeration<ExtensionTypeEnum>, IStixEnum
{
    private const string TYPE = "extension-type-enum";

    public static readonly ExtensionTypeEnum NewStixDomainObject = new ExtensionTypeEnum(EExtensionType.NewSdo);

    public static readonly ExtensionTypeEnum
        NewStixCyberObservableObject = new ExtensionTypeEnum(EExtensionType.NewSco);

    public static readonly ExtensionTypeEnum NewStixRelationshipObject = new ExtensionTypeEnum(EExtensionType.NewSro);

    public static readonly ExtensionTypeEnum
        PropertyExtension = new ExtensionTypeEnum(EExtensionType.PropertyExtension);

    public static readonly ExtensionTypeEnum ToplevelPropertyExtension =
        new ExtensionTypeEnum(EExtensionType.ToplevelPropertyExtension);

    private ExtensionTypeEnum(EExtensionType value) : base(value)
    {
    }

    public string Type => TYPE;

    private enum EExtensionType
    {
        NewSdo,
        NewSco,
        NewSro,
        PropertyExtension,
        ToplevelPropertyExtension
    }
}