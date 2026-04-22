
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One validation issue returned for malformed request bodies or query parameters.<br/>
    /// This mirrors the most important parts of a Zod issue: a machine-readable `code`,<br/>
    /// a human-readable `message`, and a structured `path`.
    /// </summary>
    public sealed partial class UnstablePublicApiValidationIssue
    {
        /// <summary>
        /// Machine-readable validation issue code emitted by the server validator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable explanation of the validation failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Path to the invalid field, for example `["mapping", 0, "jsonPath"]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicApiValidationIssue" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable validation issue code emitted by the server validator.
        /// </param>
        /// <param name="message">
        /// Human-readable explanation of the validation failure.
        /// </param>
        /// <param name="path">
        /// Path to the invalid field, for example `["mapping", 0, "jsonPath"]`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstablePublicApiValidationIssue(
            string code,
            string message,
            global::System.Collections.Generic.IList<object> path)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicApiValidationIssue" /> class.
        /// </summary>
        public UnstablePublicApiValidationIssue()
        {
        }
    }
}