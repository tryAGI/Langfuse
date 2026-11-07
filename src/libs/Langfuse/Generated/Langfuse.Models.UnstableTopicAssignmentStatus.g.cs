
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableTopicAssignmentStatus
    {
        /// <summary>
        ///
        /// </summary>
        Assigned,
        /// <summary>
        ///
        /// </summary>
        Outlier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableTopicAssignmentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableTopicAssignmentStatus value)
        {
            return value switch
            {
                UnstableTopicAssignmentStatus.Assigned => "assigned",
                UnstableTopicAssignmentStatus.Outlier => "outlier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableTopicAssignmentStatus? ToEnum(string value)
        {
            return value switch
            {
                "assigned" => UnstableTopicAssignmentStatus.Assigned,
                "outlier" => UnstableTopicAssignmentStatus.Outlier,
                _ => null,
            };
        }
    }
}