
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlobStorageIntegrationType
    {
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        S3Compatible,
        /// <summary>
        /// 
        /// </summary>
        AzureBlobStorage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageIntegrationType value)
        {
            return value switch
            {
                BlobStorageIntegrationType.S3 => "S3",
                BlobStorageIntegrationType.S3Compatible => "S3_COMPATIBLE",
                BlobStorageIntegrationType.AzureBlobStorage => "AZURE_BLOB_STORAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "S3" => BlobStorageIntegrationType.S3,
                "S3_COMPATIBLE" => BlobStorageIntegrationType.S3Compatible,
                "AZURE_BLOB_STORAGE" => BlobStorageIntegrationType.AzureBlobStorage,
                _ => null,
            };
        }
    }
}