
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// File format for exported data. `PARQUET` is a columnar binary format encoded and compressed by the storage engine; gzip compression does not apply to it. Note that the model-price columns (`input_price`, `output_price`, `total_price`) are not included in Parquet observation exports.
    /// </summary>
    public enum BlobStorageIntegrationFileType
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
    public static class BlobStorageIntegrationFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageIntegrationFileType value)
        {
            return value switch
            {
                BlobStorageIntegrationFileType.Csv => "CSV",
                BlobStorageIntegrationFileType.Json => "JSON",
                BlobStorageIntegrationFileType.Jsonl => "JSONL",
                BlobStorageIntegrationFileType.Parquet => "PARQUET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageIntegrationFileType? ToEnum(string value)
        {
            return value switch
            {
                "CSV" => BlobStorageIntegrationFileType.Csv,
                "JSON" => BlobStorageIntegrationFileType.Json,
                "JSONL" => BlobStorageIntegrationFileType.Jsonl,
                "PARQUET" => BlobStorageIntegrationFileType.Parquet,
                _ => null,
            };
        }
    }
}