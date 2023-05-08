using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public abstract record CyberObservableObject : CoreObject
{
    private const string TYPE = "cyber-observable-object";

    public SpecVersion? SpecVersion { get; init; }
    public bool? Defanged { get; init; }
}