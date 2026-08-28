
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorVersionsPage
    {
        /// <summary>
        /// Evaluator versions for this page in newest-first order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.EvaluatorVersion> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.CursorMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorVersionsPage" /> class.
        /// </summary>
        /// <param name="data">
        /// Evaluator versions for this page in newest-first order.
        /// </param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorVersionsPage(
            global::System.Collections.Generic.IList<global::Langfuse.EvaluatorVersion> data,
            global::Langfuse.CursorMeta meta)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorVersionsPage" /> class.
        /// </summary>
        public EvaluatorVersionsPage()
        {
        }

    }
}