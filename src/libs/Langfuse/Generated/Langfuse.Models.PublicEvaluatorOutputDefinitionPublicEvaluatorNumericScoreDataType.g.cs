
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType
    {
        /// <summary>
        ///
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType value)
        {
            return value switch
            {
                PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType.Numeric,
                _ => null,
            };
        }
    }
}