using System.Diagnostics;

namespace SharpStix.StixTypes;

[DebuggerDisplay("{Value}")]
public record struct Confidence
{
    public Confidence(int value)
    {
        Value = value;

        if (value is < 0 or > 100)
            throw new ArgumentOutOfRangeException(nameof(value), value, "Confidence out of range [0-100].");
    }

    private int Value { get; }

    public static implicit operator Confidence(int value)
    {
        return new Confidence(value);
    }

    #region ConfidenceScales

    public string AsVerb()
    {
        return Value switch
        {
            0 => "None",
            > 0 and < 30 => "Low",
            >= 30 and < 70 => "Med",
            >= 70 and <= 100 => "High",
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public int AsScaleZeroTen()
    {
        return Value switch
        {
            >= 0 and < 5 => 0,
            >= 5 and < 15 => 1,
            >= 15 and < 25 => 2,
            >= 25 and < 35 => 3,
            >= 35 and < 45 => 4,
            >= 45 and < 55 => 5,
            >= 55 and < 65 => 6,
            >= 65 and < 75 => 7,
            >= 75 and < 85 => 8,
            >= 85 and < 95 => 9,
            >= 95 and <= 100 => 10,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    //todo implement additional none-nato scales

    public string AsAdmiraltyCredibility()
    {
        return Value switch
        {
            >= 0 and < 20 => "Improbable",
            >= 20 and < 40 => "Doubtful",
            >= 40 and < 60 => "Possibly True",
            >= 60 and < 80 => "Probably True",
            >= 80 and <= 100 => "Confirmed by other sources",
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public string AsWep()
    {
        return Value switch
        {
            0 => "Impossible",
            >= 10 and < 20 => "Highly Unlikely",
            >= 20 and < 40 => "Unlikely",
            >= 40 and < 60 => "Even Chance",
            >= 60 and < 80 => "Likely",
            >= 80 and < 99 => "Highly Likely",
            100 => "Certain",
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public string AsDniScale()
    {
        return Value switch
        {
            >= 0 and < 10 => "Almost No Chance",
            >= 10 and < 20 => "Very Unlikely",
            >= 20 and < 40 => "Unlikely",
            >= 40 and < 60 => "Roughly Even Chance",
            > 60 and < 80 => "Likely",
            > 80 and <= 100 => "Almost Certain",
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    #endregion
}

public static class ConfidenceExtensions
{
    public static string AsAdmiraltyCredibility(this Confidence? confidence)
    {
        return confidence == null
            ? "Truth cannot be judged"
            : confidence.AsAdmiraltyCredibility();
    }
}