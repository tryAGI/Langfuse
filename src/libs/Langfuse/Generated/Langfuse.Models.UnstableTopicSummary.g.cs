
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopicSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// Trace start time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FacetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FacetName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FacetVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableTopicSummaryStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableTopicSummaryState State { get; set; }

        /// <summary>
        /// Set when `state` is `complete`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaryTruncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SummaryTruncated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicSummary" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="traceName"></param>
        /// <param name="environment"></param>
        /// <param name="timestamp">
        /// Trace start time.
        /// </param>
        /// <param name="facetId"></param>
        /// <param name="facetName"></param>
        /// <param name="facetVersion"></param>
        /// <param name="state"></param>
        /// <param name="summaryTruncated"></param>
        /// <param name="processedAt"></param>
        /// <param name="summary">
        /// Set when `state` is `complete`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopicSummary(
            string traceId,
            string traceName,
            string environment,
            global::System.DateTime timestamp,
            string facetId,
            string facetName,
            int facetVersion,
            global::Langfuse.UnstableTopicSummaryState state,
            bool summaryTruncated,
            global::System.DateTime processedAt,
            string? summary)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.TraceName = traceName ?? throw new global::System.ArgumentNullException(nameof(traceName));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Timestamp = timestamp;
            this.FacetId = facetId ?? throw new global::System.ArgumentNullException(nameof(facetId));
            this.FacetName = facetName ?? throw new global::System.ArgumentNullException(nameof(facetName));
            this.FacetVersion = facetVersion;
            this.State = state;
            this.Summary = summary;
            this.SummaryTruncated = summaryTruncated;
            this.ProcessedAt = processedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicSummary" /> class.
        /// </summary>
        public UnstableTopicSummary()
        {
        }

    }
}