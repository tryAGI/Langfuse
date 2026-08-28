
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum IngestionEventCreateGenerationEventType
    {
        /// <summary>
        ///
        /// </summary>
        GenerationCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventCreateGenerationEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventCreateGenerationEventType value)
        {
            return value switch
            {
                IngestionEventCreateGenerationEventType.GenerationCreate => "generation-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventCreateGenerationEventType? ToEnum(string value)
        {
            return value switch
            {
                "generation-create" => IngestionEventCreateGenerationEventType.GenerationCreate,
                _ => null,
            };
        }
    }
}