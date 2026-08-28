
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum IngestionEventUpdateGenerationEventType
    {
        /// <summary>
        ///
        /// </summary>
        GenerationUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventUpdateGenerationEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventUpdateGenerationEventType value)
        {
            return value switch
            {
                IngestionEventUpdateGenerationEventType.GenerationUpdate => "generation-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventUpdateGenerationEventType? ToEnum(string value)
        {
            return value switch
            {
                "generation-update" => IngestionEventUpdateGenerationEventType.GenerationUpdate,
                _ => null,
            };
        }
    }
}