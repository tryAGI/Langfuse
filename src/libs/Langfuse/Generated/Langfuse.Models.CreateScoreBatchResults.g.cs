
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Acceptance counts and errors (HTTP 207).
    /// </summary>
    public sealed partial class CreateScoreBatchResults
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Accepted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rejected { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.CreateScoreBatchError> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScoreBatchResults" /> class.
        /// </summary>
        /// <param name="accepted"></param>
        /// <param name="rejected"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateScoreBatchResults(
            int accepted,
            int rejected,
            global::System.Collections.Generic.IList<global::Langfuse.CreateScoreBatchError> errors)
        {
            this.Accepted = accepted;
            this.Rejected = rejected;
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScoreBatchResults" /> class.
        /// </summary>
        public CreateScoreBatchResults()
        {
        }

    }
}