
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlobStorageIntegrationFileType
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Jsonl,
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
                BlobStorageIntegrationFileType.Json => "JSON",
                BlobStorageIntegrationFileType.Csv => "CSV",
                BlobStorageIntegrationFileType.Jsonl => "JSONL",
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
                "JSON" => BlobStorageIntegrationFileType.Json,
                "CSV" => BlobStorageIntegrationFileType.Csv,
                "JSONL" => BlobStorageIntegrationFileType.Jsonl,
                _ => null,
            };
        }
    }
}