
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreConfigDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Numeric,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreConfigDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreConfigDataType value)
        {
            return value switch
            {
                ScoreConfigDataType.Numeric => "NUMERIC",
                ScoreConfigDataType.Boolean => "BOOLEAN",
                ScoreConfigDataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreConfigDataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => ScoreConfigDataType.Numeric,
                "BOOLEAN" => ScoreConfigDataType.Boolean,
                "CATEGORICAL" => ScoreConfigDataType.Categorical,
                _ => null,
            };
        }
    }
}