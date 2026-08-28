
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One request validation issue.
    /// </summary>
    public sealed partial class PublicApiValidationIssue
    {
        /// <summary>
        /// Validator issue code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable explanation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Path to the invalid request field.
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
        /// Initializes a new instance of the <see cref="PublicApiValidationIssue" /> class.
        /// </summary>
        /// <param name="code">
        /// Validator issue code.
        /// </param>
        /// <param name="message">
        /// Human-readable explanation.
        /// </param>
        /// <param name="path">
        /// Path to the invalid request field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicApiValidationIssue(
            string code,
            string message,
            global::System.Collections.Generic.IList<object> path)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicApiValidationIssue" /> class.
        /// </summary>
        public PublicApiValidationIssue()
        {
        }

    }
}