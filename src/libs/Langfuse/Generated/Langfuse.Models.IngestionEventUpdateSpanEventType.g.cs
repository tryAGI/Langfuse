
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum IngestionEventUpdateSpanEventType
    {
        /// <summary>
        ///
        /// </summary>
        SpanUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventUpdateSpanEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventUpdateSpanEventType value)
        {
            return value switch
            {
                IngestionEventUpdateSpanEventType.SpanUpdate => "span-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventUpdateSpanEventType? ToEnum(string value)
        {
            return value switch
            {
                "span-update" => IngestionEventUpdateSpanEventType.SpanUpdate,
                _ => null,
            };
        }
    }
}