
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationQueueStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationQueueStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueStatus value)
        {
            return value switch
            {
                AnnotationQueueStatus.Pending => "PENDING",
                AnnotationQueueStatus.Completed => "COMPLETED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueStatus? ToEnum(string value)
        {
            return value switch
            {
                "PENDING" => AnnotationQueueStatus.Pending,
                "COMPLETED" => AnnotationQueueStatus.Completed,
                _ => null,
            };
        }
    }
}