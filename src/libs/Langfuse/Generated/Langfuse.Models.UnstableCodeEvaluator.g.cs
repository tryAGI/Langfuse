
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableCodeEvaluator
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableCodeEvaluatorSourceCodeLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableCodeEvaluatorSourceCodeLanguage SourceCodeLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCodeEvaluator" /> class.
        /// </summary>
        /// <param name="sourceCode">
        /// Source code executed for each matched observation.
        /// </param>
        /// <param name="sourceCodeLanguage">
        /// Code evaluator runtime language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableCodeEvaluator(
            string sourceCode,
            global::Langfuse.UnstableCodeEvaluatorSourceCodeLanguage sourceCodeLanguage)
        {
            this.SourceCode = sourceCode ?? throw new global::System.ArgumentNullException(nameof(sourceCode));
            this.SourceCodeLanguage = sourceCodeLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableCodeEvaluator" /> class.
        /// </summary>
        public UnstableCodeEvaluator()
        {
        }

    }
}