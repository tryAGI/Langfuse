
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Optional descriptions of the two answers of a `boolean` question. The answer is always `true` or `false`; these descriptions only tell the model when each one applies.
    /// </summary>
    public sealed partial class DecisionModelBooleanCriteria
    {
        /// <summary>
        /// One answer of a `boolean` question.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("true")]
        public global::Langfuse.DecisionModelBooleanCriterion? True { get; set; }

        /// <summary>
        /// One answer of a `boolean` question.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("false")]
        public global::Langfuse.DecisionModelBooleanCriterion? False { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelBooleanCriteria" /> class.
        /// </summary>
        /// <param name="true">
        /// One answer of a `boolean` question.
        /// </param>
        /// <param name="false">
        /// One answer of a `boolean` question.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionModelBooleanCriteria(
            global::Langfuse.DecisionModelBooleanCriterion? @true,
            global::Langfuse.DecisionModelBooleanCriterion? @false)
        {
            this.True = @true;
            this.False = @false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelBooleanCriteria" /> class.
        /// </summary>
        public DecisionModelBooleanCriteria()
        {
        }

    }
}