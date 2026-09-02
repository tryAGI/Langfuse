
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateBlobStorageIntegrationRequest
    {
        /// <summary>
        /// ID of the project in which to configure the blob storage integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.BlobStorageIntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.BlobStorageIntegrationType Type { get; set; }

        /// <summary>
        /// Name of the storage bucket. For AZURE_BLOB_STORAGE, must be a valid Azure container name (3-63 chars, lowercase letters, numbers, and hyphens only, must start and end with a letter or number, no consecutive hyphens).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// Custom endpoint URL (required for S3_COMPATIBLE type)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Storage region used by S3-compatible clients (AWS, GCS, Cloudflare R2, MinIO, Azure location IDs such as eastus, OCI). Leading and trailing whitespace is removed. The remaining value must be 1-63 letters, numbers, or hyphens, and cannot start or end with a hyphen. Examples: us-east-1, europe-west1, eastus, auto.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Access key ID for authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessKeyId")]
        public string? AccessKeyId { get; set; }

        /// <summary>
        /// Secret access key for authentication (will be encrypted when stored)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretAccessKey")]
        public string? SecretAccessKey { get; set; }

        /// <summary>
        /// Path prefix for exported files (must end with forward slash if provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportFrequency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.BlobStorageExportFrequencyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.BlobStorageExportFrequency ExportFrequency { get; set; }

        /// <summary>
        /// Whether the integration is active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Use path-style URLs for S3 requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forcePathStyle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ForcePathStyle { get; set; }

        /// <summary>
        /// File format for exported data. `PARQUET` is a columnar binary format encoded and compressed by the storage engine; gzip compression does not apply to it. Note that the model-price columns (`input_price`, `output_price`, `total_price`) are not included in Parquet observation exports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.BlobStorageIntegrationFileType FileType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.BlobStorageExportModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.BlobStorageExportMode ExportMode { get; set; }

        /// <summary>
        /// Custom start date for exports (required when exportMode is FROM_CUSTOM_DATE). Must not be in the future (27 h tolerance for timezone differences).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportStartDate")]
        public global::System.DateTime? ExportStartDate { get; set; }

        /// <summary>
        /// Enable gzip compression for exported files (.csv.gz, .json.gz, .jsonl.gz). Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compressed")]
        public bool? Compressed { get; set; }

        /// <summary>
        /// What data the integration exports.<br/>
        /// - `LEGACY_TRACES_OBSERVATIONS`: traces, observations, and scores tables. Observation columns are controlled by `exportFieldGroups`; field groups without a counterpart in this data model (e.g. `trace_context`) are omitted.<br/>
        /// - `OBSERVATIONS_V2`: same data model as the `/api/public/v2/observations` endpoint, plus scores. Columns are controlled by `exportFieldGroups`.<br/>
        /// - `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS`: both sets. Observation columns of both portions are controlled by `exportFieldGroups`.<br/>
        /// **Note:** which sources a deployment accepts depends on how far it has moved to the v4 data model. `OBSERVATIONS_V2` and the enriched-observations portion of `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS` read the enriched observations table, so they require a deployment that already populates it. `LEGACY_TRACES_OBSERVATIONS` and the legacy portion of `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS` read the legacy traces and observations tables, so they require a deployment that still populates those. A deployment part-way through the migration populates both and accepts every source. Selecting a source the deployment cannot serve is rejected with `400`, rather than exporting an empty result. See https://langfuse.com/docs/v4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.BlobStorageExportSourceJsonConverter))]
        public global::Langfuse.BlobStorageExportSource? ExportSource { get; set; }

        /// <summary>
        /// Field groups to include in each exported observation row. Applies to all export sources; must include `core` if provided. When omitted on create, the column default (all groups) applies. When omitted on update, the existing value is preserved.<br/>
        /// `exportFieldGroups` requires `exportSource` to be provided in the same request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportFieldGroups")]
        public global::System.Collections.Generic.IList<global::Langfuse.BlobStorageExportFieldGroup>? ExportFieldGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlobStorageIntegrationRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project in which to configure the blob storage integration
        /// </param>
        /// <param name="type"></param>
        /// <param name="bucketName">
        /// Name of the storage bucket. For AZURE_BLOB_STORAGE, must be a valid Azure container name (3-63 chars, lowercase letters, numbers, and hyphens only, must start and end with a letter or number, no consecutive hyphens).
        /// </param>
        /// <param name="region">
        /// Storage region used by S3-compatible clients (AWS, GCS, Cloudflare R2, MinIO, Azure location IDs such as eastus, OCI). Leading and trailing whitespace is removed. The remaining value must be 1-63 letters, numbers, or hyphens, and cannot start or end with a hyphen. Examples: us-east-1, europe-west1, eastus, auto.
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
        /// <param name="endpoint">
        /// Custom endpoint URL (required for S3_COMPATIBLE type)
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBlobStorageIntegrationRequest(
            string projectId,
            global::Langfuse.BlobStorageIntegrationType type,
            string bucketName,
            string region,
            global::Langfuse.BlobStorageExportFrequency exportFrequency,
            bool enabled,
            bool forcePathStyle,
            global::Langfuse.BlobStorageIntegrationFileType fileType,
            global::Langfuse.BlobStorageExportMode exportMode,
            string? endpoint,
            string? accessKeyId,
            string? secretAccessKey,
            string? prefix,
            global::System.DateTime? exportStartDate,
            bool? compressed,
            global::Langfuse.BlobStorageExportSource? exportSource,
            global::System.Collections.Generic.IList<global::Langfuse.BlobStorageExportFieldGroup>? exportFieldGroups)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Type = type;
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.Endpoint = endpoint;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
            this.Prefix = prefix;
            this.ExportFrequency = exportFrequency;
            this.Enabled = enabled;
            this.ForcePathStyle = forcePathStyle;
            this.FileType = fileType;
            this.ExportMode = exportMode;
            this.ExportStartDate = exportStartDate;
            this.Compressed = compressed;
            this.ExportSource = exportSource;
            this.ExportFieldGroups = exportFieldGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlobStorageIntegrationRequest" /> class.
        /// </summary>
        public CreateBlobStorageIntegrationRequest()
        {
        }

    }
}