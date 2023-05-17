﻿using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

public abstract record CoreObject : StixObject
{
    public StixList<StixIdentifier>? ObjectMarkingRefs { get; init; }
    public StixList<GranularMarking>? GranularMarkings { get; init; }

    [JsonExtensionData] public StixExtensions? Extensions { get; init; }
}

 