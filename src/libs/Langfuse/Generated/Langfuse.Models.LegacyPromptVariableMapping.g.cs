
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// **Deprecated:** Connects one prompt variable to data from a legacy trace or dataset evaluation rule.<br/>
    /// `langfuseObject` selects the object kind. `objectName` separately selects a named observation and is `null` for trace and dataset-item mappings.
    /// </summary>
    public sealed partial class LegacyPromptVariableMapping
    {
        /// <summary>
        /// Explicitly marks this as a legacy mapping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mappingType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MappingType { get; set; }

        /// <summary>
        /// Prompt variable name without braces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variable { get; set; }

        /// <summary>
        /// **Deprecated:** Legacy Langfuse object kind used by trace and dataset evaluation rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langfuseObject")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.LegacyEvaluationObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.LegacyEvaluationObject LangfuseObject { get; set; }

        /// <summary>
        /// Observation name to match, or `null` when `langfuseObject` is `trace` or `dataset_item`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectName")]
        public string? ObjectName { get; set; }

        /// <summary>
        /// Field selected from the legacy object.
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
        /// Initializes a new instance of the <see cref="LegacyPromptVariableMapping" /> class.
        /// </summary>
        /// <param name="mappingType">
        /// Explicitly marks this as a legacy mapping.
        /// </param>
        /// <param name="variable">
        /// Prompt variable name without braces.
        /// </param>
        /// <param name="langfuseObject">
        /// **Deprecated:** Legacy Langfuse object kind used by trace and dataset evaluation rules.
        /// </param>
        /// <param name="source">
        /// Field selected from the legacy object.
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
        public LegacyPromptVariableMapping(
            string mappingType,
            string variable,
            global::Langfuse.LegacyEvaluationObject langfuseObject,
            string source,
            string? objectName,
            string? jsonPath)
        {
            this.MappingType = mappingType ?? throw new global::System.ArgumentNullException(nameof(mappingType));
            this.Variable = variable ?? throw new global::System.ArgumentNullException(nameof(variable));
            this.LangfuseObject = langfuseObject;
            this.ObjectName = objectName;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.JsonPath = jsonPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyPromptVariableMapping" /> class.
        /// </summary>
        public LegacyPromptVariableMapping()
        {
        }

    }
}