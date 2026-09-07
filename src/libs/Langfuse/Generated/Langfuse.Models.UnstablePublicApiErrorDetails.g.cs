
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Optional structured context attached to an error.
    /// </summary>
    public sealed partial class UnstablePublicApiErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>? Issues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        public string? Column { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalidValues")]
        public global::System.Collections.Generic.IList<string>? InvalidValues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedValues")]
        public global::System.Collections.Generic.IList<string>? AllowedValues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryAfterSeconds")]
        public int? RetryAfterSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetAt")]
        public string? ResetAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicApiErrorDetails" /> class.
        /// </summary>
        /// <param name="issues"></param>
        /// <param name="field"></param>
        /// <param name="column"></param>
        /// <param name="invalidValues"></param>
        /// <param name="allowedValues"></param>
        /// <param name="value"></param>
        /// <param name="retryAfterSeconds"></param>
        /// <param name="limit"></param>
        /// <param name="remaining"></param>
        /// <param name="resetAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstablePublicApiErrorDetails(
            global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>? issues,
            string? field,
            string? column,
            global::System.Collections.Generic.IList<string>? invalidValues,
            global::System.Collections.Generic.IList<string>? allowedValues,
            string? value,
            int? retryAfterSeconds,
            int? limit,
            int? remaining,
            string? resetAt)
        {
            this.Issues = issues;
            this.Field = field;
            this.Column = column;
            this.InvalidValues = invalidValues;
            this.AllowedValues = allowedValues;
            this.Value = value;
            this.RetryAfterSeconds = retryAfterSeconds;
            this.Limit = limit;
            this.Remaining = remaining;
            this.ResetAt = resetAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicApiErrorDetails" /> class.
        /// </summary>
        public UnstablePublicApiErrorDetails()
        {
        }

    }
}