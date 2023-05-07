using SharpStix.Common;

namespace SharpStix.StixTypes.Enums;

public sealed record ExtensionTypeEnum : Enumeration<ExtensionTypeEnum>, IStixEnum
{
    public static readonly ExtensionTypeEnum NewStixDomainObject = new ExtensionTypeEnum(EExtensionType.NewSdo);
    public static readonly ExtensionTypeEnum NewStixCyberObservableObject = new ExtensionTypeEnum(EExtensionType.NewSco);
    public static readonly ExtensionTypeEnum NewStixRelationshipObject = new ExtensionTypeEnum(EExtensionType.NewSro);
    public static readonly ExtensionTypeEnum PropertyExtension = new ExtensionTypeEnum(EExtensionType.PropertyExtension);
    public static readonly ExtensionTypeEnum ToplevelPropertyExtension = new ExtensionTypeEnum(EExtensionType.ToplevelPropertyExtension);

    private enum EExtensionType
    {
        NewSdo,
        NewSco,
        NewSro,
        PropertyExtension,
        ToplevelPropertyExtension
    }

    private ExtensionTypeEnum(EExtensionType value) : base(value)
    {
    }

    public static string TypeName => "extension-type-enum";
}