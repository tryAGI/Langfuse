
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableTopicsOrderBy
    {
        /// <summary>
        ///
        /// </summary>
        NameAsc,
        /// <summary>
        ///
        /// </summary>
        NameDesc,
        /// <summary>
        ///
        /// </summary>
        TraceCountAsc,
        /// <summary>
        ///
        /// </summary>
        TraceCountDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableTopicsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableTopicsOrderBy value)
        {
            return value switch
            {
                UnstableTopicsOrderBy.NameAsc => "name.asc",
                UnstableTopicsOrderBy.NameDesc => "name.desc",
                UnstableTopicsOrderBy.TraceCountAsc => "traceCount.asc",
                UnstableTopicsOrderBy.TraceCountDesc => "traceCount.desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableTopicsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "name.asc" => UnstableTopicsOrderBy.NameAsc,
                "name.desc" => UnstableTopicsOrderBy.NameDesc,
                "traceCount.asc" => UnstableTopicsOrderBy.TraceCountAsc,
                "traceCount.desc" => UnstableTopicsOrderBy.TraceCountDesc,
                _ => null,
            };
        }
    }
}