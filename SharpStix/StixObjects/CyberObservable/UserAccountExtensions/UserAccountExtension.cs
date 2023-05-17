namespace SharpStix.StixObjects.CyberObservable;

public abstract record UserAccountExtension : IPredefinedExtension
{
    public abstract string Type { get; }
}