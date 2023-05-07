using SharpStix.Common;
using SharpStix.StixObjects;

namespace SharpStix.StixTypes;

[Obsolete("Deprecated as of STIX 2.1.")]
public class StixObservableContainer : Dictionary<CoreObject, CoreObject>, IStixDataType //warn likely not implemented properly
{
    public static string TypeName => "observable-container";
}