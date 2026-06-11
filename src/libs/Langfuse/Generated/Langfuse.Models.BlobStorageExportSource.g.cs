
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// What data the integration exports.<br/>
    /// - `LEGACY_TRACES_OBSERVATIONS`: traces, observations, and scores tables. Observation columns are controlled by `exportFieldGroups`; field groups without a counterpart in this data model (e.g. `trace_context`) are omitted.<br/>
    /// - `OBSERVATIONS_V2`: same data model as the `/api/public/v2/observations` endpoint, plus scores. Columns are controlled by `exportFieldGroups`.<br/>
    /// - `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS`: both sets. Observation columns of both portions are controlled by `exportFieldGroups`.<br/>
    /// **Note:** `OBSERVATIONS_V2` and the enriched-observations portion of `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS` rely on the enriched observations table (Langfuse Fast Preview / v4), which is currently available on Langfuse Cloud only. See https://langfuse.com/docs/v4.
    /// </summary>
    public enum BlobStorageExportSource
    {
        /// <summary>
        /// both sets. Observation columns of both portions are controlled by `exportFieldGroups`.
        /// </summary>
        LegacyTracesAndEnrichedObservations,
        /// <summary>
        /// traces, observations, and scores tables. Observation columns are controlled by `exportFieldGroups`; field groups without a counterpart in this data model (e.g. `trace_context`) are omitted.
        /// </summary>
        LegacyTracesObservations,
        /// <summary>
        /// same data model as the `/api/public/v2/observations` endpoint, plus scores. Columns are controlled by `exportFieldGroups`.
        /// </summary>
        ObservationsV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageExportSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageExportSource value)
        {
            return value switch
            {
                BlobStorageExportSource.LegacyTracesAndEnrichedObservations => "LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS",
                BlobStorageExportSource.LegacyTracesObservations => "LEGACY_TRACES_OBSERVATIONS",
                BlobStorageExportSource.ObservationsV2 => "OBSERVATIONS_V2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageExportSource? ToEnum(string value)
        {
            return value switch
            {
                "LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS" => BlobStorageExportSource.LegacyTracesAndEnrichedObservations,
                "LEGACY_TRACES_OBSERVATIONS" => BlobStorageExportSource.LegacyTracesObservations,
                "OBSERVATIONS_V2" => BlobStorageExportSource.ObservationsV2,
                _ => null,
            };
        }
    }
}