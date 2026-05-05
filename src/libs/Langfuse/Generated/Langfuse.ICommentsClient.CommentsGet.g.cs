#nullable enable

namespace Langfuse
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Get all comments
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="objectType"></param>
        /// <param name="objectId"></param>
        /// <param name="authorUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.GetCommentsResponse> CommentsGetAsync(
            int? page = default,
            int? limit = default,
            string? objectType = default,
            string? objectId = default,
            string? authorUserId = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all comments
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="objectType"></param>
        /// <param name="objectId"></param>
        /// <param name="authorUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.GetCommentsResponse>> CommentsGetAsResponseAsync(
            int? page = default,
            int? limit = default,
            string? objectType = default,
            string? objectId = default,
            string? authorUserId = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}