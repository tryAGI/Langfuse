
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StringOptionsEvaluationRuleFilter
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.EvaluationRuleOptionsFilterOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.EvaluationRuleOptionsFilterOperator Operator { get; set; }

        /// <summary>
        /// One or more allowed string values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StringOptionsEvaluationRuleFilter" /> class.
        /// </summary>
        /// <param name="column">
        /// Column to filter on.
        /// </param>
        /// <param name="operator"></param>
        /// <param name="value">
        /// One or more allowed string values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StringOptionsEvaluationRuleFilter(
            string column,
            global::Langfuse.EvaluationRuleOptionsFilterOperator @operator,
            global::System.Collections.Generic.IList<string> value)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringOptionsEvaluationRuleFilter" /> class.
        /// </summary>
        public StringOptionsEvaluationRuleFilter()
        {
        }

    }
}