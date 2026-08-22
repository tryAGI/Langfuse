
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Maps an evaluator variable to target data, as returned by read endpoints.<br/>
    /// Reads are more permissive than writes in two ways, so that data configured before a<br/>
    /// migration stays readable and repairable:<br/>
    /// - `source` is `null` when a mapping was never fully configured. Set a concrete `source` to fix it.<br/>
    /// - every `source` value is allowed regardless of the rule `target`, because an evaluator's<br/>
    ///   default mapping is stored independently of the rules that use it.<br/>
    /// Requests always require a concrete `source` that is valid for the selected `target`.
    /// </summary>
    public sealed partial class UnstableEvaluationRuleReadMapping
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleMappingSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleMappingSource Source { get; set; }

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
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleReadMapping" /> class.
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
        public UnstableEvaluationRuleReadMapping(
            string variable,
            global::Langfuse.UnstableEvaluationRuleMappingSource source,
            string? jsonPath)
        {
            this.Variable = variable ?? throw new global::System.ArgumentNullException(nameof(variable));
            this.Source = source;
            this.JsonPath = jsonPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleReadMapping" /> class.
        /// </summary>
        public UnstableEvaluationRuleReadMapping()
        {
        }

    }
}