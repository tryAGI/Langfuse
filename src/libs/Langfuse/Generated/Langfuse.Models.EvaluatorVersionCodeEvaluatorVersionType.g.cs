
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorVersionCodeEvaluatorVersionType
    {
        /// <summary>
        ///
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorVersionCodeEvaluatorVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorVersionCodeEvaluatorVersionType value)
        {
            return value switch
            {
                EvaluatorVersionCodeEvaluatorVersionType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorVersionCodeEvaluatorVersionType? ToEnum(string value)
        {
            return value switch
            {
                "code" => EvaluatorVersionCodeEvaluatorVersionType.Code,
                _ => null,
            };
        }
    }
}