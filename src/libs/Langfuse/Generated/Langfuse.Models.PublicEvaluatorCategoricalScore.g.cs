
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicEvaluatorCategoricalScore
    {
        /// <summary>
        /// Categorical score output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataType { get; set; }

        /// <summary>
        /// Allowed category values. At least two unique values are required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>
        /// Whether the evaluator may return more than one category.
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
        /// Initializes a new instance of the <see cref="PublicEvaluatorCategoricalScore" /> class.
        /// </summary>
        /// <param name="dataType">
        /// Categorical score output.
        /// </param>
        /// <param name="categories">
        /// Allowed category values. At least two unique values are required.
        /// </param>
        /// <param name="shouldAllowMultipleMatches">
        /// Whether the evaluator may return more than one category.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicEvaluatorCategoricalScore(
            string dataType,
            global::System.Collections.Generic.IList<string> categories,
            bool shouldAllowMultipleMatches)
        {
            this.DataType = dataType ?? throw new global::System.ArgumentNullException(nameof(dataType));
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.ShouldAllowMultipleMatches = shouldAllowMultipleMatches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEvaluatorCategoricalScore" /> class.
        /// </summary>
        public PublicEvaluatorCategoricalScore()
        {
        }

    }
}