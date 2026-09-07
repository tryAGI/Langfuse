
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Standard error envelope for unstable public API endpoints.
    /// </summary>
    public sealed partial class UnstablePublicApiError
    {
        /// <summary>
        /// Human-readable description of the failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Machine-readable error code returned by unstable public API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstablePublicApiErrorCode Code { get; set; }

        /// <summary>
        /// Optional structured context attached to an error.
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
        /// Human-readable description of the failure.
        /// </param>
        /// <param name="code">
        /// Machine-readable error code returned by unstable public API endpoints.
        /// </param>
        /// <param name="details">
        /// Optional structured context attached to an error.
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