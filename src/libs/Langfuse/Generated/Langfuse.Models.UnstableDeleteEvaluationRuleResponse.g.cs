
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Confirmation response returned after successful deletion.
    /// </summary>
    public sealed partial class UnstableDeleteEvaluationRuleResponse
    {
        /// <summary>
        /// Always `Evaluation rule successfully deleted`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDeleteEvaluationRuleResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Always `Evaluation rule successfully deleted`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableDeleteEvaluationRuleResponse(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDeleteEvaluationRuleResponse" /> class.
        /// </summary>
        public UnstableDeleteEvaluationRuleResponse()
        {
        }
    }
}