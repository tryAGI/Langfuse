
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Confirmation returned after successful evaluation-rule deletion.
    /// </summary>
    public sealed partial class DeletedEvaluationRule
    {
        /// <summary>
        /// Identifier of the deleted evaluation rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedEvaluationRule" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the deleted evaluation rule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedEvaluationRule(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedEvaluationRule" /> class.
        /// </summary>
        public DeletedEvaluationRule()
        {
        }

    }
}