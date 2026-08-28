
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorCodeEvaluatorType
    {
        /// <summary>
        ///
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorCodeEvaluatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorCodeEvaluatorType value)
        {
            return value switch
            {
                EvaluatorCodeEvaluatorType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorCodeEvaluatorType? ToEnum(string value)
        {
            return value switch
            {
                "code" => EvaluatorCodeEvaluatorType.Code,
                _ => null,
            };
        }
    }
}