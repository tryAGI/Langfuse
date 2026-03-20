
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreDataType
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
        /// <summary>
        /// 
        /// </summary>
        Correction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreDataType value)
        {
            return value switch
            {
                ScoreDataType.Numeric => "NUMERIC",
                ScoreDataType.Boolean => "BOOLEAN",
                ScoreDataType.Categorical => "CATEGORICAL",
                ScoreDataType.Correction => "CORRECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreDataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => ScoreDataType.Numeric,
                "BOOLEAN" => ScoreDataType.Boolean,
                "CATEGORICAL" => ScoreDataType.Categorical,
                "CORRECTION" => ScoreDataType.Correction,
                _ => null,
            };
        }
    }
}