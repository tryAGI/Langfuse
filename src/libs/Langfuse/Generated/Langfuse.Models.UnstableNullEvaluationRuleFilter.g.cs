
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableNullEvaluationRuleFilter
    {
        /// <summary>
        /// Column to filter on. In the unstable public API this is currently `parentObservationId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluationRuleNullFilterOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UnstableEvaluationRuleNullFilterOperator Operator { get; set; }

        /// <summary>
        /// Ignored placeholder value. Clients may omit it or send an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableNullEvaluationRuleFilter" /> class.
        /// </summary>
        /// <param name="column">
        /// Column to filter on. In the unstable public API this is currently `parentObservationId`.
        /// </param>
        /// <param name="operator"></param>
        /// <param name="value">
        /// Ignored placeholder value. Clients may omit it or send an empty string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableNullEvaluationRuleFilter(
            string column,
            global::Langfuse.UnstableEvaluationRuleNullFilterOperator @operator,
            string? value)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableNullEvaluationRuleFilter" /> class.
        /// </summary>
        public UnstableNullEvaluationRuleFilter()
        {
        }
    }
}