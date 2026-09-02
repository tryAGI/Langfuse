#nullable enable

namespace Langfuse
{
    public partial interface IBlobStorageIntegrationsClient
    {
        /// <summary>
        /// Create or update a blob storage integration for a specific project (requires organization-scoped API key). The configuration is validated by performing a test upload to the bucket.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.BlobStorageIntegrationResponse> BlobStorageIntegrationsUpsertBlobStorageIntegrationAsync(

            global::Langfuse.CreateBlobStorageIntegrationRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a blob storage integration for a specific project (requires organization-scoped API key). The configuration is validated by performing a test upload to the bucket.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Langfuse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.AutoSDKHttpResponse<global::Langfuse.BlobStorageIntegrationResponse>> BlobStorageIntegrationsUpsertBlobStorageIntegrationAsResponseAsync(

            global::Langfuse.CreateBlobStorageIntegrationRequest request,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a blob storage integration for a specific project (requires organization-scoped API key). The configuration is validated by performing a test upload to the bucket.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project in which to configure the blob storage integration
        /// </param>
        /// <param name="type"></param>
        /// <param name="bucketName">
        /// Name of the storage bucket. For AZURE_BLOB_STORAGE, must be a valid Azure container name (3-63 chars, lowercase letters, numbers, and hyphens only, must start and end with a letter or number, no consecutive hyphens).
        /// </param>
        /// <param name="endpoint">
        /// Custom endpoint URL (required for S3_COMPATIBLE type)
        /// </param>
        /// <param name="region">
        /// Storage region used by S3-compatible clients (AWS, GCS, Cloudflare R2, MinIO, Azure location IDs such as eastus, OCI). Leading and trailing whitespace is removed. The remaining value must be 1-63 letters, numbers, or hyphens, and cannot start or end with a hyphen. Examples: us-east-1, europe-west1, eastus, auto.
        /// </param>
        /// <param name="accessKeyId">
        /// Access key ID for authentication
        /// </param>
        /// <param name="secretAccessKey">
        /// Secret access key for authentication (will be encrypted when stored)
        /// </param>
        /// <param name="prefix">
        /// Path prefix for exported files (must end with forward slash if provided)
        /// </param>
        /// <param name="exportFrequency"></param>
        /// <param name="enabled">
        /// Whether the integration is active
        /// </param>
        /// <param name="forcePathStyle">
        /// Use path-style URLs for S3 requests
        /// </param>
        /// <param name="fileType">
        /// File format for exported data. `PARQUET` is a columnar binary format encoded and compressed by the storage engine; gzip compression does not apply to it. Note that the model-price columns (`input_price`, `output_price`, `total_price`) are not included in Parquet observation exports.
        /// </param>
        /// <param name="exportMode"></param>
        /// <param name="exportStartDate">
        /// Custom start date for exports (required when exportMode is FROM_CUSTOM_DATE). Must not be in the future (27 h tolerance for timezone differences).
        /// </param>
        /// <param name="compressed">
        /// Enable gzip compression for exported files (.csv.gz, .json.gz, .jsonl.gz). Defaults to true.
        /// </param>
        /// <param name="exportSource">
        /// What data the integration exports.<br/>
        /// - `LEGACY_TRACES_OBSERVATIONS`: traces, observations, and scores tables. Observation columns are controlled by `exportFieldGroups`; field groups without a counterpart in this data model (e.g. `trace_context`) are omitted.<br/>
        /// - `OBSERVATIONS_V2`: same data model as the `/api/public/v2/observations` endpoint, plus scores. Columns are controlled by `exportFieldGroups`.<br/>
        /// - `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS`: both sets. Observation columns of both portions are controlled by `exportFieldGroups`.<br/>
        /// **Note:** which sources a deployment accepts depends on how far it has moved to the v4 data model. `OBSERVATIONS_V2` and the enriched-observations portion of `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS` read the enriched observations table, so they require a deployment that already populates it. `LEGACY_TRACES_OBSERVATIONS` and the legacy portion of `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS` read the legacy traces and observations tables, so they require a deployment that still populates those. A deployment part-way through the migration populates both and accepts every source. Selecting a source the deployment cannot serve is rejected with `400`, rather than exporting an empty result. See https://langfuse.com/docs/v4.
        /// </param>
        /// <param name="exportFieldGroups">
        /// Field groups to include in each exported observation row. Applies to all export sources; must include `core` if provided. When omitted on create, the column default (all groups) applies. When omitted on update, the existing value is preserved.<br/>
        /// `exportFieldGroups` requires `exportSource` to be provided in the same request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Langfuse.BlobStorageIntegrationResponse> BlobStorageIntegrationsUpsertBlobStorageIntegrationAsync(
            string projectId,
            global::Langfuse.BlobStorageIntegrationType type,
            string bucketName,
            string region,
            global::Langfuse.BlobStorageExportFrequency exportFrequency,
            bool enabled,
            bool forcePathStyle,
            global::Langfuse.BlobStorageIntegrationFileType fileType,
            global::Langfuse.BlobStorageExportMode exportMode,
            string? endpoint = default,
            string? accessKeyId = default,
            string? secretAccessKey = default,
            string? prefix = default,
            global::System.DateTime? exportStartDate = default,
            bool? compressed = default,
            global::Langfuse.BlobStorageExportSource? exportSource = default,
            global::System.Collections.Generic.IList<global::Langfuse.BlobStorageExportFieldGroup>? exportFieldGroups = default,
            global::Langfuse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}