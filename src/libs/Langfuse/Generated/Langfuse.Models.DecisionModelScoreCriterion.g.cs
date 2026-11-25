
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One level of a `score` question, ordered from lowest to highest.
    /// </summary>
    public sealed partial class DecisionModelScoreCriterion
    {
        /// <summary>
        /// Instruction text (1 to 20,000 characters), or a non-null JSON value that the decision model receives as structured instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.DecisionModelEntryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.DecisionModelEntry Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelScoreCriterion" /> class.
        /// </summary>
        /// <param name="description">
        /// Instruction text (1 to 20,000 characters), or a non-null JSON value that the decision model receives as structured instructions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionModelScoreCriterion(
            global::Langfuse.DecisionModelEntry description)
        {
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelScoreCriterion" /> class.
        /// </summary>
        public DecisionModelScoreCriterion()
        {
        }

    }
}