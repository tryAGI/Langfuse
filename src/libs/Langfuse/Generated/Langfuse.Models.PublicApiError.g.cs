
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Standard error response for the stable evaluators and evaluation-rules API.<br/>
    /// Use the HTTP status for the broad failure class and `code` for programmatic handling. `details` is included when field-level validation or retry information is available.
    /// </summary>
    public sealed partial class PublicApiError
    {
        /// <summary>
        /// Human-readable description of the failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Stable machine-readable error code returned by the evaluators and evaluation-rules API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.PublicApiErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.PublicApiErrorCode Code { get; set; }

        /// <summary>
        /// Optional structured context for validation and rate-limit errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Langfuse.PublicApiErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApiError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable description of the failure.
        /// </param>
        /// <param name="code">
        /// Stable machine-readable error code returned by the evaluators and evaluation-rules API.
        /// </param>
        /// <param name="details">
        /// Optional structured context for validation and rate-limit errors.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicApiError(
            string message,
            global::Langfuse.PublicApiErrorCode code,
            global::Langfuse.PublicApiErrorDetails? details)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApiError" /> class.
        /// </summary>
        public PublicApiError()
        {
        }

    }
}