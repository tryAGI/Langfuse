#nullable enable

namespace Langfuse
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// Create scores asynchronously from a list of scores. Returns 202 if all scores are accepted, or 207 with accepted/rejected counts and error messages. Do not automatically retry a 207 batch. The generated reference shows only 200; the endpoint returns 202 or 207.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.CreateScoresResponse> ScoresCreateAsync(

            global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest> request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create scores asynchronously from a list of scores. Returns 202 if all scores are accepted, or 207 with accepted/rejected counts and error messages. Do not automatically retry a 207 batch. The generated reference shows only 200; the endpoint returns 202 or 207.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.CreateScoresResponse>> ScoresCreateAsResponseAsync(

            global::System.Collections.Generic.IList<global::Langfuse.CreateScoreRequest> request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}