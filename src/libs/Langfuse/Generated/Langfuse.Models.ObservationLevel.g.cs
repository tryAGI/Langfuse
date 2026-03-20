
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservationLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservationLevel value)
        {
            return value switch
            {
                ObservationLevel.Debug => "DEBUG",
                ObservationLevel.Default => "DEFAULT",
                ObservationLevel.Warning => "WARNING",
                ObservationLevel.Error => "ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservationLevel? ToEnum(string value)
        {
            return value switch
            {
                "DEBUG" => ObservationLevel.Debug,
                "DEFAULT" => ObservationLevel.Default,
                "WARNING" => ObservationLevel.Warning,
                "ERROR" => ObservationLevel.Error,
                _ => null,
            };
        }
    }
}