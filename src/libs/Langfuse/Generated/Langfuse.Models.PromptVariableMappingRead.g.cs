
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Connects one prompt variable to source data.<br/>
    /// `source` is `null` when the mapping is incomplete.
    /// </summary>
    public sealed partial class PromptVariableMappingRead
    {
        /// <summary>
        /// Prompt variable name without braces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variable { get; set; }

        /// <summary>
        /// Stored source field populating the variable, or `null` when the mapping is incomplete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Optional JSONPath selector applied to the selected source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jsonPath")]
        public string? JsonPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVariableMappingRead" /> class.
        /// </summary>
        /// <param name="variable">
        /// Prompt variable name without braces.
        /// </param>
        /// <param name="source">
        /// Stored source field populating the variable, or `null` when the mapping is incomplete.
        /// </param>
        /// <param name="jsonPath">
        /// Optional JSONPath selector applied to the selected source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVariableMappingRead(
            string variable,
            string? source,
            string? jsonPath)
        {
            this.Variable = variable ?? throw new global::System.ArgumentNullException(nameof(variable));
            this.Source = source;
            this.JsonPath = jsonPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVariableMappingRead" /> class.
        /// </summary>
        public PromptVariableMappingRead()
        {
        }

    }
}