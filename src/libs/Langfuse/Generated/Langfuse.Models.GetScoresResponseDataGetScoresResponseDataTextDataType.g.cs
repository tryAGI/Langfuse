
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum GetScoresResponseDataGetScoresResponseDataTextDataType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetScoresResponseDataGetScoresResponseDataTextDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScoresResponseDataGetScoresResponseDataTextDataType value)
        {
            return value switch
            {
                GetScoresResponseDataGetScoresResponseDataTextDataType.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScoresResponseDataGetScoresResponseDataTextDataType? ToEnum(string value)
        {
            return value switch
            {
                "TEXT" => GetScoresResponseDataGetScoresResponseDataTextDataType.Text,
                _ => null,
            };
        }
    }
}