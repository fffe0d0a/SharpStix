using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record OpinionEnum : Enumeration<OpinionEnum>, IStixEnum
{
    private const string TYPE = "opinion-enum";

    /// <summary>
    ///     The creator strongly disagrees with the information and believes it is inaccurate or incorrect.
    /// </summary>
    public static readonly OpinionEnum StronglyDisagree = new OpinionEnum(EOpinion.StronglyDisagree);

    /// <summary>
    ///     The creator disagrees with the information and believes it is inaccurate or incorrect.
    /// </summary>
    public static readonly OpinionEnum Disagree = new OpinionEnum(EOpinion.Disagree);

    /// <summary>
    ///     The creator is neutral about the accuracy or correctness of the information.
    /// </summary>
    public static readonly OpinionEnum Neutral = new OpinionEnum(EOpinion.Neutral);

    /// <summary>
    ///     The creator agrees with the information and believes that it is accurate and correct.
    /// </summary>
    public static readonly OpinionEnum Agree = new OpinionEnum(EOpinion.Agree);

    /// <summary>
    ///     The creator strongly agrees with the information and believes that it is accurate and correct.
    /// </summary>
    public static readonly OpinionEnum StronglyAgree = new OpinionEnum(EOpinion.StronglyAgree);

    private OpinionEnum(EOpinion value) : base(value)
    {
    }

    public string Type => TYPE;


    /// <summary>
    ///     Returns an <see cref="OpinionEnum" /> from the equivalent numeric representation, from 1 (
    ///     <see cref="StronglyDisagree" />) to 5 (<see cref="StronglyAgree" />).
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

    private enum EOpinion
    {
        StronglyDisagree = 1,
        Disagree = 2,
        Neutral = 3,
        Agree = 4,
        StronglyAgree = 5
    }
}