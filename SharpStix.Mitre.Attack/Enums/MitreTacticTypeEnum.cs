using SharpStix.Common;

namespace SharpStix.Mitre.Attack.Enums;

public sealed record MitreTacticTypeEnum : Enumeration<MitreTacticTypeEnum>
{
    public static readonly MitreTacticTypeEnum PostAdversaryDeviceAccess =
        new MitreTacticTypeEnum(0, "Post-Adversary Device Access");

    public static readonly MitreTacticTypeEnum PreAdversaryDeviceAccess =
        new MitreTacticTypeEnum(1, "Pre-Adversary Device Access");

    public static readonly MitreTacticTypeEnum WithoutAdversaryDeviceAccess =
        new MitreTacticTypeEnum(2, "Without Adversary Device Access");

    private MitreTacticTypeEnum(int value, string displayName) : base(value, displayName)
    {
    }
}