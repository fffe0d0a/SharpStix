using SharpStix.Common;
using SharpStix.Services;
using SharpStix.StixObjects;

namespace SharpStix.StixTypes;

[Obsolete("Deprecated as of STIX 2.1.")]
[StixTypeDiscriminator(TYPE)]
public class StixObservableContainer : Dictionary<CoreObject, CoreObject>, IStixDataType //warn likely not implemented properly
{
    private const string TYPE = "observable-container";

    public static string TypeName => "observable-container";
    public string Type => TYPE;
}