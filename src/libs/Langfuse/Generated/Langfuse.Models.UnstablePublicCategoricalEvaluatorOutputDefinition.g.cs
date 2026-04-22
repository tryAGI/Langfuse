
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstablePublicCategoricalEvaluatorOutputDefinition
    {
        /// <summary>
        /// Structured score type returned by an evaluator.<br/>
        /// This controls the type of score value Langfuse stores for evaluation results:<br/>
        /// - `NUMERIC`: a numeric score such as `0.82`<br/>
        /// - `BOOLEAN`: a boolean score such as `true`<br/>
        /// - `CATEGORICAL`: one or more category labels from a fixed list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluatorOutputDataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluatorOutputDataType DataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluatorOutputFieldDefinition Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstablePublicCategoricalEvaluatorOutputScoreDefinition Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicCategoricalEvaluatorOutputDefinition" /> class.
        /// </summary>
        /// <param name="dataType">
        /// Structured score type returned by an evaluator.<br/>
        /// This controls the type of score value Langfuse stores for evaluation results:<br/>
        /// - `NUMERIC`: a numeric score such as `0.82`<br/>
        /// - `BOOLEAN`: a boolean score such as `true`<br/>
        /// - `CATEGORICAL`: one or more category labels from a fixed list
        /// </param>
        /// <param name="reasoning"></param>
        /// <param name="score"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstablePublicCategoricalEvaluatorOutputDefinition(
            global::Langfuse.UnstableEvaluatorOutputDataType dataType,
            global::Langfuse.UnstableEvaluatorOutputFieldDefinition reasoning,
            global::Langfuse.UnstablePublicCategoricalEvaluatorOutputScoreDefinition score)
        {
            this.DataType = dataType;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.Score = score ?? throw new global::System.ArgumentNullException(nameof(score));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicCategoricalEvaluatorOutputDefinition" /> class.
        /// </summary>
        public UnstablePublicCategoricalEvaluatorOutputDefinition()
        {
        }
    }
}