
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableCreateDashboardPlacementRequestVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Preset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableCreateDashboardPlacementRequestVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableCreateDashboardPlacementRequestVariant2Type value)
        {
            return value switch
            {
                UnstableCreateDashboardPlacementRequestVariant2Type.Preset => "preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableCreateDashboardPlacementRequestVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "preset" => UnstableCreateDashboardPlacementRequestVariant2Type.Preset,
                _ => null,
            };
        }
    }
}