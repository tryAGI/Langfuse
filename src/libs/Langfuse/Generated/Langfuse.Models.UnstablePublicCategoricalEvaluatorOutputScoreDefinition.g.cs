
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstablePublicCategoricalEvaluatorOutputScoreDefinition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldAllowMultipleMatches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ShouldAllowMultipleMatches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicCategoricalEvaluatorOutputScoreDefinition" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="categories"></param>
        /// <param name="shouldAllowMultipleMatches"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstablePublicCategoricalEvaluatorOutputScoreDefinition(
            string description,
            global::System.Collections.Generic.IList<string> categories,
            bool shouldAllowMultipleMatches)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.ShouldAllowMultipleMatches = shouldAllowMultipleMatches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstablePublicCategoricalEvaluatorOutputScoreDefinition" /> class.
        /// </summary>
        public UnstablePublicCategoricalEvaluatorOutputScoreDefinition()
        {
        }

    }
}