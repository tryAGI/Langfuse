
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Experiment
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Start of the experiment, i.e. the earliest event within the<br/>
        /// requested time range. Clipped to `fromStartTime` when the<br/>
        /// experiment started before the requested range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// End of the experiment, i.e. the latest event end within the<br/>
        /// requested time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// Number of experiment items within the requested time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ItemCount { get; set; }

        /// <summary>
        /// Null when the experiment is not associated with a dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// Included only when `fields=metadata` is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Included only when `fields=scores` is requested. Contains scores directly attached to the experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>? Scores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="startTime">
        /// Start of the experiment, i.e. the earliest event within the<br/>
        /// requested time range. Clipped to `fromStartTime` when the<br/>
        /// experiment started before the requested range.
        /// </param>
        /// <param name="endTime">
        /// End of the experiment, i.e. the latest event end within the<br/>
        /// requested time range.
        /// </param>
        /// <param name="itemCount">
        /// Number of experiment items within the requested time range.
        /// </param>
        /// <param name="description"></param>
        /// <param name="datasetId">
        /// Null when the experiment is not associated with a dataset.
        /// </param>
        /// <param name="metadata">
        /// Included only when `fields=metadata` is requested.
        /// </param>
        /// <param name="scores">
        /// Included only when `fields=scores` is requested. Contains scores directly attached to the experiment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Experiment(
            string id,
            string name,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int itemCount,
            string? description,
            string? datasetId,
            object? metadata,
            global::System.Collections.Generic.IList<global::Langfuse.ScoreV3>? scores)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ItemCount = itemCount;
            this.DatasetId = datasetId;
            this.Metadata = metadata;
            this.Scores = scores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        public Experiment()
        {
        }

    }
}