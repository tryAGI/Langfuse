
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum IngestionEventScoreEventType
    {
        /// <summary>
        ///
        /// </summary>
        ScoreCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventScoreEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventScoreEventType value)
        {
            return value switch
            {
                IngestionEventScoreEventType.ScoreCreate => "score-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventScoreEventType? ToEnum(string value)
        {
            return value switch
            {
                "score-create" => IngestionEventScoreEventType.ScoreCreate,
                _ => null,
            };
        }
    }
}