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
        /// Storage region
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
        /// <param name="fileType"></param>
        /// <param name="exportMode"></param>
        /// <param name="exportStartDate">
        /// Custom start date for exports (required when exportMode is FROM_CUSTOM_DATE)
        /// </param>
        /// <param name="compressed">
        /// Enable gzip compression for exported files (.csv.gz, .json.gz, .jsonl.gz). Defaults to true.
        /// </param>
        /// <param name="exportSource">
        /// What data the integration exports.<br/>
        /// - `LEGACY_TRACES_OBSERVATIONS`: traces, observations, and scores tables with a fixed column set. The `exportFieldGroups` field is not applicable.<br/>
        /// - `OBSERVATIONS_V2`: same data model as the `/api/public/v2/observations` endpoint, plus scores. Columns are controlled by `exportFieldGroups`.<br/>
        /// - `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS`: both sets. For the `OBSERVATIONS_V2` portion, columns are controlled by `exportFieldGroups`.<br/>
        /// **Note:** `OBSERVATIONS_V2` and the enriched-observations portion of `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS` rely on the enriched observations table (Langfuse Fast Preview / v4), which is currently available on Langfuse Cloud only. See https://langfuse.com/docs/v4.
        /// </param>
        /// <param name="exportFieldGroups">
        /// Field groups to include in each exported row.<br/>
        /// For exportSource `OBSERVATIONS_V2` or `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS`: must include `core` if provided. When omitted on create, the column default (all groups) applies. When omitted on update, the existing value is preserved.<br/>
        /// For exportSource `LEGACY_TRACES_OBSERVATIONS`: this field must be omitted or null. Sending an array (including an empty array) returns 400, because that source uses a fixed column set and does not honor field groups.<br/>
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