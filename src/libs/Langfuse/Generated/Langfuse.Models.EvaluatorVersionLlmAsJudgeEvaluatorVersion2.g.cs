
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorVersionLlmAsJudgeEvaluatorVersion2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.EvaluatorVersionLlmAsJudgeEvaluatorVersionTypeJsonConverter))]
        public global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorVersionLlmAsJudgeEvaluatorVersion2" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorVersionLlmAsJudgeEvaluatorVersion2(
            global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorVersionLlmAsJudgeEvaluatorVersion2" /> class.
        /// </summary>
        public EvaluatorVersionLlmAsJudgeEvaluatorVersion2()
        {
        }

    }
}