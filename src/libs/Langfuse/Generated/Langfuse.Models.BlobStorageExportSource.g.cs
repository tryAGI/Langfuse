
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// What data the integration exports.<br/>
    /// - `TRACES_OBSERVATIONS`: legacy traces + observations + scores tables with a fixed column set. The `exportFieldGroups` field is not applicable.<br/>
    /// - `EVENTS`: enriched observations_v2 events; columns are controlled by `exportFieldGroups`.<br/>
    /// - `TRACES_OBSERVATIONS_EVENTS`: both sets. For the `EVENTS` portion, columns are controlled by `exportFieldGroups`.<br/>
    /// **Note:** `EVENTS` and the events portion of `TRACES_OBSERVATIONS_EVENTS` rely on the observations_v2 events table (Langfuse Fast Preview / v4), which is currently available on Langfuse Cloud only. See https://langfuse.com/docs/v4.
    /// </summary>
    public enum BlobStorageExportSource
    {
        /// <summary>
        /// enriched observations_v2 events; columns are controlled by `exportFieldGroups`.
        /// </summary>
        Events,
        /// <summary>
        /// legacy traces + observations + scores tables with a fixed column set. The `exportFieldGroups` field is not applicable.
        /// </summary>
        TracesObservations,
        /// <summary>
        /// both sets. For the `EVENTS` portion, columns are controlled by `exportFieldGroups`.
        /// </summary>
        TracesObservationsEvents,
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
                BlobStorageExportSource.Events => "EVENTS",
                BlobStorageExportSource.TracesObservations => "TRACES_OBSERVATIONS",
                BlobStorageExportSource.TracesObservationsEvents => "TRACES_OBSERVATIONS_EVENTS",
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
                "EVENTS" => BlobStorageExportSource.Events,
                "TRACES_OBSERVATIONS" => BlobStorageExportSource.TracesObservations,
                "TRACES_OBSERVATIONS_EVENTS" => BlobStorageExportSource.TracesObservationsEvents,
                _ => null,
            };
        }
    }
}