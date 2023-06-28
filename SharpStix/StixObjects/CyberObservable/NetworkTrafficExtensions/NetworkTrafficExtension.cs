using System.Text.Json.Serialization;

namespace SharpStix.StixObjects.CyberObservable;

public abstract record NetworkTrafficExtension : IPredefinedExtension
{
    [JsonIgnore] public abstract string Protocol { get; }
    public abstract string Type { get; }
}