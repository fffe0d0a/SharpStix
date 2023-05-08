using System.Text.Json.Serialization;

namespace SharpStix.StixObjects;

public interface IHasTypeName
{
    public static abstract string TypeName { get; }
}