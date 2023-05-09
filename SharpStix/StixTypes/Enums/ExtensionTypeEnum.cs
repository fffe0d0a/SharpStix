using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record ExtensionTypeEnum : Enumeration<ExtensionTypeEnum>, IStixEnum
{
    private const string TYPE = "extension-type-enum";

    public readonly static ExtensionTypeEnum NewStixDomainObject = new ExtensionTypeEnum(EExtensionType.NewSdo);

    public readonly static ExtensionTypeEnum
        NewStixCyberObservableObject = new ExtensionTypeEnum(EExtensionType.NewSco);

    public readonly static ExtensionTypeEnum NewStixRelationshipObject = new ExtensionTypeEnum(EExtensionType.NewSro);

    public readonly static ExtensionTypeEnum
        PropertyExtension = new ExtensionTypeEnum(EExtensionType.PropertyExtension);

    public readonly static ExtensionTypeEnum ToplevelPropertyExtension =
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