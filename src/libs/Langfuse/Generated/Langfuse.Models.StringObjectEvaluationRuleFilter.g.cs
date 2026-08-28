
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StringObjectEvaluationRuleFilter
    {
        /// <summary>
        /// Object-valued column to filter on. Currently only `metadata` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        /// Top-level key inside the object-valued column to filter on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.EvaluationRuleStringFilterOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.EvaluationRuleStringFilterOperator Operator { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="StringObjectEvaluationRuleFilter" /> class.
        /// </summary>
        /// <param name="column">
        /// Object-valued column to filter on. Currently only `metadata` is supported.
        /// </param>
        /// <param name="key">
        /// Top-level key inside the object-valued column to filter on.
        /// </param>
        /// <param name="operator"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StringObjectEvaluationRuleFilter(
            string column,
            string key,
            global::Langfuse.EvaluationRuleStringFilterOperator @operator,
            string value)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringObjectEvaluationRuleFilter" /> class.
        /// </summary>
        public StringObjectEvaluationRuleFilter()
        {
        }

    }
}