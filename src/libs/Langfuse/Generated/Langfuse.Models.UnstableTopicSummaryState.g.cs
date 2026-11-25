
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableTopicSummaryState
    {
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        InsufficientInput,
        /// <summary>
        ///
        /// </summary>
        NotApplicable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableTopicSummaryStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableTopicSummaryState value)
        {
            return value switch
            {
                UnstableTopicSummaryState.Complete => "complete",
                UnstableTopicSummaryState.InsufficientInput => "insufficient_input",
                UnstableTopicSummaryState.NotApplicable => "not_applicable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableTopicSummaryState? ToEnum(string value)
        {
            return value switch
            {
                "complete" => UnstableTopicSummaryState.Complete,
                "insufficient_input" => UnstableTopicSummaryState.InsufficientInput,
                "not_applicable" => UnstableTopicSummaryState.NotApplicable,
                _ => null,
            };
        }
    }
}