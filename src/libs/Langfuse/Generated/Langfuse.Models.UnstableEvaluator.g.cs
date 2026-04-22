
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One evaluator that can be used for scoring.<br/>
    /// An evaluator describes **how** to score data:<br/>
    /// - prompt<br/>
    /// - extracted prompt variables<br/>
    /// - output schema<br/>
    /// - optional explicit model configuration<br/>
    /// It does not define **which** live objects are evaluated. That is the job of `evaluation-rules`.<br/>
    /// For agent clients, the most important fields are:<br/>
    /// - `variables`: use these exact names when building the evaluation-rule `mapping` array<br/>
    /// - `outputDefinition`: tells you the expected score type and the evaluator's response instructions<br/>
    /// - `modelConfig`: tells you whether the evaluator uses the project default model (`null`) or an explicit provider/model<br/>
    /// Versioning behavior:<br/>
    /// - `GET /evaluators` returns the latest version of each available evaluator.<br/>
    /// - `GET /evaluators/{id}` can return an older version.<br/>
    /// - Evaluation rules always run against the latest version for the selected evaluator name within the same source (`project` or `managed`).
    /// </summary>
    public sealed partial class UnstableEvaluator
    {
        /// <summary>
        /// Identifier of this evaluator.<br/>
        /// Example: evaltmpl_123
        /// </summary>
        /// <example>evaltmpl_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Evaluator name.<br/>
        /// Example: answer-correctness
        /// </summary>
        /// <example>answer-correctness</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Version number of this evaluator.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Where an evaluator comes from.<br/>
        /// - `project`: created in your project<br/>
        /// - `managed`: provided by Langfuse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluatorScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluatorScope Scope { get; set; }

        /// <summary>
        /// The evaluator engine type.<br/>
        /// The unstable public API currently supports only LLM-as-a-judge evaluators.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluatorTypeJsonConverter))]
        public global::Langfuse.UnstableEvaluatorType Type { get; set; }

        /// <summary>
        /// Prompt template used during evaluation.<br/>
        /// Example: You are grading an answer.<br/>
        /// Input:<br/>
        /// {{input}}<br/>
        /// Output:<br/>
        /// {{output}}<br/>
        /// Return a score between 0 and 1.
        /// </summary>
        /// <example>
        /// You are grading an answer.<br/>
        /// Input:<br/>
        /// {{input}}<br/>
        /// Output:<br/>
        /// {{output}}<br/>
        /// Return a score between 0 and 1.
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Variables extracted from the evaluator prompt.<br/>
        /// Every variable in this list must be mapped exactly once when creating an evaluation rule.<br/>
        /// Example: [input, output]
        /// </summary>
        /// <example>[input, output]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Variables { get; set; }

        /// <summary>
        /// Evaluator output definition returned by the public API.<br/>
        /// This response always includes `dataType` and never includes an internal output-definition `version`.<br/>
        /// Legacy stored evaluator definitions are normalized into this shape before they are returned.<br/>
        /// Use this response shape when deciding how to interpret future evaluation scores:<br/>
        /// - `NUMERIC`: expect numeric score values<br/>
        /// - `BOOLEAN`: expect `true` / `false`<br/>
        /// - `CATEGORICAL`: expect one or more values from `score.categories`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDefinition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstablePublicEvaluatorOutputDefinition OutputDefinition { get; set; }

        /// <summary>
        /// Optional explicit model configuration for an evaluator.<br/>
        /// If omitted, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.<br/>
        /// To discover valid configured `provider` values for a project, call `GET /api/public/llm-connections` and read the `provider` field from the returned connections.<br/>
        /// Use a `provider` value that matches one of the connections already configured in the same project.<br/>
        /// Recovery guidance:<br/>
        /// - If evaluator creation returns `422` with `code=evaluator_preflight_failed`, either provide a valid explicit `modelConfig` here or configure the project's default evaluation model, then retry the same request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelConfig")]
        public global::Langfuse.UnstableEvaluatorModelConfig? ModelConfig { get; set; }

        /// <summary>
        /// Number of evaluation rules in the project that currently use this evaluator version.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluationRuleCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EvaluationRuleCount { get; set; }

        /// <summary>
        /// Timestamp when this evaluator was created.<br/>
        /// Example: 2026-03-30T09:00:00.000Z
        /// </summary>
        /// <example>2026-03-30T09:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when this evaluator was last updated.<br/>
        /// Example: 2026-03-30T09:00:00.000Z
        /// </summary>
        /// <example>2026-03-30T09:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluator" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of this evaluator.<br/>
        /// Example: evaltmpl_123
        /// </param>
        /// <param name="name">
        /// Evaluator name.<br/>
        /// Example: answer-correctness
        /// </param>
        /// <param name="version">
        /// Version number of this evaluator.<br/>
        /// Example: 2
        /// </param>
        /// <param name="scope">
        /// Where an evaluator comes from.<br/>
        /// - `project`: created in your project<br/>
        /// - `managed`: provided by Langfuse
        /// </param>
        /// <param name="prompt">
        /// Prompt template used during evaluation.<br/>
        /// Example: You are grading an answer.<br/>
        /// Input:<br/>
        /// {{input}}<br/>
        /// Output:<br/>
        /// {{output}}<br/>
        /// Return a score between 0 and 1.
        /// </param>
        /// <param name="variables">
        /// Variables extracted from the evaluator prompt.<br/>
        /// Every variable in this list must be mapped exactly once when creating an evaluation rule.<br/>
        /// Example: [input, output]
        /// </param>
        /// <param name="outputDefinition">
        /// Evaluator output definition returned by the public API.<br/>
        /// This response always includes `dataType` and never includes an internal output-definition `version`.<br/>
        /// Legacy stored evaluator definitions are normalized into this shape before they are returned.<br/>
        /// Use this response shape when deciding how to interpret future evaluation scores:<br/>
        /// - `NUMERIC`: expect numeric score values<br/>
        /// - `BOOLEAN`: expect `true` / `false`<br/>
        /// - `CATEGORICAL`: expect one or more values from `score.categories`
        /// </param>
        /// <param name="evaluationRuleCount">
        /// Number of evaluation rules in the project that currently use this evaluator version.<br/>
        /// Example: 0
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when this evaluator was created.<br/>
        /// Example: 2026-03-30T09:00:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when this evaluator was last updated.<br/>
        /// Example: 2026-03-30T09:00:00.000Z
        /// </param>
        /// <param name="type">
        /// The evaluator engine type.<br/>
        /// The unstable public API currently supports only LLM-as-a-judge evaluators.
        /// </param>
        /// <param name="modelConfig">
        /// Optional explicit model configuration for an evaluator.<br/>
        /// If omitted, Langfuse uses the project's default evaluation model.<br/>
        /// If provided, the model must be available to the project when the evaluator or evaluation rule is enabled.<br/>
        /// To discover valid configured `provider` values for a project, call `GET /api/public/llm-connections` and read the `provider` field from the returned connections.<br/>
        /// Use a `provider` value that matches one of the connections already configured in the same project.<br/>
        /// Recovery guidance:<br/>
        /// - If evaluator creation returns `422` with `code=evaluator_preflight_failed`, either provide a valid explicit `modelConfig` here or configure the project's default evaluation model, then retry the same request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluator(
            string id,
            string name,
            int version,
            global::Langfuse.UnstableEvaluatorScope scope,
            string prompt,
            global::System.Collections.Generic.IList<string> variables,
            global::Langfuse.UnstablePublicEvaluatorOutputDefinition outputDefinition,
            int evaluationRuleCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Langfuse.UnstableEvaluatorType type,
            global::Langfuse.UnstableEvaluatorModelConfig? modelConfig)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
            this.Scope = scope;
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.OutputDefinition = outputDefinition;
            this.ModelConfig = modelConfig;
            this.EvaluationRuleCount = evaluationRuleCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluator" /> class.
        /// </summary>
        public UnstableEvaluator()
        {
        }
    }
}