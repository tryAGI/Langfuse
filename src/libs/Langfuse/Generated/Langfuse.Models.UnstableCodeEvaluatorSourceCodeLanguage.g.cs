
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Code evaluator runtime language.
    /// </summary>
    public enum UnstableCodeEvaluatorSourceCodeLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Python,
        /// <summary>
        /// 
        /// </summary>
        Typescript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableCodeEvaluatorSourceCodeLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableCodeEvaluatorSourceCodeLanguage value)
        {
            return value switch
            {
                UnstableCodeEvaluatorSourceCodeLanguage.Python => "PYTHON",
                UnstableCodeEvaluatorSourceCodeLanguage.Typescript => "TYPESCRIPT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableCodeEvaluatorSourceCodeLanguage? ToEnum(string value)
        {
            return value switch
            {
                "PYTHON" => UnstableCodeEvaluatorSourceCodeLanguage.Python,
                "TYPESCRIPT" => UnstableCodeEvaluatorSourceCodeLanguage.Typescript,
                _ => null,
            };
        }
    }
}