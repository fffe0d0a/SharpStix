﻿using SharpStix.Services;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsProcessExtension : CyberObservableObject
{
    private const string TYPE = "windows-process-ext";

    public bool? AslrEnabled { get; init; }
    public bool? DepEnabled { get; init; }
    public string? Priority { get; init; }
    public string? OwnerSid { get; init; }
    public string? WindowTitle { get; init; }
    public Dictionary<string, string>? StartupInfo { get; init; }
    public WindowsIntegrityLevelEnum? IntegrityLevel { get; init; }

    public override string Type => TYPE;
}