namespace SharpStix.StixTypes.Vocabulary;

public sealed record HashingAlgorithm(string Value) : StixOpenVocab(Value)
{
    public enum EHashingAlgorithm
    {
        // ReSharper disable InconsistentNaming
        /// <summary>
        ///     Specifies the MD5 message digest algorithm.
        /// </summary>
        MD5,

        /// <summary>
        ///     Specifies the SHA­-1 (secure-­hash algorithm 1) cryptographic hash function.
        /// </summary>
        SHA_1,

        /// <summary>
        ///     Specifies the SHA-­256 cryptographic hash function (part of the SHA­2 family).
        /// </summary>
        SHA_256,

        /// <summary>
        ///     Specifies the SHA-­512 cryptographic hash function (part of the SHA­2 family).
        /// </summary>
        SHA_512,

        /// <summary>
        ///     Specifies the SHA3-256 cryptographic hash function.
        /// </summary>
        SHA3_256,

        /// <summary>
        ///     Specifies the SHA3-512 cryptographic hash function.
        /// </summary>
        SHA3_512,

        /// <summary>
        ///     Specifies the ssdeep fuzzy hashing algorithm.
        /// </summary>
        SSDEEP,

        /// <summary>
        ///     Specifies the TLSH fuzzy hashing algorithm.
        /// </summary>
        TLSH
        // ReSharper restore InconsistentNaming
    }

    public HashingAlgorithm(EHashingAlgorithm value) : this(value.ToString().Replace('_', '-'))
    {
    }

    public new static string TypeName => "hashing-algorithm-ov";
}