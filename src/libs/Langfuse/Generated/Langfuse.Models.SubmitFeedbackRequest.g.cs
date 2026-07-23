
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitFeedbackRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.FeedbackTargetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.FeedbackTargetType TargetType { get; set; }

        /// <summary>
        /// The specific instance within targetType: the skill name, MCP tool name, CLI command, API endpoint path, or docs page path (e.g. 'queryMetrics', '/docs/mcp'). An identifier, not a sentence. Must be between 1 and 200 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Concise feedback text approved by the user. Must be between 1 and 3000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Feedback { get; set; }

        /// <summary>
        /// Optional user-approved goal or use case they were trying to achieve. Must be between 1 and 1500 characters when provided. Do not include secrets, customer data, trace payloads, or broad unrelated context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        public string? Goal { get; set; }

        /// <summary>
        /// Optional HTTP(S) reference URL. Langfuse stores it as text for triage and does not fetch it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceUrl")]
        public string? ReferenceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitFeedbackRequest" /> class.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="target">
        /// The specific instance within targetType: the skill name, MCP tool name, CLI command, API endpoint path, or docs page path (e.g. 'queryMetrics', '/docs/mcp'). An identifier, not a sentence. Must be between 1 and 200 characters.
        /// </param>
        /// <param name="feedback">
        /// Concise feedback text approved by the user. Must be between 1 and 3000 characters.
        /// </param>
        /// <param name="goal">
        /// Optional user-approved goal or use case they were trying to achieve. Must be between 1 and 1500 characters when provided. Do not include secrets, customer data, trace payloads, or broad unrelated context.
        /// </param>
        /// <param name="referenceUrl">
        /// Optional HTTP(S) reference URL. Langfuse stores it as text for triage and does not fetch it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitFeedbackRequest(
            global::Langfuse.FeedbackTargetType targetType,
            string target,
            string feedback,
            string? goal,
            string? referenceUrl)
        {
            this.TargetType = targetType;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
            this.Goal = goal;
            this.ReferenceUrl = referenceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitFeedbackRequest" /> class.
        /// </summary>
        public SubmitFeedbackRequest()
        {
        }

    }
}