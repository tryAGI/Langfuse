#nullable enable

namespace Langfuse
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Update an annotation queue item
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AnnotationQueueItem> AnnotationQueuesUpdateQueueItemAsync(
            string queueId,
            string itemId,

            global::Langfuse.UpdateAnnotationQueueItemRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an annotation queue item
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AnnotationQueueItem> AnnotationQueuesUpdateQueueItemAsync(
            string queueId,
            string itemId,
            global::Langfuse.AnnotationQueueStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}