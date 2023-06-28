using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(EnumerationConverterFactory))]
public sealed record OpinionEnum : Enumeration<OpinionEnum>, IStixEnum
{
    private const string TYPE = "opinion-enum";

    /// <summary>
    ///     The creator strongly disagrees with the information and believes it is inaccurate or incorrect.
    /// </summary>
    public static readonly OpinionEnum StronglyDisagree = new OpinionEnum(1, "strongly-disagree");

    /// <summary>
    ///     The creator disagrees with the information and believes it is inaccurate or incorrect.
    /// </summary>
    public static readonly OpinionEnum Disagree = new OpinionEnum(2, "disagree");

    /// <summary>
    ///     The creator is neutral about the accuracy or correctness of the information.
    /// </summary>
    public static readonly OpinionEnum Neutral = new OpinionEnum(3, "neutral");

    /// <summary>
    ///     The creator agrees with the information and believes that it is accurate and correct.
    /// </summary>
    public static readonly OpinionEnum Agree = new OpinionEnum(4, "agree");

    /// <summary>
    ///     The creator strongly agrees with the information and believes that it is accurate and correct.
    /// </summary>
    public static readonly OpinionEnum StronglyAgree = new OpinionEnum(5, "strongly-agree");

    private OpinionEnum(int value, string displayName) : base(value, displayName)
    {
    }

    public string Type => TYPE;

    public override string ToString() => base.ToString();


    /// <summary>
    ///     Returns an <see cref="OpinionEnum" /> from the equivalent numeric representation, from 1
    ///     (<see cref="StronglyDisagree" />) to 5 (<see cref="StronglyAgree" />).
    /// </summary>
    /// <param name="value">The numeric representation of the opinion.</param>
    /// <returns>An <see cref="OpinionEnum" /> of equivalent value.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     <param name="value"></param>
    ///     was outside the bounds of 1-5 (inclusive).
    /// </exception>
    public static OpinionEnum FromInt(int value)
    {
        return value switch
        {
            1 => StronglyDisagree,
            2 => Disagree,
            3 => Neutral,
            4 => Agree,
            5 => StronglyAgree,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Opinion scale is 1-5 (inclusive).")
        };
    }
}