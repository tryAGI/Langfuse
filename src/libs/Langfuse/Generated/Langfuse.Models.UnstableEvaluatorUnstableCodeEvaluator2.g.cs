
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableEvaluatorUnstableCodeEvaluator2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluatorUnstableCodeEvaluatorTypeJsonConverter))]
        public global::Langfuse.UnstableEvaluatorUnstableCodeEvaluatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluatorUnstableCodeEvaluator2" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluatorUnstableCodeEvaluator2(
            global::Langfuse.UnstableEvaluatorUnstableCodeEvaluatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluatorUnstableCodeEvaluator2" /> class.
        /// </summary>
        public UnstableEvaluatorUnstableCodeEvaluator2()
        {
        }

    }
}