#nullable enable

namespace Langfuse
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// **Deprecated.** Use `GET /api/public/v3/scores` with the `id` filter<br/>
        /// instead. This endpoint is no longer available on Langfuse v4 and later.<br/>
        /// Get a score (supports both trace and session scores)
        /// </summary>
        /// <param name="scoreId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.Score> ScoresGetByIdAsync(
            string scoreId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// **Deprecated.** Use `GET /api/public/v3/scores` with the `id` filter<br/>
        /// instead. This endpoint is no longer available on Langfuse v4 and later.<br/>
        /// Get a score (supports both trace and session scores)
        /// </summary>
        /// <param name="scoreId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.Score>> ScoresGetByIdAsResponseAsync(
            string scoreId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}