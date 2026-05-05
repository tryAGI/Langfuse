#nullable enable

namespace Langfuse
{
    public partial interface ILlmConnectionsClient
    {
        /// <summary>
        /// Create or update an LLM connection. The connection is upserted on provider.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.LlmConnection> LlmConnectionsUpsertAsync(

            global::Langfuse.UpsertLlmConnectionRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update an LLM connection. The connection is upserted on provider.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.LlmConnection>> LlmConnectionsUpsertAsResponseAsync(

            global::Langfuse.UpsertLlmConnectionRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update an LLM connection. The connection is upserted on provider.
        /// </summary>
        /// <param name="provider">
        /// Provider name (e.g., 'openai', 'my-gateway'). Must be unique in project, used for upserting.
        /// </param>
        /// <param name="adapter"></param>
        /// <param name="secretKey">
        /// Secret key for the LLM API.
        /// </param>
        /// <param name="baseURL">
        /// Custom base URL for the LLM API
        /// </param>
        /// <param name="customModels">
        /// List of custom model names
        /// </param>
        /// <param name="withDefaultModels">
        /// Whether to include default models. Default is true.
        /// </param>
        /// <param name="extraHeaders">
        /// Extra headers to send with requests
        /// </param>
        /// <param name="config">
        /// Adapter-specific configuration. Validation rules: - **Bedrock**: Required. Must be `{"region": "&lt;aws-region&gt;"}` (e.g., `{"region":"us-east-1"}`) - **VertexAI**: Optional. If provided, must be `{"location": "&lt;gcp-location&gt;"}` (e.g., `{"location":"us-central1"}`) - **Other adapters**: Not supported. Omit this field or set to null.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.LlmConnection> LlmConnectionsUpsertAsync(
            string provider,
            global::Langfuse.LlmAdapter adapter,
            string secretKey,
            string? baseURL = default,
            global::System.Collections.Generic.IList<string>? customModels = default,
            bool? withDefaultModels = default,
            global::System.Collections.Generic.Dictionary<string, string>? extraHeaders = default,
            object? config = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}