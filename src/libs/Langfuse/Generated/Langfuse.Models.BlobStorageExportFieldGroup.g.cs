
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Field group for the EVENTS export.
    /// </summary>
    public enum BlobStorageExportFieldGroup
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
        Core,
        /// <summary>
        /// 
        /// </summary>
        Io,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Metrics,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        Tools,
        /// <summary>
        /// 
        /// </summary>
        TraceContext,
        /// <summary>
        /// 
        /// </summary>
        Usage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageExportFieldGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageExportFieldGroup value)
        {
            return value switch
            {
                BlobStorageExportFieldGroup.Basic => "basic",
                BlobStorageExportFieldGroup.Core => "core",
                BlobStorageExportFieldGroup.Io => "io",
                BlobStorageExportFieldGroup.Metadata => "metadata",
                BlobStorageExportFieldGroup.Metrics => "metrics",
                BlobStorageExportFieldGroup.Model => "model",
                BlobStorageExportFieldGroup.Prompt => "prompt",
                BlobStorageExportFieldGroup.Time => "time",
                BlobStorageExportFieldGroup.Tools => "tools",
                BlobStorageExportFieldGroup.TraceContext => "trace_context",
                BlobStorageExportFieldGroup.Usage => "usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageExportFieldGroup? ToEnum(string value)
        {
            return value switch
            {
                "basic" => BlobStorageExportFieldGroup.Basic,
                "core" => BlobStorageExportFieldGroup.Core,
                "io" => BlobStorageExportFieldGroup.Io,
                "metadata" => BlobStorageExportFieldGroup.Metadata,
                "metrics" => BlobStorageExportFieldGroup.Metrics,
                "model" => BlobStorageExportFieldGroup.Model,
                "prompt" => BlobStorageExportFieldGroup.Prompt,
                "time" => BlobStorageExportFieldGroup.Time,
                "tools" => BlobStorageExportFieldGroup.Tools,
                "trace_context" => BlobStorageExportFieldGroup.TraceContext,
                "usage" => BlobStorageExportFieldGroup.Usage,
                _ => null,
            };
        }
    }
}