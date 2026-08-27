
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableDashboardPlacementVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Widget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableDashboardPlacementVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableDashboardPlacementVariant1Type value)
        {
            return value switch
            {
                UnstableDashboardPlacementVariant1Type.Widget => "widget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableDashboardPlacementVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "widget" => UnstableDashboardPlacementVariant1Type.Widget,
                _ => null,
            };
        }
    }
}