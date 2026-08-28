
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Connects one prompt variable to data from an observation or experiment.<br/>
    /// Manual mappings are used for `llm_as_judge` evaluators. `code` evaluators use a fixed runtime mapping managed by Langfuse.<br/>
    /// How to build a valid mapping list:<br/>
    /// 1. Create the evaluator or fetch it with `GET /evaluators/{id}`.<br/>
    /// 2. Read the evaluator `variables` array.<br/>
    /// 3. Add exactly one mapping object for each variable in that array.<br/>
    /// 4. Use the variable name exactly as returned, without braces such as `{{` or `}}`.<br/>
    /// 5. Choose the source field that should populate the variable.<br/>
    /// `jsonPath` is optional. Use it only when the selected source is a JSON object and you want to extract one nested field before inserting it into the evaluator prompt.<br/>
    /// Invalid, missing, or duplicate mappings return a validation error. Malformed JSONPath expressions are also rejected.
    /// </summary>
    public sealed partial class PromptVariableMappingInput
    {
        /// <summary>
        /// Prompt variable name without braces.<br/>
        /// Example: for the prompt `Judge {{input}} against {{output}}`, use `input` and `output`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variable { get; set; }

        /// <summary>
        /// Source field used to populate a prompt variable.<br/>
        /// Use these values when mapping evaluator prompt variables to live data.<br/>
        /// Source semantics:<br/>
        /// - `input`: the observation input payload<br/>
        /// - `output`: the observation output payload<br/>
        /// - `metadata`: the observation metadata object. Combine with `jsonPath` when you need one nested field instead of the whole object.<br/>
        /// - `tool_calls`: the tool calls recorded on the observation, as an array of `{id, name, arguments, type, index}` objects in the order the model emitted them. Combine with `jsonPath` (for example `$[*].name`) to select parts of each call.<br/>
        /// - `expected_output`: the experiment item's expected output when the observation belongs to an experiment.<br/>
        /// - `experiment_item_metadata`: the experiment item's metadata when the observation belongs to an experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.PromptVariableMappingSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.PromptVariableMappingSource Source { get; set; }

        /// <summary>
        /// Optional JSONPath selector applied to the selected source before it is passed to the evaluator prompt.<br/>
        /// Requirements:<br/>
        /// - Must start with `$`<br/>
        /// - Must be a syntactically valid JSONPath expression<br/>
        /// - Most useful with `source=metadata`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jsonPath")]
        public string? JsonPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVariableMappingInput" /> class.
        /// </summary>
        /// <param name="variable">
        /// Prompt variable name without braces.<br/>
        /// Example: for the prompt `Judge {{input}} against {{output}}`, use `input` and `output`.
        /// </param>
        /// <param name="source">
        /// Source field used to populate a prompt variable.<br/>
        /// Use these values when mapping evaluator prompt variables to live data.<br/>
        /// Source semantics:<br/>
        /// - `input`: the observation input payload<br/>
        /// - `output`: the observation output payload<br/>
        /// - `metadata`: the observation metadata object. Combine with `jsonPath` when you need one nested field instead of the whole object.<br/>
        /// - `tool_calls`: the tool calls recorded on the observation, as an array of `{id, name, arguments, type, index}` objects in the order the model emitted them. Combine with `jsonPath` (for example `$[*].name`) to select parts of each call.<br/>
        /// - `expected_output`: the experiment item's expected output when the observation belongs to an experiment.<br/>
        /// - `experiment_item_metadata`: the experiment item's metadata when the observation belongs to an experiment.
        /// </param>
        /// <param name="jsonPath">
        /// Optional JSONPath selector applied to the selected source before it is passed to the evaluator prompt.<br/>
        /// Requirements:<br/>
        /// - Must start with `$`<br/>
        /// - Must be a syntactically valid JSONPath expression<br/>
        /// - Most useful with `source=metadata`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVariableMappingInput(
            string variable,
            global::Langfuse.PromptVariableMappingSource source,
            string? jsonPath)
        {
            this.Variable = variable ?? throw new global::System.ArgumentNullException(nameof(variable));
            this.Source = source;
            this.JsonPath = jsonPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVariableMappingInput" /> class.
        /// </summary>
        public PromptVariableMappingInput()
        {
        }

    }
}