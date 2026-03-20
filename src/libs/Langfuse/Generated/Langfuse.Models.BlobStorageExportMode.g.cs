
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlobStorageExportMode
    {
        /// <summary>
        /// 
        /// </summary>
        FullHistory,
        /// <summary>
        /// 
        /// </summary>
        FromToday,
        /// <summary>
        /// 
        /// </summary>
        FromCustomDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageExportModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageExportMode value)
        {
            return value switch
            {
                BlobStorageExportMode.FullHistory => "FULL_HISTORY",
                BlobStorageExportMode.FromToday => "FROM_TODAY",
                BlobStorageExportMode.FromCustomDate => "FROM_CUSTOM_DATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageExportMode? ToEnum(string value)
        {
            return value switch
            {
                "FULL_HISTORY" => BlobStorageExportMode.FullHistory,
                "FROM_TODAY" => BlobStorageExportMode.FromToday,
                "FROM_CUSTOM_DATE" => BlobStorageExportMode.FromCustomDate,
                _ => null,
            };
        }
    }
}