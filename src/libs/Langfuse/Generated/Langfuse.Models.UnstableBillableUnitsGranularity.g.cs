
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableBillableUnitsGranularity
    {
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        Hour,
        /// <summary>
        ///
        /// </summary>
        Month,
        /// <summary>
        ///
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableBillableUnitsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableBillableUnitsGranularity value)
        {
            return value switch
            {
                UnstableBillableUnitsGranularity.Day => "day",
                UnstableBillableUnitsGranularity.Hour => "hour",
                UnstableBillableUnitsGranularity.Month => "month",
                UnstableBillableUnitsGranularity.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableBillableUnitsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "day" => UnstableBillableUnitsGranularity.Day,
                "hour" => UnstableBillableUnitsGranularity.Hour,
                "month" => UnstableBillableUnitsGranularity.Month,
                "week" => UnstableBillableUnitsGranularity.Week,
                _ => null,
            };
        }
    }
}