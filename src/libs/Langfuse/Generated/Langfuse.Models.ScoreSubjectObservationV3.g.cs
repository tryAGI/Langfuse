
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScoreSubjectObservationV3
    {
        /// <summary>
        /// The observation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The parent trace ID, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSubjectObservationV3" /> class.
        /// </summary>
        /// <param name="id">
        /// The observation ID.
        /// </param>
        /// <param name="traceId">
        /// The parent trace ID, if available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreSubjectObservationV3(
            string id,
            string? traceId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSubjectObservationV3" /> class.
        /// </summary>
        public ScoreSubjectObservationV3()
        {
        }

    }
}