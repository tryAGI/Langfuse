
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType
    {
        /// <summary>
        ///
        /// </summary>
        Preset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType value)
        {
            return value switch
            {
                UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType.Preset => "preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType? ToEnum(string value)
        {
            return value switch
            {
                "preset" => UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType.Preset,
                _ => null,
            };
        }
    }
}