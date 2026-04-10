#nullable enable

namespace Langfuse
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Create an annotation queue
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AnnotationQueue> AnnotationQueuesCreateQueueAsync(

            global::Langfuse.CreateAnnotationQueueRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an annotation queue
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="scoreConfigIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AnnotationQueue> AnnotationQueuesCreateQueueAsync(
            string name,
            global::System.Collections.Generic.IList<string> scoreConfigIds,
            string? description = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}