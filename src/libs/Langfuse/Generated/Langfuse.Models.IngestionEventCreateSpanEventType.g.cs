
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum IngestionEventCreateSpanEventType
    {
        /// <summary>
        ///
        /// </summary>
        SpanCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventCreateSpanEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventCreateSpanEventType value)
        {
            return value switch
            {
                IngestionEventCreateSpanEventType.SpanCreate => "span-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventCreateSpanEventType? ToEnum(string value)
        {
            return value switch
            {
                "span-create" => IngestionEventCreateSpanEventType.SpanCreate,
                _ => null,
            };
        }
    }
}