using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using SharpStix.StixObjects;

namespace SharpStix.Services;

/// <summary>
///     Helps determine the <see cref="IHasTypeName.TypeName"/> of a generic class that implements <see cref="IHasTypeName"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class GenericTypeNameHelperAttribute : Attribute
{
    public GenericTypeNameHelperAttribute(string typeName)
    {
        TypeName = typeName;
    }

    public string TypeName { get; }
}