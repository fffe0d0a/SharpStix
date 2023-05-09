using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Identity : DomainObject
{
    private const string TYPE = "identity";

    /// <summary>
    ///     The name of this Identity. When referring to a specific entity (e.g., an individual or organization), this property
    ///     SHOULD contain the canonical name of the specific entity.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    ///     A description that provides more details and context about the Identity, potentially including its purpose and its
    ///     key characteristics.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     The list of roles that this Identity performs (e.g., CEO, Domain Administrators, Doctors, Hospital, or Retailer).
    /// </summary>
    public StixList<string>? Roles { get; init; }

    /// <summary>
    ///     The type of entity that this Identity describes, e.g., an individual or organization.
    /// </summary>
    public IdentityClass? IdentityClass { get; init; }

    /// <summary>
    ///     The list of industry sectors that this Identity belongs to.
    /// </summary>
    public StixList<IndustrySector>? Sectors { get; init; }

    /// <summary>
    ///     The contact information (e-mail, phone number, etc.) for this Identity.
    /// </summary>
    public string? ContactInformation { get; init; }

    public override string Type => TYPE;
}