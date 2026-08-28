
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum IngestionEventTraceEventType
    {
        /// <summary>
        ///
        /// </summary>
        TraceCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventTraceEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventTraceEventType value)
        {
            return value switch
            {
                IngestionEventTraceEventType.TraceCreate => "trace-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventTraceEventType? ToEnum(string value)
        {
            return value switch
            {
                "trace-create" => IngestionEventTraceEventType.TraceCreate,
                _ => null,
            };
        }
    }
}