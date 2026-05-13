
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
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Every20Minutes,
        /// <summary>
        /// 
        /// </summary>
        Hourly,
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
                BlobStorageExportFrequency.Daily => "daily",
                BlobStorageExportFrequency.Every20Minutes => "every_20_minutes",
                BlobStorageExportFrequency.Hourly => "hourly",
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
                "daily" => BlobStorageExportFrequency.Daily,
                "every_20_minutes" => BlobStorageExportFrequency.Every20Minutes,
                "hourly" => BlobStorageExportFrequency.Hourly,
                "weekly" => BlobStorageExportFrequency.Weekly,
                _ => null,
            };
        }
    }
}