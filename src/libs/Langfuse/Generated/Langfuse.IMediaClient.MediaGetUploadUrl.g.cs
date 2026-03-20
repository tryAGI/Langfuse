#nullable enable

namespace Langfuse
{
    public partial interface IMediaClient
    {
        /// <summary>
        /// Get a presigned upload URL for a media record
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.GetMediaUploadUrlResponse> MediaGetUploadUrlAsync(

            global::Langfuse.GetMediaUploadUrlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a presigned upload URL for a media record
        /// </summary>
        /// <param name="traceId">
        /// The trace ID associated with the media record
        /// </param>
        /// <param name="observationId">
        /// The observation ID associated with the media record. If the media record is associated directly with a trace, this will be null.
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the media record
        /// </param>
        /// <param name="contentLength">
        /// The size of the media record in bytes
        /// </param>
        /// <param name="sha256Hash">
        /// The SHA-256 hash of the media record
        /// </param>
        /// <param name="field">
        /// The trace / observation field the media record is associated with. This can be one of `input`, `output`, `metadata`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.GetMediaUploadUrlResponse> MediaGetUploadUrlAsync(
            string traceId,
            global::Langfuse.MediaContentType contentType,
            long contentLength,
            string sha256Hash,
            string field,
            string? observationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}