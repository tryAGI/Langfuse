
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScoresResponseDataVariant5DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetScoresResponseDataVariant5DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScoresResponseDataVariant5DataType value)
        {
            return value switch
            {
                GetScoresResponseDataVariant5DataType.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScoresResponseDataVariant5DataType? ToEnum(string value)
        {
            return value switch
            {
                "TEXT" => GetScoresResponseDataVariant5DataType.Text,
                _ => null,
            };
        }
    }
}