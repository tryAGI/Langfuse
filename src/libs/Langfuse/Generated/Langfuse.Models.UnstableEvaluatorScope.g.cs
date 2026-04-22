
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Where an evaluator comes from.<br/>
    /// - `project`: created in your project<br/>
    /// - `managed`: provided by Langfuse
    /// </summary>
    public enum UnstableEvaluatorScope
    {
        /// <summary>
        /// provided by Langfuse
        /// </summary>
        Managed,
        /// <summary>
        /// created in your project
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorScope value)
        {
            return value switch
            {
                UnstableEvaluatorScope.Managed => "managed",
                UnstableEvaluatorScope.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorScope? ToEnum(string value)
        {
            return value switch
            {
                "managed" => UnstableEvaluatorScope.Managed,
                "project" => UnstableEvaluatorScope.Project,
                _ => null,
            };
        }
    }
}