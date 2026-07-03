
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableDashboardWidgetSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableDashboardWidgetSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableDashboardWidgetSortOrder value)
        {
            return value switch
            {
                UnstableDashboardWidgetSortOrder.Asc => "ASC",
                UnstableDashboardWidgetSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableDashboardWidgetSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => UnstableDashboardWidgetSortOrder.Asc,
                "DESC" => UnstableDashboardWidgetSortOrder.Desc,
                _ => null,
            };
        }
    }
}