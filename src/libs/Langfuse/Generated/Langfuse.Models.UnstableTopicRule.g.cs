
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableTopicRule
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
        /// Observation filter that selects the rule's traces, returned verbatim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleReadFilter> Filter { get; set; }

        /// <summary>
        /// Fraction of matching traces that are processed, between `0` and `1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sampling { get; set; }

        /// <summary>
        /// Facets the rule runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FacetIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicRule" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="filter">
        /// Observation filter that selects the rule's traces, returned verbatim.
        /// </param>
        /// <param name="sampling">
        /// Fraction of matching traces that are processed, between `0` and `1`.
        /// </param>
        /// <param name="facetIds">
        /// Facets the rule runs.
        /// </param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableTopicRule(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::Langfuse.EvaluationRuleReadFilter> filter,
            double sampling,
            global::System.Collections.Generic.IList<string> facetIds,
            global::System.DateTime updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Sampling = sampling;
            this.FacetIds = facetIds ?? throw new global::System.ArgumentNullException(nameof(facetIds));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableTopicRule" /> class.
        /// </summary>
        public UnstableTopicRule()
        {
        }

    }
}