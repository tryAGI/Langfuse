
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Optional structured context attached to an unstable-evals error.<br/>
    /// The populated fields depend on the error `code`:<br/>
    /// - request parsing failures populate `issues`<br/>
    /// - filter validation failures populate `field`, `column`, `invalidValues`, and `allowedValues`<br/>
    /// - variable mapping failures populate `field`, `variable`, or `variables`<br/>
    /// - JSONPath validation failures populate `field`, `variable`, and `value`<br/>
    /// - evaluator preflight failures populate `evaluatorName`, `provider`, and `model`<br/>
    /// - rate limiting populates `retryAfterSeconds`, `limit`, `remaining`, and `resetAt`
    /// </summary>
    public sealed partial class UnstablePublicApiErrorDetails
    {
        /// <summary>
        /// Validation issues for malformed request bodies or query parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>? Issues { get; set; }

        /// <summary>
        /// Path-like reference to the failing field, for example `mapping[1].jsonPath`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        /// Filter column that failed validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        public string? Column { get; set; }

        /// <summary>
        /// Unsupported values supplied by the caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalidValues")]
        public global::System.Collections.Generic.IList<string>? InvalidValues { get; set; }

        /// <summary>
        /// Allowed values for the failing filter column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedValues")]
        public global::System.Collections.Generic.IList<string>? AllowedValues { get; set; }

        /// <summary>
        /// Evaluator variable involved in the failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        public string? Variable { get; set; }

        /// <summary>
        /// Multiple evaluator variables involved in the failure, for example missing mappings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<string>? Variables { get; set; }

        /// <summary>
        /// Raw invalid value supplied by the caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Evaluator name used during preflight validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorName")]
        public string? EvaluatorName { get; set; }

        /// <summary>
        /// Provider resolved during evaluator preflight, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Model resolved during evaluator preflight, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Suggested retry delay for rate-limited requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryAfterSeconds")]
        public int? RetryAfterSeconds { get; set; }

        /// <summary>
        /// Numeric limit associated with the failure, for example the active evaluation-rule cap or the current rate-limit window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Remaining requests in the current rate-limit window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// ISO-8601 timestamp when the current rate-limit window resets.
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
        /// <param name="issues">
        /// Validation issues for malformed request bodies or query parameters.
        /// </param>
        /// <param name="field">
        /// Path-like reference to the failing field, for example `mapping[1].jsonPath`.
        /// </param>
        /// <param name="column">
        /// Filter column that failed validation.
        /// </param>
        /// <param name="invalidValues">
        /// Unsupported values supplied by the caller.
        /// </param>
        /// <param name="allowedValues">
        /// Allowed values for the failing filter column.
        /// </param>
        /// <param name="variable">
        /// Evaluator variable involved in the failure.
        /// </param>
        /// <param name="variables">
        /// Multiple evaluator variables involved in the failure, for example missing mappings.
        /// </param>
        /// <param name="value">
        /// Raw invalid value supplied by the caller.
        /// </param>
        /// <param name="evaluatorName">
        /// Evaluator name used during preflight validation.
        /// </param>
        /// <param name="provider">
        /// Provider resolved during evaluator preflight, if any.
        /// </param>
        /// <param name="model">
        /// Model resolved during evaluator preflight, if any.
        /// </param>
        /// <param name="retryAfterSeconds">
        /// Suggested retry delay for rate-limited requests.
        /// </param>
        /// <param name="limit">
        /// Numeric limit associated with the failure, for example the active evaluation-rule cap or the current rate-limit window.
        /// </param>
        /// <param name="remaining">
        /// Remaining requests in the current rate-limit window.
        /// </param>
        /// <param name="resetAt">
        /// ISO-8601 timestamp when the current rate-limit window resets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstablePublicApiErrorDetails(
            global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>? issues,
            string? field,
            string? column,
            global::System.Collections.Generic.IList<string>? invalidValues,
            global::System.Collections.Generic.IList<string>? allowedValues,
            string? variable,
            global::System.Collections.Generic.IList<string>? variables,
            string? value,
            string? evaluatorName,
            string? provider,
            string? model,
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
            this.Variable = variable;
            this.Variables = variables;
            this.Value = value;
            this.EvaluatorName = evaluatorName;
            this.Provider = provider;
            this.Model = model;
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