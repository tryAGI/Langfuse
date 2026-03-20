#nullable enable

namespace Langfuse
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Remove an item from an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.DeleteAnnotationQueueItemResponse> AnnotationQueuesDeleteQueueItemAsync(
            string queueId,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}