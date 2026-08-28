
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum IngestionEventUpdateObservationEventType
    {
        /// <summary>
        ///
        /// </summary>
        ObservationUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventUpdateObservationEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventUpdateObservationEventType value)
        {
            return value switch
            {
                IngestionEventUpdateObservationEventType.ObservationUpdate => "observation-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventUpdateObservationEventType? ToEnum(string value)
        {
            return value switch
            {
                "observation-update" => IngestionEventUpdateObservationEventType.ObservationUpdate,
                _ => null,
            };
        }
    }
}