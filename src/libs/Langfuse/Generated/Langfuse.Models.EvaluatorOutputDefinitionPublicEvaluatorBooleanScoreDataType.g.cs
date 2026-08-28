
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType value)
        {
            return value switch
            {
                EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType.Boolean,
                _ => null,
            };
        }
    }
}