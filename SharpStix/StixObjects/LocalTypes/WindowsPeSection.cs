﻿using SharpStix.Services;
using SharpStix.StixObjects.CyberObservable;
using SharpStix.StixTypes;
using System.ComponentModel.DataAnnotations;

namespace SharpStix.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsPeSection : CyberObservableObject
{
    private const string TYPE = "windows-pe-section-type";

    public required string Name { get; init; }
    public StixInteger? Size { get; init; }

    [Range(0, 8)] public StixFloat? Entropy { get; init; } //todo validate in this obj

    public StixHashes? Hashes { get; init; }

    public override string Type => TYPE;
}