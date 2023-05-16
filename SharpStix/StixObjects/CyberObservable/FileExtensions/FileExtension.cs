namespace SharpStix.StixObjects.CyberObservable;

public abstract record FileExtension: IHasTypeName //note that this is not to use the existing extension facility
{
    public abstract string Type { get; }
}