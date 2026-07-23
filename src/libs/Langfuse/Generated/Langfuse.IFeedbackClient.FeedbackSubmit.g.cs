#nullable enable

namespace Langfuse
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Submit explicit user-approved feedback about Langfuse skills, MCP tools, CLI, docs, or public API. Do not include secrets, credentials, customer data, trace payloads, or unrelated use-case details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.SubmitFeedbackResponse> FeedbackSubmitAsync(

            global::Langfuse.SubmitFeedbackRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit explicit user-approved feedback about Langfuse skills, MCP tools, CLI, docs, or public API. Do not include secrets, credentials, customer data, trace payloads, or unrelated use-case details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.SubmitFeedbackResponse>> FeedbackSubmitAsResponseAsync(

            global::Langfuse.SubmitFeedbackRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit explicit user-approved feedback about Langfuse skills, MCP tools, CLI, docs, or public API. Do not include secrets, credentials, customer data, trace payloads, or unrelated use-case details.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.SubmitFeedbackResponse> FeedbackSubmitAsync(
            global::Langfuse.FeedbackTargetType targetType,
            string target,
            string feedback,
            string? goal = default,
            string? referenceUrl = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}