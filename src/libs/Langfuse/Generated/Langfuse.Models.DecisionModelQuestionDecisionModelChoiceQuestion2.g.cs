
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionModelQuestionDecisionModelChoiceQuestion2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.DecisionModelQuestionDecisionModelChoiceQuestionTypeJsonConverter))]
        public global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestionType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelQuestionDecisionModelChoiceQuestion2" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionModelQuestionDecisionModelChoiceQuestion2(
            global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestionType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelQuestionDecisionModelChoiceQuestion2" /> class.
        /// </summary>
        public DecisionModelQuestionDecisionModelChoiceQuestion2()
        {
        }

    }
}