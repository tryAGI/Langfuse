
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum IngestionEventSDKLogEventType
    {
        /// <summary>
        ///
        /// </summary>
        SdkLog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventSDKLogEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventSDKLogEventType value)
        {
            return value switch
            {
                IngestionEventSDKLogEventType.SdkLog => "sdk-log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventSDKLogEventType? ToEnum(string value)
        {
            return value switch
            {
                "sdk-log" => IngestionEventSDKLogEventType.SdkLog,
                _ => null,
            };
        }
    }
}