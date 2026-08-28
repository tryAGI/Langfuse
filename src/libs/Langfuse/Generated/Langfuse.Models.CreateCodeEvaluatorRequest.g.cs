
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCodeEvaluatorRequest
    {
        /// <summary>
        /// Human-readable evaluator name. Names are not identifiers and do not need to be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional human-readable evaluator description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Evaluator type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Source code executed for each matched observation.
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
        /// Initializes a new instance of the <see cref="CreateCodeEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable evaluator name. Names are not identifiers and do not need to be unique.
        /// </param>
        /// <param name="type">
        /// Evaluator type.
        /// </param>
        /// <param name="sourceCode">
        /// Source code executed for each matched observation.
        /// </param>
        /// <param name="sourceCodeLanguage">
        /// Code evaluator runtime language.
        /// </param>
        /// <param name="description">
        /// Optional human-readable evaluator description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCodeEvaluatorRequest(
            string name,
            string type,
            string sourceCode,
            global::Langfuse.CodeEvaluatorSourceCodeLanguage sourceCodeLanguage,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SourceCode = sourceCode ?? throw new global::System.ArgumentNullException(nameof(sourceCode));
            this.SourceCodeLanguage = sourceCodeLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCodeEvaluatorRequest" /> class.
        /// </summary>
        public CreateCodeEvaluatorRequest()
        {
        }

    }
}