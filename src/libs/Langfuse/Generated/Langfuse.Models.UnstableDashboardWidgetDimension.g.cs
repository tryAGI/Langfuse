
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableDashboardWidgetDimension
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidgetDimension" /> class.
        /// </summary>
        /// <param name="field"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableDashboardWidgetDimension(
            string field)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidgetDimension" /> class.
        /// </summary>
        public UnstableDashboardWidgetDimension()
        {
        }

    }
}