
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Structured score type returned by an evaluator.<br/>
    /// This controls the type of score value Langfuse stores for evaluation results:<br/>
    /// - `NUMERIC`: a numeric score such as `0.82`<br/>
    /// - `BOOLEAN`: a boolean score such as `true`<br/>
    /// - `CATEGORICAL`: one or more category labels from a fixed list
    /// </summary>
    public enum UnstableEvaluatorOutputDataType
    {
        /// <summary>
        /// a boolean score such as `true`
        /// </summary>
        Boolean,
        /// <summary>
        /// one or more category labels from a fixed list
        /// </summary>
        Categorical,
        /// <summary>
        /// a numeric score such as `0.82`
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableEvaluatorOutputDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableEvaluatorOutputDataType value)
        {
            return value switch
            {
                UnstableEvaluatorOutputDataType.Boolean => "BOOLEAN",
                UnstableEvaluatorOutputDataType.Categorical => "CATEGORICAL",
                UnstableEvaluatorOutputDataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableEvaluatorOutputDataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => UnstableEvaluatorOutputDataType.Boolean,
                "CATEGORICAL" => UnstableEvaluatorOutputDataType.Categorical,
                "NUMERIC" => UnstableEvaluatorOutputDataType.Numeric,
                _ => null,
            };
        }
    }
}