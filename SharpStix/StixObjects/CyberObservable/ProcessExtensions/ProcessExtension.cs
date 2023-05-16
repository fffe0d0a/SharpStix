namespace SharpStix.StixObjects.CyberObservable;

public abstract record ProcessExtension : IHasTypeName
{
    public abstract string Type { get; }
}