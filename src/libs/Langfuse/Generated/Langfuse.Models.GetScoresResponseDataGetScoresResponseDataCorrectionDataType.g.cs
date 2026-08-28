
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum GetScoresResponseDataGetScoresResponseDataCorrectionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Correction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetScoresResponseDataGetScoresResponseDataCorrectionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScoresResponseDataGetScoresResponseDataCorrectionDataType value)
        {
            return value switch
            {
                GetScoresResponseDataGetScoresResponseDataCorrectionDataType.Correction => "CORRECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScoresResponseDataGetScoresResponseDataCorrectionDataType? ToEnum(string value)
        {
            return value switch
            {
                "CORRECTION" => GetScoresResponseDataGetScoresResponseDataCorrectionDataType.Correction,
                _ => null,
            };
        }
    }
}