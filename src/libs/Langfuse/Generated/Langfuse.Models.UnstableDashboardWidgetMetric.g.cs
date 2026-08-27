
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableDashboardWidgetMetric
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Measure { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agg")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableDashboardWidgetMetricAggregationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableDashboardWidgetMetricAggregation Agg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidgetMetric" /> class.
        /// </summary>
        /// <param name="measure"></param>
        /// <param name="agg"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableDashboardWidgetMetric(
            string measure,
            global::Langfuse.UnstableDashboardWidgetMetricAggregation agg)
        {
            this.Measure = measure ?? throw new global::System.ArgumentNullException(nameof(measure));
            this.Agg = agg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidgetMetric" /> class.
        /// </summary>
        public UnstableDashboardWidgetMetric()
        {
        }

    }
}