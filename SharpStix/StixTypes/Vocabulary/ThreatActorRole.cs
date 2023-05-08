﻿using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using System.Text.Json.Serialization;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ThreatActorRole>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ThreatActorRole(string Value) : StixOpenVocab(Value)
{
    private const string TYPE = "threat-actor-role-ov";

    public enum EThreatActorRole
    {
        /// <summary>
        ///     Threat actor executes attacks either on behalf of themselves or at the direction of someone else.
        /// </summary>
        Agent,

        /// <summary>
        ///     The threat actor who directs the activities, goals, and objectives of the malicious activities.
        /// </summary>
        Director,

        /// <summary>
        ///     A threat actor acting by themselves.
        /// </summary>
        Independent,

        /// <summary>
        ///     Someone who designs the battle space.
        /// </summary>
        InfrastructureArchitect,

        /// <summary>
        ///     The threat actor who provides and supports the attack infrastructure that is used to deliver the attack (botnet
        ///     providers, cloud services, etc.).
        /// </summary>
        InfrastructureOperator,

        /// <summary>
        ///     The threat actor who authors malware or other malicious tools.
        /// </summary>
        MalwareAuthor,

        /// <summary>
        ///     The threat actor who funds the malicious activities.
        /// </summary>
        Sponsor
    }

    public ThreatActorRole(EThreatActorRole value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public override string Type => TYPE;
}