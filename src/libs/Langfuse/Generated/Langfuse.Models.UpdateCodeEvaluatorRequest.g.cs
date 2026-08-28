
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateCodeEvaluatorRequest
    {
        /// <summary>
        /// New human-readable evaluator name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description. Set to `null` to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Evaluator type. The type of an existing evaluator cannot change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Complete replacement source code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceCode { get; set; }

        /// <summary>
        /// Code evaluator runtime language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceCodeLanguage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.CodeEvaluatorSourceCodeLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.CodeEvaluatorSourceCodeLanguage SourceCodeLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCodeEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Evaluator type. The type of an existing evaluator cannot change.
        /// </param>
        /// <param name="sourceCode">
        /// Complete replacement source code.
        /// </param>
        /// <param name="sourceCodeLanguage">
        /// Code evaluator runtime language.
        /// </param>
        /// <param name="name">
        /// New human-readable evaluator name.
        /// </param>
        /// <param name="description">
        /// New description. Set to `null` to clear it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCodeEvaluatorRequest(
            string type,
            string sourceCode,
            global::Langfuse.CodeEvaluatorSourceCodeLanguage sourceCodeLanguage,
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SourceCode = sourceCode ?? throw new global::System.ArgumentNullException(nameof(sourceCode));
            this.SourceCodeLanguage = sourceCodeLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCodeEvaluatorRequest" /> class.
        /// </summary>
        public UpdateCodeEvaluatorRequest()
        {
        }

    }
}