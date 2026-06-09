
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyGetScoresResponseDataVariant4DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Correction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyGetScoresResponseDataVariant4DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyGetScoresResponseDataVariant4DataType value)
        {
            return value switch
            {
                LegacyGetScoresResponseDataVariant4DataType.Correction => "CORRECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyGetScoresResponseDataVariant4DataType? ToEnum(string value)
        {
            return value switch
            {
                "CORRECTION" => LegacyGetScoresResponseDataVariant4DataType.Correction,
                _ => null,
            };
        }
    }
}