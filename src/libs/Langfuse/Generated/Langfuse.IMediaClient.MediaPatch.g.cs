#nullable enable

namespace Langfuse
{
    public partial interface IMediaClient
    {
        /// <summary>
        /// Patch a media record
        /// </summary>
        /// <param name="mediaId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task MediaPatchAsync(
            string mediaId,

            global::Langfuse.PatchMediaBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Patch a media record
        /// </summary>
        /// <param name="mediaId"></param>
        /// <param name="uploadedAt">
        /// The date and time when the media record was uploaded
        /// </param>
        /// <param name="uploadHttpStatus">
        /// The HTTP status code of the upload
        /// </param>
        /// <param name="uploadHttpError">
        /// The HTTP error message of the upload
        /// </param>
        /// <param name="uploadTimeMs">
        /// The time in milliseconds it took to upload the media record
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task MediaPatchAsync(
            string mediaId,
            global::System.DateTime uploadedAt,
            int uploadHttpStatus,
            string? uploadHttpError = default,
            int? uploadTimeMs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}