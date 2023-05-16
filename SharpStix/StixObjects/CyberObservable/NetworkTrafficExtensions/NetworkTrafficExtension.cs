using System.Text.Json.Serialization;

namespace SharpStix.StixObjects.CyberObservable;

public abstract record NetworkTrafficExtension : IHasTypeName
{
    public abstract string Type { get; }
    [JsonIgnore] public abstract string Protocol { get; }
}