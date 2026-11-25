
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Billable units of one project in one bucket.
    /// </summary>
    public sealed partial class UnstableBillableUnitsRow
    {
        /// <summary>
        /// Start of the UTC bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Bucket { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// All billable units, the sum of the per-type counts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Traces { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Observations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Scores { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topicFacetSummaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TopicFacetSummaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableBillableUnitsRow" /> class.
        /// </summary>
        /// <param name="bucket">
        /// Start of the UTC bucket.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="count">
        /// All billable units, the sum of the per-type counts.
        /// </param>
        /// <param name="traces"></param>
        /// <param name="observations"></param>
        /// <param name="scores"></param>
        /// <param name="topicFacetSummaries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableBillableUnitsRow(
            global::System.DateTime bucket,
            string projectId,
            int count,
            int traces,
            int observations,
            int scores,
            int topicFacetSummaries)
        {
            this.Bucket = bucket;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Count = count;
            this.Traces = traces;
            this.Observations = observations;
            this.Scores = scores;
            this.TopicFacetSummaries = topicFacetSummaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableBillableUnitsRow" /> class.
        /// </summary>
        public UnstableBillableUnitsRow()
        {
        }

    }
}