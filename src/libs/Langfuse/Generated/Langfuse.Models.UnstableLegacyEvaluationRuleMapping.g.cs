
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Maps one evaluator variable to a trace, dataset item, or field on a named observation in a legacy rule.
    /// </summary>
    public sealed partial class UnstableLegacyEvaluationRuleMapping
    {
        /// <summary>
        /// Evaluator prompt variable populated by this mapping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langfuseObject")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableLegacyEvaluationObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableLegacyEvaluationObject LangfuseObject { get; set; }

        /// <summary>
        /// Observation name to match, or `null` when `langfuseObject` is `trace` or `dataset_item`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectName")]
        public string? ObjectName { get; set; }

        /// <summary>
        /// Stored field selected from the trace, dataset item, or observation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Optional JSONPath selector applied to the selected field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jsonPath")]
        public string? JsonPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableLegacyEvaluationRuleMapping" /> class.
        /// </summary>
        /// <param name="variable">
        /// Evaluator prompt variable populated by this mapping.
        /// </param>
        /// <param name="langfuseObject"></param>
        /// <param name="source">
        /// Stored field selected from the trace, dataset item, or observation.
        /// </param>
        /// <param name="objectName">
        /// Observation name to match, or `null` when `langfuseObject` is `trace` or `dataset_item`.
        /// </param>
        /// <param name="jsonPath">
        /// Optional JSONPath selector applied to the selected field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableLegacyEvaluationRuleMapping(
            string variable,
            global::Langfuse.UnstableLegacyEvaluationObject langfuseObject,
            string source,
            string? objectName,
            string? jsonPath)
        {
            this.Variable = variable ?? throw new global::System.ArgumentNullException(nameof(variable));
            this.LangfuseObject = langfuseObject;
            this.ObjectName = objectName;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.JsonPath = jsonPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableLegacyEvaluationRuleMapping" /> class.
        /// </summary>
        public UnstableLegacyEvaluationRuleMapping()
        {
        }

    }
}