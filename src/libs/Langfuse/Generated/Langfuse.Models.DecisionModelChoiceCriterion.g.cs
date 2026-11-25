
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One allowed answer of a `choice` question.
    /// </summary>
    public sealed partial class DecisionModelChoiceCriterion
    {
        /// <summary>
        /// Answer value stored as the categorical score value. Must be unique within the question.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Instruction text (1 to 20,000 characters), or a non-null JSON value that the decision model receives as structured instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.DecisionModelEntryJsonConverter))]
        public global::Langfuse.DecisionModelEntry? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelChoiceCriterion" /> class.
        /// </summary>
        /// <param name="value">
        /// Answer value stored as the categorical score value. Must be unique within the question.
        /// </param>
        /// <param name="description">
        /// Instruction text (1 to 20,000 characters), or a non-null JSON value that the decision model receives as structured instructions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionModelChoiceCriterion(
            string value,
            global::Langfuse.DecisionModelEntry? description)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelChoiceCriterion" /> class.
        /// </summary>
        public DecisionModelChoiceCriterion()
        {
        }

    }
}