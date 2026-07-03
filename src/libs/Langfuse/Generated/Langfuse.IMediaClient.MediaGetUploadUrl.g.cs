#nullable enable

namespace Langfuse
{
    public partial interface IMediaClient
    {
        /// <summary>
        /// Get a presigned upload URL for a media record
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.GetMediaUploadUrlResponse> MediaGetUploadUrlAsync(

            global::Langfuse.GetMediaUploadUrlRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a presigned upload URL for a media record
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.GetMediaUploadUrlResponse>> MediaGetUploadUrlAsResponseAsync(

            global::Langfuse.GetMediaUploadUrlRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a presigned upload URL for a media record
        /// </summary>
        /// <param name="traceId">
        /// The trace the media is associated with. Null for dataset item media uploads.
        /// </param>
        /// <param name="observationId">
        /// The observation ID associated with the media record. If the media record is associated directly with a trace, this will be null.
        /// </param>
        /// <param name="datasetId">
        /// The dataset the media belongs to. Null for trace/observation media uploads.
        /// </param>
        /// <param name="datasetItemId">
        /// The dataset item the media is associated with (need not exist yet). Null for trace/observation media uploads.
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
        /// The item field the media is in: `input`/`output`/`metadata` (trace) or `input`/`expectedOutput`/`metadata` (dataset item).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.GetMediaUploadUrlResponse> MediaGetUploadUrlAsync(
            global::Langfuse.MediaContentType contentType,
            long contentLength,
            string sha256Hash,
            string field,
            string? traceId = default,
            string? observationId = default,
            string? datasetId = default,
            string? datasetItemId = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}