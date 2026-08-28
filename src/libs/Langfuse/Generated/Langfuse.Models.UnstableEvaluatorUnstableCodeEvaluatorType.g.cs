
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableEvaluatorUnstableCodeEvaluatorType
    {
        /// <summary>
        ///
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorUnstableCodeEvaluatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorUnstableCodeEvaluatorType value)
        {
            return value switch
            {
                UnstableEvaluatorUnstableCodeEvaluatorType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorUnstableCodeEvaluatorType? ToEnum(string value)
        {
            return value switch
            {
                "code" => UnstableEvaluatorUnstableCodeEvaluatorType.Code,
                _ => null,
            };
        }
    }
}