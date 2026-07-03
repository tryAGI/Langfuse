
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Request a presigned media upload URL. Provide exactly one context: a trace (traceId, optionally observationId) or a dataset item (datasetId + datasetItemId). field is required and must match the chosen context.
    /// </summary>
    public sealed partial class GetMediaUploadUrlRequest
    {
        /// <summary>
        /// The trace the media is associated with. Null for dataset item media uploads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        public string? TraceId { get; set; }

        /// <summary>
        /// The observation ID associated with the media record. If the media record is associated directly with a trace, this will be null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observationId")]
        public string? ObservationId { get; set; }

        /// <summary>
        /// The dataset the media belongs to. Null for trace/observation media uploads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// The dataset item the media is associated with (need not exist yet). Null for trace/observation media uploads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetItemId")]
        public string? DatasetItemId { get; set; }

        /// <summary>
        /// The MIME type of the media record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.MediaContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.MediaContentType ContentType { get; set; }

        /// <summary>
        /// The size of the media record in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ContentLength { get; set; }

        /// <summary>
        /// The SHA-256 hash of the media record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256Hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha256Hash { get; set; }

        /// <summary>
        /// The item field the media is in: `input`/`output`/`metadata` (trace) or `input`/`expectedOutput`/`metadata` (dataset item).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMediaUploadUrlRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMediaUploadUrlRequest(
            global::Langfuse.MediaContentType contentType,
            long contentLength,
            string sha256Hash,
            string field,
            string? traceId,
            string? observationId,
            string? datasetId,
            string? datasetItemId)
        {
            this.TraceId = traceId;
            this.ObservationId = observationId;
            this.DatasetId = datasetId;
            this.DatasetItemId = datasetItemId;
            this.ContentType = contentType;
            this.ContentLength = contentLength;
            this.Sha256Hash = sha256Hash ?? throw new global::System.ArgumentNullException(nameof(sha256Hash));
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMediaUploadUrlRequest" /> class.
        /// </summary>
        public GetMediaUploadUrlRequest()
        {
        }

    }
}