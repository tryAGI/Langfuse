
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
        /// Storage region
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
        /// 
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
        /// Custom start date for exports (required when exportMode is FROM_CUSTOM_DATE)
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
        /// - `TRACES_OBSERVATIONS`: legacy traces + observations + scores tables with a fixed column set. The `exportFieldGroups` field is not applicable.<br/>
        /// - `EVENTS`: enriched observations_v2 events; columns are controlled by `exportFieldGroups`.<br/>
        /// - `TRACES_OBSERVATIONS_EVENTS`: both sets. For the `EVENTS` portion, columns are controlled by `exportFieldGroups`.<br/>
        /// **Note:** `EVENTS` and the events portion of `TRACES_OBSERVATIONS_EVENTS` rely on the observations_v2 events table (Langfuse Fast Preview / v4), which is currently available on Langfuse Cloud only. See https://langfuse.com/docs/v4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.BlobStorageExportSourceJsonConverter))]
        public global::Langfuse.BlobStorageExportSource? ExportSource { get; set; }

        /// <summary>
        /// Field groups to include in each exported row.<br/>
        /// For exportSource `EVENTS` or `TRACES_OBSERVATIONS_EVENTS`: must include `core` if provided. When omitted on create, the column default (all groups) applies. When omitted on update, the existing value is preserved.<br/>
        /// For exportSource `TRACES_OBSERVATIONS`: this field must be omitted or null. Sending an array (including an empty array) returns 400, because that source uses a fixed column set and does not honor field groups.<br/>
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
        /// Storage region
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
        /// Custom start date for exports (required when exportMode is FROM_CUSTOM_DATE)
        /// </param>
        /// <param name="compressed">
        /// Enable gzip compression for exported files (.csv.gz, .json.gz, .jsonl.gz). Defaults to true.
        /// </param>
        /// <param name="exportSource">
        /// What data the integration exports.<br/>
        /// - `TRACES_OBSERVATIONS`: legacy traces + observations + scores tables with a fixed column set. The `exportFieldGroups` field is not applicable.<br/>
        /// - `EVENTS`: enriched observations_v2 events; columns are controlled by `exportFieldGroups`.<br/>
        /// - `TRACES_OBSERVATIONS_EVENTS`: both sets. For the `EVENTS` portion, columns are controlled by `exportFieldGroups`.<br/>
        /// **Note:** `EVENTS` and the events portion of `TRACES_OBSERVATIONS_EVENTS` rely on the observations_v2 events table (Langfuse Fast Preview / v4), which is currently available on Langfuse Cloud only. See https://langfuse.com/docs/v4.
        /// </param>
        /// <param name="exportFieldGroups">
        /// Field groups to include in each exported row.<br/>
        /// For exportSource `EVENTS` or `TRACES_OBSERVATIONS_EVENTS`: must include `core` if provided. When omitted on create, the column default (all groups) applies. When omitted on update, the existing value is preserved.<br/>
        /// For exportSource `TRACES_OBSERVATIONS`: this field must be omitted or null. Sending an array (including an empty array) returns 400, because that source uses a fixed column set and does not honor field groups.<br/>
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