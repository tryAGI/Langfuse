#nullable enable

namespace Langfuse
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get an annotation queue by ID
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AnnotationQueue> AnnotationQueuesGetQueueAsync(
            string queueId,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}