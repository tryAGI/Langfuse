
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreV3Variant5DataType
    {
        /// <summary>
        ///
        /// </summary>
        Correction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV3Variant5DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV3Variant5DataType value)
        {
            return value switch
            {
                ScoreV3Variant5DataType.Correction => "CORRECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV3Variant5DataType? ToEnum(string value)
        {
            return value switch
            {
                "CORRECTION" => ScoreV3Variant5DataType.Correction,
                _ => null,
            };
        }
    }
}