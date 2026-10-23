
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Traces in the window by their current result for one facet.
    /// </summary>
    public sealed partial class UnstableTopicStatusCounts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Assigned { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outlier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Outlier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awaitingMap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AwaitingMap { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notApplicable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NotApplicable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insufficientInput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InsufficientInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicStatusCounts" /> class.
        /// </summary>
        /// <param name="assigned"></param>
        /// <param name="outlier"></param>
        /// <param name="awaitingMap"></param>
        /// <param name="notApplicable"></param>
        /// <param name="insufficientInput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopicStatusCounts(
            int assigned,
            int outlier,
            int awaitingMap,
            int notApplicable,
            int insufficientInput)
        {
            this.Assigned = assigned;
            this.Outlier = outlier;
            this.AwaitingMap = awaitingMap;
            this.NotApplicable = notApplicable;
            this.InsufficientInput = insufficientInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicStatusCounts" /> class.
        /// </summary>
        public UnstableTopicStatusCounts()
        {
        }

    }
}