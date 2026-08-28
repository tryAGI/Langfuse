
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType
    {
        /// <summary>
        ///
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType value)
        {
            return value switch
            {
                EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => EvaluatorOutputDefinitionPublicEvaluatorNumericScoreDataType.Numeric,
                _ => null,
            };
        }
    }
}