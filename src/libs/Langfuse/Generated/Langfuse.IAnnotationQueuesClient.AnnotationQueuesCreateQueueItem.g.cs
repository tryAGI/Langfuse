#nullable enable

namespace Langfuse
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Add an item to an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AnnotationQueueItem> AnnotationQueuesCreateQueueItemAsync(
            string queueId,

            global::Langfuse.CreateAnnotationQueueItemRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add an item to an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="objectId"></param>
        /// <param name="objectType"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AnnotationQueueItem> AnnotationQueuesCreateQueueItemAsync(
            string queueId,
            string objectId,
            global::Langfuse.AnnotationQueueObjectType objectType,
            global::Langfuse.AnnotationQueueStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}