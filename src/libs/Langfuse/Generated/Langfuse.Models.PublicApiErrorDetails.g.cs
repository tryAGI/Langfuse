
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Optional structured context for validation and rate-limit errors.
    /// </summary>
    public sealed partial class PublicApiErrorDetails
    {
        /// <summary>
        /// Validation issues for an invalid request body or query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<global::Langfuse.PublicApiValidationIssue>? Issues { get; set; }

        /// <summary>
        /// Number of seconds to wait before retrying a rate-limited request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryAfterSeconds")]
        public int? RetryAfterSeconds { get; set; }

        /// <summary>
        /// Rate-limit request allowance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Remaining requests in the current rate-limit window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// Time when the current rate-limit window resets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetAt")]
        public global::System.DateTime? ResetAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApiErrorDetails" /> class.
        /// </summary>
        /// <param name="issues">
        /// Validation issues for an invalid request body or query.
        /// </param>
        /// <param name="retryAfterSeconds">
        /// Number of seconds to wait before retrying a rate-limited request.
        /// </param>
        /// <param name="limit">
        /// Rate-limit request allowance.
        /// </param>
        /// <param name="remaining">
        /// Remaining requests in the current rate-limit window.
        /// </param>
        /// <param name="resetAt">
        /// Time when the current rate-limit window resets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicApiErrorDetails(
            global::System.Collections.Generic.IList<global::Langfuse.PublicApiValidationIssue>? issues,
            int? retryAfterSeconds,
            int? limit,
            int? remaining,
            global::System.DateTime? resetAt)
        {
            this.Issues = issues;
            this.RetryAfterSeconds = retryAfterSeconds;
            this.Limit = limit;
            this.Remaining = remaining;
            this.ResetAt = resetAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApiErrorDetails" /> class.
        /// </summary>
        public PublicApiErrorDetails()
        {
        }

    }
}