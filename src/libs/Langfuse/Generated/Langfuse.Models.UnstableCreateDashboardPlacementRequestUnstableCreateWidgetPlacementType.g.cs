
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType
    {
        /// <summary>
        ///
        /// </summary>
        Widget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType value)
        {
            return value switch
            {
                UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType.Widget => "widget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType? ToEnum(string value)
        {
            return value switch
            {
                "widget" => UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType.Widget,
                _ => null,
            };
        }
    }
}