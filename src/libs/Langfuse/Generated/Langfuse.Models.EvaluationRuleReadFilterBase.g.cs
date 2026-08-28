
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Stored filter returned verbatim by evaluation-rule read endpoints.
    /// </summary>
    public sealed partial class EvaluationRuleReadFilterBase
    {
        /// <summary>
        /// Stored filter type. This is not broken down into separate public response types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// Stored filter value. Its shape depends on the filter type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRuleReadFilterBase" /> class.
        /// </summary>
        /// <param name="type">
        /// Stored filter type. This is not broken down into separate public response types.
        /// </param>
        /// <param name="column"></param>
        /// <param name="operator"></param>
        /// <param name="value">
        /// Stored filter value. Its shape depends on the filter type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationRuleReadFilterBase(
            string type,
            string column,
            string @operator,
            object? value)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRuleReadFilterBase" /> class.
        /// </summary>
        public EvaluationRuleReadFilterBase()
        {
        }

    }
}