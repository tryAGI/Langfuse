
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One chat message in an evaluator prompt.
    /// </summary>
    public sealed partial class EvaluatorChatMessage
    {
        /// <summary>
        /// Role of an evaluator prompt message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.EvaluatorChatMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.EvaluatorChatMessageRole Role { get; set; }

        /// <summary>
        /// Message content. Evaluator variables use `{{variable}}` syntax.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorChatMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// Role of an evaluator prompt message.
        /// </param>
        /// <param name="content">
        /// Message content. Evaluator variables use `{{variable}}` syntax.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorChatMessage(
            global::Langfuse.EvaluatorChatMessageRole role,
            string content)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorChatMessage" /> class.
        /// </summary>
        public EvaluatorChatMessage()
        {
        }

    }
}