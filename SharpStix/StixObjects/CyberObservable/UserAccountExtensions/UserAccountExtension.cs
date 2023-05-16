namespace SharpStix.StixObjects.CyberObservable;

public abstract record UserAccountExtension : IHasTypeName
{
    public abstract string Type { get; }
}