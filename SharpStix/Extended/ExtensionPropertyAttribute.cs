namespace SharpStix.Extended;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
public class ExtensionPropertyAttribute : Attribute
{
    public ExtensionPropertyAttribute(string propertyName)
    {
        PropertyName = propertyName;
    }

    public string PropertyName { get; }
}