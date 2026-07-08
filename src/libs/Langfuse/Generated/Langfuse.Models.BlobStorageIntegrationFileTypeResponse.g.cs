
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// File type reported for an existing integration.
    /// </summary>
    public enum BlobStorageIntegrationFileTypeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Jsonl,
        /// <summary>
        /// 
        /// </summary>
        Parquet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageIntegrationFileTypeResponseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageIntegrationFileTypeResponse value)
        {
            return value switch
            {
                BlobStorageIntegrationFileTypeResponse.Csv => "CSV",
                BlobStorageIntegrationFileTypeResponse.Json => "JSON",
                BlobStorageIntegrationFileTypeResponse.Jsonl => "JSONL",
                BlobStorageIntegrationFileTypeResponse.Parquet => "PARQUET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageIntegrationFileTypeResponse? ToEnum(string value)
        {
            return value switch
            {
                "CSV" => BlobStorageIntegrationFileTypeResponse.Csv,
                "JSON" => BlobStorageIntegrationFileTypeResponse.Json,
                "JSONL" => BlobStorageIntegrationFileTypeResponse.Jsonl,
                "PARQUET" => BlobStorageIntegrationFileTypeResponse.Parquet,
                _ => null,
            };
        }
    }
}