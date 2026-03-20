
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlobStorageExportFrequency
    {
        /// <summary>
        /// 
        /// </summary>
        Hourly,
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageExportFrequencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageExportFrequency value)
        {
            return value switch
            {
                BlobStorageExportFrequency.Hourly => "hourly",
                BlobStorageExportFrequency.Daily => "daily",
                BlobStorageExportFrequency.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageExportFrequency? ToEnum(string value)
        {
            return value switch
            {
                "hourly" => BlobStorageExportFrequency.Hourly,
                "daily" => BlobStorageExportFrequency.Daily,
                "weekly" => BlobStorageExportFrequency.Weekly,
                _ => null,
            };
        }
    }
}