using SharpStix.Services;

namespace SharpStix.Common;

/// <summary>
///     Announces to the <see cref="StixTypeDiscriminationService"/> that this assembly contains new types inheriting from <see cref="IStixType"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly)]
public sealed class StixTypeProviderAttribute : Attribute
{
}