
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Pick one of a fixed list of options. Produces a categorical score.
    /// </summary>
    public sealed partial class DecisionModelChoiceQuestion
    {
        /// <summary>
        /// Question identifier. Must be unique within the evaluator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the score this question produces. Must be unique within the evaluator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoreName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScoreName { get; set; }

        /// <summary>
        /// Instruction text (1 to 20,000 characters), or a non-null JSON value that the decision model receives as structured instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.DecisionModelEntryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.DecisionModelEntry Instructions { get; set; }

        /// <summary>
        /// The allowed answers. Between 2 and 255, with unique values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.DecisionModelChoiceCriterion> Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelChoiceQuestion" /> class.
        /// </summary>
        /// <param name="id">
        /// Question identifier. Must be unique within the evaluator.
        /// </param>
        /// <param name="scoreName">
        /// Name of the score this question produces. Must be unique within the evaluator.
        /// </param>
        /// <param name="instructions">
        /// Instruction text (1 to 20,000 characters), or a non-null JSON value that the decision model receives as structured instructions.
        /// </param>
        /// <param name="criteria">
        /// The allowed answers. Between 2 and 255, with unique values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionModelChoiceQuestion(
            string id,
            string scoreName,
            global::Langfuse.DecisionModelEntry instructions,
            global::System.Collections.Generic.IList<global::Langfuse.DecisionModelChoiceCriterion> criteria)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ScoreName = scoreName ?? throw new global::System.ArgumentNullException(nameof(scoreName));
            this.Instructions = instructions;
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelChoiceQuestion" /> class.
        /// </summary>
        public DecisionModelChoiceQuestion()
        {
        }

    }
}