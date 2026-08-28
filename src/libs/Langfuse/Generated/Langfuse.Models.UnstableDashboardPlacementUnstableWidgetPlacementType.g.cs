
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableDashboardPlacementUnstableWidgetPlacementType
    {
        /// <summary>
        ///
        /// </summary>
        Widget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableDashboardPlacementUnstableWidgetPlacementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableDashboardPlacementUnstableWidgetPlacementType value)
        {
            return value switch
            {
                UnstableDashboardPlacementUnstableWidgetPlacementType.Widget => "widget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableDashboardPlacementUnstableWidgetPlacementType? ToEnum(string value)
        {
            return value switch
            {
                "widget" => UnstableDashboardPlacementUnstableWidgetPlacementType.Widget,
                _ => null,
            };
        }
    }
}