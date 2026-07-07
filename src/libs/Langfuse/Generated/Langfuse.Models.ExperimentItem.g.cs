
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Langfuse.JsonConverters.ObservationLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Langfuse.ObservationLevel Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentItemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentItemId { get; set; }

        /// <summary>
        /// Included when `fields=dataset` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentDatasetId")]
        public string? ExperimentDatasetId { get; set; }

        /// <summary>
        /// Included when `fields=dataset` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentItemVersion")]
        public global::System.DateTime? ExperimentItemVersion { get; set; }

        /// <summary>
        /// Included when `fields=io` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Included when `fields=io` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// Included when `fields=io` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedOutput")]
        public object? ExpectedOutput { get; set; }

        /// <summary>
        /// Included when `fields=metadata` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Included when `fields=itemMetadata` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentItemMetadata")]
        public object? ExperimentItemMetadata { get; set; }

        /// <summary>
        /// Included when `fields=experimentMetadata` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentMetadata")]
        public object? ExperimentMetadata { get; set; }

        /// <summary>
        /// Included when `fields=experimentMetadata` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentDescription")]
        public string? ExperimentDescription { get; set; }

        /// <summary>
        /// Included only when `fields=scores` is requested. Contains item and trace scores only; experiment-level scores are returned by the experiments endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>? Scores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="traceId"></param>
        /// <param name="startTime"></param>
        /// <param name="level"></param>
        /// <param name="environment"></param>
        /// <param name="experimentId"></param>
        /// <param name="experimentName"></param>
        /// <param name="experimentItemId"></param>
        /// <param name="endTime"></param>
        /// <param name="experimentDatasetId">
        /// Included when `fields=dataset` is requested.
        /// </param>
        /// <param name="experimentItemVersion">
        /// Included when `fields=dataset` is requested.
        /// </param>
        /// <param name="input">
        /// Included when `fields=io` is requested.
        /// </param>
        /// <param name="output">
        /// Included when `fields=io` is requested.
        /// </param>
        /// <param name="expectedOutput">
        /// Included when `fields=io` is requested.
        /// </param>
        /// <param name="metadata">
        /// Included when `fields=metadata` is requested.
        /// </param>
        /// <param name="experimentItemMetadata">
        /// Included when `fields=itemMetadata` is requested.
        /// </param>
        /// <param name="experimentMetadata">
        /// Included when `fields=experimentMetadata` is requested.
        /// </param>
        /// <param name="experimentDescription">
        /// Included when `fields=experimentMetadata` is requested.
        /// </param>
        /// <param name="scores">
        /// Included only when `fields=scores` is requested. Contains item and trace scores only; experiment-level scores are returned by the experiments endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentItem(
            string id,
            string traceId,
            global::System.DateTime startTime,
            global::Langfuse.ObservationLevel level,
            string environment,
            string experimentId,
            string experimentName,
            string experimentItemId,
            global::System.DateTime? endTime,
            string? experimentDatasetId,
            global::System.DateTime? experimentItemVersion,
            object? input,
            object? output,
            object? expectedOutput,
            object? metadata,
            object? experimentItemMetadata,
            object? experimentMetadata,
            string? experimentDescription,
            global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>? scores)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Level = level;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.ExperimentId = experimentId ?? throw new global::System.ArgumentNullException(nameof(experimentId));
            this.ExperimentName = experimentName ?? throw new global::System.ArgumentNullException(nameof(experimentName));
            this.ExperimentItemId = experimentItemId ?? throw new global::System.ArgumentNullException(nameof(experimentItemId));
            this.ExperimentDatasetId = experimentDatasetId;
            this.ExperimentItemVersion = experimentItemVersion;
            this.Input = input;
            this.Output = output;
            this.ExpectedOutput = expectedOutput;
            this.Metadata = metadata;
            this.ExperimentItemMetadata = experimentItemMetadata;
            this.ExperimentMetadata = experimentMetadata;
            this.ExperimentDescription = experimentDescription;
            this.Scores = scores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItem" /> class.
        /// </summary>
        public ExperimentItem()
        {
        }

    }
}