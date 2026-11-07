
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopicAssignment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

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
        /// The rule whose map assigned the trace. Null when the project has no rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleId")]
        public string? RuleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableTopicAssignmentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableTopicAssignmentStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        public global::Langfuse.UnstableTopicAssignmentTopic? Topic { get; set; }

        /// <summary>
        /// The run that assigned the trace. Null for assignments made as traces arrive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runId")]
        public string? RunId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AssignedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicAssignment" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="timestamp">
        /// Trace start time.
        /// </param>
        /// <param name="facetId"></param>
        /// <param name="facetName"></param>
        /// <param name="facetVersion"></param>
        /// <param name="status"></param>
        /// <param name="assignedAt"></param>
        /// <param name="ruleId">
        /// The rule whose map assigned the trace. Null when the project has no rule.
        /// </param>
        /// <param name="topic"></param>
        /// <param name="runId">
        /// The run that assigned the trace. Null for assignments made as traces arrive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopicAssignment(
            string traceId,
            global::System.DateTime timestamp,
            string facetId,
            string facetName,
            int facetVersion,
            global::Langfuse.UnstableTopicAssignmentStatus status,
            global::System.DateTime assignedAt,
            string? ruleId,
            global::Langfuse.UnstableTopicAssignmentTopic? topic,
            string? runId)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.Timestamp = timestamp;
            this.FacetId = facetId ?? throw new global::System.ArgumentNullException(nameof(facetId));
            this.FacetName = facetName ?? throw new global::System.ArgumentNullException(nameof(facetName));
            this.FacetVersion = facetVersion;
            this.RuleId = ruleId;
            this.Status = status;
            this.Topic = topic;
            this.RunId = runId;
            this.AssignedAt = assignedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicAssignment" /> class.
        /// </summary>
        public UnstableTopicAssignment()
        {
        }

    }
}