
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataTypeJsonConverter))]
        public global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2" /> class.
        /// </summary>
        /// <param name="dataType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2(
            global::Langfuse.UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinitionDataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2" /> class.
        /// </summary>
        public UnstablePublicEvaluatorOutputDefinitionUnstablePublicCategoricalEvaluatorOutputDefinition2()
        {
        }

    }
}