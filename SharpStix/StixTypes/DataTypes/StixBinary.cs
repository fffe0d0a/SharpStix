﻿using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes;

[JsonConverter(typeof(StixBinaryConverter))]
[StixTypeDiscriminator(TYPE)]
public readonly record struct StixBinary(byte[] Value) : IStixDataType
{
    private const string TYPE = "binary";
    public string Type => TYPE;

    public override string ToString()
    {
        return Convert.ToBase64String(Value);
    }
}