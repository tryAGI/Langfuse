
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// **Deprecated:** Connects one prompt variable to data from a trace, dataset item, or named observation in a legacy rule.
    /// </summary>
    public sealed partial class UnstableLegacyPromptVariableMapping
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variable { get; set; }

        /// <summary>
        /// **Deprecated:** Legacy Langfuse object used by a trace or dataset evaluation rule.
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jsonPath")]
        public string? JsonPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableLegacyPromptVariableMapping" /> class.
        /// </summary>
        /// <param name="variable"></param>
        /// <param name="langfuseObject">
        /// **Deprecated:** Legacy Langfuse object used by a trace or dataset evaluation rule.
        /// </param>
        /// <param name="source"></param>
        /// <param name="objectName">
        /// Observation name to match, or `null` when `langfuseObject` is `trace` or `dataset_item`.
        /// </param>
        /// <param name="jsonPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableLegacyPromptVariableMapping(
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
        /// Initializes a new instance of the <see cref="UnstableLegacyPromptVariableMapping" /> class.
        /// </summary>
        public UnstableLegacyPromptVariableMapping()
        {
        }

    }
}