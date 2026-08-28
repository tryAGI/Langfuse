
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType value)
        {
            return value switch
            {
                PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType.Boolean,
                _ => null,
            };
        }
    }
}