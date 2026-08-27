
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableDashboardWidgetDefaultSort
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableDashboardWidgetSortOrderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableDashboardWidgetSortOrder Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidgetDefaultSort" /> class.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="order"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableDashboardWidgetDefaultSort(
            string column,
            global::Langfuse.UnstableDashboardWidgetSortOrder order)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Order = order;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidgetDefaultSort" /> class.
        /// </summary>
        public UnstableDashboardWidgetDefaultSort()
        {
        }

    }
}