
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Standard error envelope for the unstable evaluators API.<br/>
    /// Response handling guidance:<br/>
    /// - Use the HTTP status code for the broad class of failure.<br/>
    /// - Use `code` for precise branching in SDKs, CLIs, or agents.<br/>
    /// - Inspect `details` for field-level validation context such as invalid filter values, malformed JSONPath expressions, or missing variable mappings.<br/>
    /// - Retry only after fixing the specific issue described by `code` and `details`.
    /// </summary>
    public sealed partial class UnstablePublicApiError
    {
        /// <summary>
        /// Human-readable description of the failure.<br/>
        /// Example: Filter column "type" contains unsupported value(s): INVALID
        /// </summary>
        /// <example>Filter column "type" contains unsupported value(s): INVALID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Machine-readable error code returned by the unstable evaluators API.<br/>
        /// SDKs, CLIs, and agents should branch on `code` rather than parsing the human-readable `message`.<br/>
        /// The HTTP status still indicates the broad error class, while `code` gives the specific failure reason.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstablePublicApiErrorCode Code { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Langfuse.UnstablePublicApiErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicApiError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable description of the failure.<br/>
        /// Example: Filter column "type" contains unsupported value(s): INVALID
        /// </param>
        /// <param name="code">
        /// Machine-readable error code returned by the unstable evaluators API.<br/>
        /// SDKs, CLIs, and agents should branch on `code` rather than parsing the human-readable `message`.<br/>
        /// The HTTP status still indicates the broad error class, while `code` gives the specific failure reason.
        /// </param>
        /// <param name="details">
        /// Optional structured context attached to an unstable-evals error.<br/>
        /// The populated fields depend on the error `code`:<br/>
        /// - request parsing failures populate `issues`<br/>
        /// - filter validation failures populate `field`, `column`, `invalidValues`, and `allowedValues`<br/>
        /// - variable mapping failures populate `field`, `variable`, or `variables`<br/>
        /// - JSONPath validation failures populate `field`, `variable`, and `value`<br/>
        /// - evaluator preflight failures populate `evaluatorName`, `provider`, and `model`<br/>
        /// - rate limiting populates `retryAfterSeconds`, `limit`, `remaining`, and `resetAt`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstablePublicApiError(
            string message,
            global::Langfuse.UnstablePublicApiErrorCode code,
            global::Langfuse.UnstablePublicApiErrorDetails? details)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicApiError" /> class.
        /// </summary>
        public UnstablePublicApiError()
        {
        }

    }
}