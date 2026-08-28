
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum IngestionEventCreateObservationEventType
    {
        /// <summary>
        ///
        /// </summary>
        ObservationCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventCreateObservationEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventCreateObservationEventType value)
        {
            return value switch
            {
                IngestionEventCreateObservationEventType.ObservationCreate => "observation-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventCreateObservationEventType? ToEnum(string value)
        {
            return value switch
            {
                "observation-create" => IngestionEventCreateObservationEventType.ObservationCreate,
                _ => null,
            };
        }
    }
}