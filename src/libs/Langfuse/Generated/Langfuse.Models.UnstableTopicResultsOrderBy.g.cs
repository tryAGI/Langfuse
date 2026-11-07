
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableTopicResultsOrderBy
    {
        /// <summary>
        ///
        /// </summary>
        TimestampAsc,
        /// <summary>
        ///
        /// </summary>
        TimestampDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableTopicResultsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableTopicResultsOrderBy value)
        {
            return value switch
            {
                UnstableTopicResultsOrderBy.TimestampAsc => "timestamp.asc",
                UnstableTopicResultsOrderBy.TimestampDesc => "timestamp.desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableTopicResultsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "timestamp.asc" => UnstableTopicResultsOrderBy.TimestampAsc,
                "timestamp.desc" => UnstableTopicResultsOrderBy.TimestampDesc,
                _ => null,
            };
        }
    }
}