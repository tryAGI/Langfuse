
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Connects one prompt variable to data from a target.<br/>
    /// `source` is `null` when the mapping is incomplete.
    /// </summary>
    public sealed partial class UnstablePromptVariableMappingRead
    {
        /// <summary>
        /// Prompt variable name without braces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variable { get; set; }

        /// <summary>
        /// Source field used to populate a prompt variable.<br/>
        /// Use these values when mapping evaluator prompt variables to live data.<br/>
        /// Target-specific rules:<br/>
        /// - `target=observation` supports `input`, `output`, `metadata`, and `tool_calls`<br/>
        /// - `target=experiment` supports `input`, `output`, `metadata`, `tool_calls`, `expected_output`, and `experiment_item_metadata`<br/>
        /// Source semantics:<br/>
        /// - `input`: the observation or experiment input payload<br/>
        /// - `output`: the observation or experiment output payload<br/>
        /// - `metadata`: the metadata object for the target. Combine with `jsonPath` when you need one nested field instead of the whole object.<br/>
        /// - `tool_calls`: the tool calls recorded on the observation, as an array of `{id, name, arguments, type, index}` objects in the order the model emitted them. Combine with `jsonPath` (for example `$[*].name`) to select parts of each call.<br/>
        /// - `expected_output`: the experiment item's expected output. Only valid for `target=experiment`.<br/>
        /// - `experiment_item_metadata`: the experiment item's metadata object. Only valid for `target=experiment`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstablePromptVariableMappingSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstablePromptVariableMappingSource Source { get; set; }

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
        /// Initializes a new instance of the <see cref="UnstablePromptVariableMappingRead" /> class.
        /// </summary>
        /// <param name="variable">
        /// Prompt variable name without braces.
        /// </param>
        /// <param name="source">
        /// Source field used to populate a prompt variable.<br/>
        /// Use these values when mapping evaluator prompt variables to live data.<br/>
        /// Target-specific rules:<br/>
        /// - `target=observation` supports `input`, `output`, `metadata`, and `tool_calls`<br/>
        /// - `target=experiment` supports `input`, `output`, `metadata`, `tool_calls`, `expected_output`, and `experiment_item_metadata`<br/>
        /// Source semantics:<br/>
        /// - `input`: the observation or experiment input payload<br/>
        /// - `output`: the observation or experiment output payload<br/>
        /// - `metadata`: the metadata object for the target. Combine with `jsonPath` when you need one nested field instead of the whole object.<br/>
        /// - `tool_calls`: the tool calls recorded on the observation, as an array of `{id, name, arguments, type, index}` objects in the order the model emitted them. Combine with `jsonPath` (for example `$[*].name`) to select parts of each call.<br/>
        /// - `expected_output`: the experiment item's expected output. Only valid for `target=experiment`.<br/>
        /// - `experiment_item_metadata`: the experiment item's metadata object. Only valid for `target=experiment`.
        /// </param>
        /// <param name="jsonPath">
        /// Optional JSONPath selector applied to the selected source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstablePromptVariableMappingRead(
            string variable,
            global::Langfuse.UnstablePromptVariableMappingSource source,
            string? jsonPath)
        {
            this.Variable = variable ?? throw new global::System.ArgumentNullException(nameof(variable));
            this.Source = source;
            this.JsonPath = jsonPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePromptVariableMappingRead" /> class.
        /// </summary>
        public UnstablePromptVariableMappingRead()
        {
        }

    }
}