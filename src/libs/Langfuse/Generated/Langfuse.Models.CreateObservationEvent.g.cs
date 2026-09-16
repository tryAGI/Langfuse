
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Sunset warning: this is the deprecated Langfuse v3 ingestion API. It is shut down on November 16, 2026, except for score events: from that date it accepts only `score-create` events and rejects all other event types, including this one. To write scores, prefer `POST /api/public/scores`; see the [Scores API docs](https://langfuse.com/docs/api-and-data-platform/features/scores-api). To write traces and observations, always prefer upgrading to the current Python and JS SDKs. If you use custom auto-instrumentation, send them to the OpenTelemetry endpoint (`POST /api/public/otel/v1/traces`), for example with curl; see the [OpenTelemetry integration docs](https://langfuse.com/integrations/native/opentelemetry). To read data back, use the v4 read APIs; see the [Observations API docs](https://langfuse.com/docs/api-and-data-platform/features/observations-api) and the [Metrics API docs](https://langfuse.com/docs/metrics/features/metrics-api). The only path to live data is OpenTelemetry ingestion combined with `GET /api/public/v2/observations` and `GET /api/public/v2/metrics`. All other public APIs may have data delays of several minutes.
    /// </summary>
    public sealed partial class CreateObservationEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.ObservationBody Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObservationEvent" /> class.
        /// </summary>
        /// <param name="body"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateObservationEvent(
            global::Langfuse.ObservationBody body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObservationEvent" /> class.
        /// </summary>
        public CreateObservationEvent()
        {
        }

    }
}