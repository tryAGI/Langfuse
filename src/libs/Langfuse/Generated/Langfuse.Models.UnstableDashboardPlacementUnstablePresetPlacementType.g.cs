
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableDashboardPlacementUnstablePresetPlacementType
    {
        /// <summary>
        ///
        /// </summary>
        Preset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableDashboardPlacementUnstablePresetPlacementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableDashboardPlacementUnstablePresetPlacementType value)
        {
            return value switch
            {
                UnstableDashboardPlacementUnstablePresetPlacementType.Preset => "preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableDashboardPlacementUnstablePresetPlacementType? ToEnum(string value)
        {
            return value switch
            {
                "preset" => UnstableDashboardPlacementUnstablePresetPlacementType.Preset,
                _ => null,
            };
        }
    }
}