
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorOutputDefinitionBase
    {
        /// <summary>
        /// Optional instructions for deriving the reasoning returned with the score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoreReasoningInstructions")]
        public string? ScoreReasoningInstructions { get; set; }

        /// <summary>
        /// Optional instructions for deriving the score value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoreValueInstructions")]
        public string? ScoreValueInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorOutputDefinitionBase" /> class.
        /// </summary>
        /// <param name="scoreReasoningInstructions">
        /// Optional instructions for deriving the reasoning returned with the score.
        /// </param>
        /// <param name="scoreValueInstructions">
        /// Optional instructions for deriving the score value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorOutputDefinitionBase(
            string? scoreReasoningInstructions,
            string? scoreValueInstructions)
        {
            this.ScoreReasoningInstructions = scoreReasoningInstructions;
            this.ScoreValueInstructions = scoreValueInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorOutputDefinitionBase" /> class.
        /// </summary>
        public EvaluatorOutputDefinitionBase()
        {
        }

    }
}