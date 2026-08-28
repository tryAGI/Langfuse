
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum GetScoresResponseDataGetScoresResponseDataBooleanDataType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetScoresResponseDataGetScoresResponseDataBooleanDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScoresResponseDataGetScoresResponseDataBooleanDataType value)
        {
            return value switch
            {
                GetScoresResponseDataGetScoresResponseDataBooleanDataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScoresResponseDataGetScoresResponseDataBooleanDataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => GetScoresResponseDataGetScoresResponseDataBooleanDataType.Boolean,
                _ => null,
            };
        }
    }
}