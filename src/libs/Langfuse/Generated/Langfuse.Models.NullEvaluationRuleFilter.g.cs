
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NullEvaluationRuleFilter
    {
        /// <summary>
        /// Column to filter on, for example `parentObservationId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.EvaluationRuleNullFilterOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.EvaluationRuleNullFilterOperator Operator { get; set; }

        /// <summary>
        /// Required empty-string placeholder used by the runtime filter contract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullEvaluationRuleFilter" /> class.
        /// </summary>
        /// <param name="column">
        /// Column to filter on, for example `parentObservationId`.
        /// </param>
        /// <param name="operator"></param>
        /// <param name="value">
        /// Required empty-string placeholder used by the runtime filter contract.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NullEvaluationRuleFilter(
            string column,
            global::Langfuse.EvaluationRuleNullFilterOperator @operator,
            string value)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullEvaluationRuleFilter" /> class.
        /// </summary>
        public NullEvaluationRuleFilter()
        {
        }

    }
}