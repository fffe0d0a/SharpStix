﻿namespace SharpStix.StixTypes;

public readonly record struct SpecVersion
{
    public static readonly SpecVersion CurrentVersion = new SpecVersion(CURRENT_VERSION_NUMBER);

    private const string CURRENT_VERSION_NUMBER = "2.1";

    public SpecVersion(string version)
    {
        Version = version;
    }

    public string Version { get; }

    public override string ToString() => Version;
}