
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum IngestionEventCreateEventEventType
    {
        /// <summary>
        ///
        /// </summary>
        EventCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventCreateEventEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventCreateEventEventType value)
        {
            return value switch
            {
                IngestionEventCreateEventEventType.EventCreate => "event-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventCreateEventEventType? ToEnum(string value)
        {
            return value switch
            {
                "event-create" => IngestionEventCreateEventEventType.EventCreate,
                _ => null,
            };
        }
    }
}