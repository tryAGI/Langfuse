
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableNumberEvaluationRuleFilter
    {
        /// <summary>
        /// Column to filter on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleNumberFilterOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleNumberFilterOperator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableNumberEvaluationRuleFilter" /> class.
        /// </summary>
        /// <param name="column">
        /// Column to filter on.
        /// </param>
        /// <param name="operator"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableNumberEvaluationRuleFilter(
            string column,
            global::Langfuse.UnstableEvaluationRuleNumberFilterOperator @operator,
            double value)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableNumberEvaluationRuleFilter" /> class.
        /// </summary>
        public UnstableNumberEvaluationRuleFilter()
        {
        }
    }
}