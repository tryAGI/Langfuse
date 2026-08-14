
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// What data the integration exports.<br/>
    /// - `LEGACY_TRACES_OBSERVATIONS`: traces, observations, and scores tables. Observation columns are controlled by `exportFieldGroups`; field groups without a counterpart in this data model (e.g. `trace_context`) are omitted.<br/>
    /// - `OBSERVATIONS_V2`: same data model as the `/api/public/v2/observations` endpoint, plus scores. Columns are controlled by `exportFieldGroups`.<br/>
    /// - `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS`: both sets. Observation columns of both portions are controlled by `exportFieldGroups`.<br/>
    /// **Note:** which sources a deployment accepts depends on how far it has moved to the v4 data model. `OBSERVATIONS_V2` and the enriched-observations portion of `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS` read the enriched observations table, so they require a deployment that already populates it. `LEGACY_TRACES_OBSERVATIONS` and the legacy portion of `LEGACY_TRACES_AND_ENRICHED_OBSERVATIONS` read the legacy traces and observations tables, so they require a deployment that still populates those. A deployment part-way through the migration populates both and accepts every source. Selecting a source the deployment cannot serve is rejected with `400`, rather than exporting an empty result. See https://langfuse.com/docs/v4.
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