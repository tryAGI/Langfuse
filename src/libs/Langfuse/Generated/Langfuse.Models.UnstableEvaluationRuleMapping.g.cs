
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Maps one evaluator prompt variable to one source field from the target object.<br/>
    /// How to build a valid mapping list:<br/>
    /// 1. Create the evaluator or fetch it with `GET /evaluators/{id}`.<br/>
    /// 2. Read the evaluator `variables` array.<br/>
    /// 3. Add exactly one mapping object for each variable in that array.<br/>
    /// 4. Use the variable name exactly as returned, without braces such as `{{` or `}}`.<br/>
    /// 5. Choose a `source` that is valid for the selected `target`.<br/>
    /// `jsonPath` is optional. Use it only when the selected source is a JSON object and you want to extract one nested field before inserting it into the evaluator prompt.<br/>
    /// Recovery guidance:<br/>
    /// - `invalid_variable_mapping`: the variable name is unknown for this evaluator, or the selected `source` is not valid for the chosen `target`<br/>
    /// - `missing_variable_mapping`: one or more evaluator variables are not mapped yet<br/>
    /// - `duplicate_variable_mapping`: the same evaluator variable appears more than once<br/>
    /// - `invalid_json_path`: the JSONPath expression is malformed. Remove it or correct it.
    /// </summary>
    public sealed partial class UnstableEvaluationRuleMapping
    {
        /// <summary>
        /// Prompt variable name without braces.<br/>
        /// Example: for the prompt `Judge {{input}} against {{output}}`, use `input` and `output`.<br/>
        /// Example: input
        /// </summary>
        /// <example>input</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variable { get; set; }

        /// <summary>
        /// Source field used to populate a prompt variable.<br/>
        /// Use these values when mapping evaluator prompt variables to live data.<br/>
        /// Target-specific rules:<br/>
        /// - `target=observation` supports `input`, `output`, and `metadata`<br/>
        /// - `target=experiment` supports `input`, `output`, `metadata`, `expected_output`, and `experiment_item_metadata`<br/>
        /// Source semantics:<br/>
        /// - `input`: the observation or experiment input payload<br/>
        /// - `output`: the observation or experiment output payload<br/>
        /// - `metadata`: the metadata object for the target. Combine with `jsonPath` when you need one nested field instead of the whole object.<br/>
        /// - `expected_output`: the experiment item's expected output. Only valid for `target=experiment`.<br/>
        /// - `experiment_item_metadata`: the experiment item's metadata object. Only valid for `target=experiment`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleMappingSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleMappingSource Source { get; set; }

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
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleMapping" /> class.
        /// </summary>
        /// <param name="variable">
        /// Prompt variable name without braces.<br/>
        /// Example: for the prompt `Judge {{input}} against {{output}}`, use `input` and `output`.<br/>
        /// Example: input
        /// </param>
        /// <param name="source">
        /// Source field used to populate a prompt variable.<br/>
        /// Use these values when mapping evaluator prompt variables to live data.<br/>
        /// Target-specific rules:<br/>
        /// - `target=observation` supports `input`, `output`, and `metadata`<br/>
        /// - `target=experiment` supports `input`, `output`, `metadata`, `expected_output`, and `experiment_item_metadata`<br/>
        /// Source semantics:<br/>
        /// - `input`: the observation or experiment input payload<br/>
        /// - `output`: the observation or experiment output payload<br/>
        /// - `metadata`: the metadata object for the target. Combine with `jsonPath` when you need one nested field instead of the whole object.<br/>
        /// - `expected_output`: the experiment item's expected output. Only valid for `target=experiment`.<br/>
        /// - `experiment_item_metadata`: the experiment item's metadata object. Only valid for `target=experiment`.
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
        public UnstableEvaluationRuleMapping(
            string variable,
            global::Langfuse.UnstableEvaluationRuleMappingSource source,
            string? jsonPath)
        {
            this.Variable = variable ?? throw new global::System.ArgumentNullException(nameof(variable));
            this.Source = source;
            this.JsonPath = jsonPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRuleMapping" /> class.
        /// </summary>
        public UnstableEvaluationRuleMapping()
        {
        }

    }
}