
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Code evaluator runtime language.
    /// </summary>
    public enum CodeEvaluatorSourceCodeLanguage
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
    public static class CodeEvaluatorSourceCodeLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEvaluatorSourceCodeLanguage value)
        {
            return value switch
            {
                CodeEvaluatorSourceCodeLanguage.Python => "PYTHON",
                CodeEvaluatorSourceCodeLanguage.Typescript => "TYPESCRIPT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEvaluatorSourceCodeLanguage? ToEnum(string value)
        {
            return value switch
            {
                "PYTHON" => CodeEvaluatorSourceCodeLanguage.Python,
                "TYPESCRIPT" => CodeEvaluatorSourceCodeLanguage.Typescript,
                _ => null,
            };
        }
    }
}