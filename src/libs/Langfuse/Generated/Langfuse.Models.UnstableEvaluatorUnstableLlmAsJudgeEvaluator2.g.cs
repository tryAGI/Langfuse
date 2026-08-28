
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableEvaluatorUnstableLlmAsJudgeEvaluator2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.UnstableEvaluatorUnstableLlmAsJudgeEvaluatorTypeJsonConverter))]
        public global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluatorUnstableLlmAsJudgeEvaluator2" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableEvaluatorUnstableLlmAsJudgeEvaluator2(
            global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableEvaluatorUnstableLlmAsJudgeEvaluator2" /> class.
        /// </summary>
        public UnstableEvaluatorUnstableLlmAsJudgeEvaluator2()
        {
        }

    }
}