
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableDashboardPlacementVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Preset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableDashboardPlacementVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableDashboardPlacementVariant2Type value)
        {
            return value switch
            {
                UnstableDashboardPlacementVariant2Type.Preset => "preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableDashboardPlacementVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "preset" => UnstableDashboardPlacementVariant2Type.Preset,
                _ => null,
            };
        }
    }
}