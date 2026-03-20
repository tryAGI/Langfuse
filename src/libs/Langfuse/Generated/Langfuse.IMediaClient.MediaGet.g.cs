#nullable enable

namespace Langfuse
{
    public partial interface IMediaClient
    {
        /// <summary>
        /// Get a media record
        /// </summary>
        /// <param name="mediaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.GetMediaResponse> MediaGetAsync(
            string mediaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}