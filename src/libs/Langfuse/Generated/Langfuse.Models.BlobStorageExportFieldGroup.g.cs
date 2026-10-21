
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Field group selecting which columns are included in the export. Applies to all export sources.<br/>
    /// - Observation groups (`core` through `trace_context`) select observation columns; groups without a counterpart in the legacy data model (e.g. `trace_context`) are omitted from the legacy observations export.<br/>
    /// - Score groups (`score_` prefix) add optional columns to the scores export. The core score columns (`id`, `timestamp`, `trace_id`, `name`, `value`, …) are always exported and are not a selectable group; score groups add columns on top of them. `score_metadata` adds the score `metadata` column. `score_provenance` adds the references to where a score came from: `author_user_id`, `config_id`, `queue_id`, `evaluator_id`, `evaluation_rule_id`, `execution_trace_id`. Score groups are never selected by default.
    /// </summary>
    public enum BlobStorageExportFieldGroup
    {
        /// <summary>
        ///
        /// </summary>
        Basic,
        /// <summary>
        /// `author_user_id`, `config_id`, `queue_id`, `evaluator_id`, `evaluation_rule_id`, `execution_trace_id`. Score groups are never selected by default.
        /// </summary>
        Core,
        /// <summary>
        /// `author_user_id`, `config_id`, `queue_id`, `evaluator_id`, `evaluation_rule_id`, `execution_trace_id`. Score groups are never selected by default.
        /// </summary>
        Io,
        /// <summary>
        /// `author_user_id`, `config_id`, `queue_id`, `evaluator_id`, `evaluation_rule_id`, `execution_trace_id`. Score groups are never selected by default.
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
        /// `author_user_id`, `config_id`, `queue_id`, `evaluator_id`, `evaluation_rule_id`, `execution_trace_id`. Score groups are never selected by default.
        /// </summary>
        ScoreMetadata,
        /// <summary>
        /// `author_user_id`, `config_id`, `queue_id`, `evaluator_id`, `evaluation_rule_id`, `execution_trace_id`. Score groups are never selected by default.
        /// </summary>
        ScoreProvenance,
        /// <summary>
        /// `author_user_id`, `config_id`, `queue_id`, `evaluator_id`, `evaluation_rule_id`, `execution_trace_id`. Score groups are never selected by default.
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
                BlobStorageExportFieldGroup.ScoreMetadata => "score_metadata",
                BlobStorageExportFieldGroup.ScoreProvenance => "score_provenance",
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
                "score_metadata" => BlobStorageExportFieldGroup.ScoreMetadata,
                "score_provenance" => BlobStorageExportFieldGroup.ScoreProvenance,
                "time" => BlobStorageExportFieldGroup.Time,
                "tools" => BlobStorageExportFieldGroup.Tools,
                "trace_context" => BlobStorageExportFieldGroup.TraceContext,
                "usage" => BlobStorageExportFieldGroup.Usage,
                _ => null,
            };
        }
    }
}