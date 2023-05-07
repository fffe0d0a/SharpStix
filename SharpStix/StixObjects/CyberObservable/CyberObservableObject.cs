using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public abstract record CyberObservableObject : CoreObject
{
    public SpecVersion? SpecVersion { get; init; }
    public bool? Defanged { get; init; }
    public new static string TypeName => "cyber-observable-object";
}