
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Paginated list of evaluation rules.
    /// </summary>
    public sealed partial class UnstableEvaluationRules
    {
        /// <summary>
        /// Evaluation rules in the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableReadableEvaluationRule> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.UtilsMetaResponse Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRules" /> class.
        /// </summary>
        /// <param name="data">
        /// Evaluation rules in the current page.
        /// </param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluationRules(
            global::System.Collections.Generic.IList<global::Langfuse.UnstableReadableEvaluationRule> data,
            global::Langfuse.UtilsMetaResponse meta)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluationRules" /> class.
        /// </summary>
        public UnstableEvaluationRules()
        {
        }

    }
}