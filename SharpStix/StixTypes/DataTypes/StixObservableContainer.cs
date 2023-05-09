using SharpStix.StixObjects;

namespace SharpStix.StixTypes;

[Obsolete("Deprecated as of STIX 2.1.")]
public class
    StixObservableContainer : Dictionary<CoreObject, CoreObject>, IStixDataType //warn likely not implemented properly
{
    private const string TYPE = "observable-container";
}