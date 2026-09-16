
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IngestionBatchRequest
    {
        /// <summary>
        /// Batch of events to be ingested, discriminated by attribute `type`. From November 16, 2026 on Langfuse Cloud, only `score-create` events are accepted; all other event types are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.IngestionEvent> Batch { get; set; }

        /// <summary>
        /// Optional. Metadata field used by the Langfuse SDKs for debugging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionBatchRequest" /> class.
        /// </summary>
        /// <param name="batch">
        /// Batch of events to be ingested, discriminated by attribute `type`. From November 16, 2026 on Langfuse Cloud, only `score-create` events are accepted; all other event types are rejected.
        /// </param>
        /// <param name="metadata">
        /// Optional. Metadata field used by the Langfuse SDKs for debugging.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IngestionBatchRequest(
            global::System.Collections.Generic.IList<global::Langfuse.IngestionEvent> batch,
            object? metadata)
        {
            this.Batch = batch ?? throw new global::System.ArgumentNullException(nameof(batch));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionBatchRequest" /> class.
        /// </summary>
        public IngestionBatchRequest()
        {
        }

    }
}