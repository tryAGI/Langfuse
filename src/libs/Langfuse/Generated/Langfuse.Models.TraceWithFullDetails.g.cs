
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceWithFullDetails
    {
        /// <summary>
        /// Path of trace in Langfuse UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("htmlPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlPath { get; set; }

        /// <summary>
        /// Latency of trace in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// Cost of trace in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// List of observations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.ObservationsView> Observations { get; set; }

        /// <summary>
        /// List of scores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.ScoreV1> Scores { get; set; }

        /// <summary>
        /// Migration signal returned by deprecated endpoints. Optional fields are omitted when they have no value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_deprecation")]
        public global::Langfuse.Deprecation? Deprecation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceWithFullDetails" /> class.
        /// </summary>
        /// <param name="htmlPath">
        /// Path of trace in Langfuse UI
        /// </param>
        /// <param name="observations">
        /// List of observations
        /// </param>
        /// <param name="scores">
        /// List of scores
        /// </param>
        /// <param name="latency">
        /// Latency of trace in seconds
        /// </param>
        /// <param name="totalCost">
        /// Cost of trace in USD
        /// </param>
        /// <param name="deprecation">
        /// Migration signal returned by deprecated endpoints. Optional fields are omitted when they have no value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceWithFullDetails(
            string htmlPath,
            global::System.Collections.Generic.IList<global::Langfuse.ObservationsView> observations,
            global::System.Collections.Generic.IList<global::Langfuse.ScoreV1> scores,
            double? latency,
            double? totalCost,
            global::Langfuse.Deprecation? deprecation)
        {
            this.HtmlPath = htmlPath ?? throw new global::System.ArgumentNullException(nameof(htmlPath));
            this.Latency = latency;
            this.TotalCost = totalCost;
            this.Observations = observations ?? throw new global::System.ArgumentNullException(nameof(observations));
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
            this.Deprecation = deprecation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceWithFullDetails" /> class.
        /// </summary>
        public TraceWithFullDetails()
        {
        }

    }
}