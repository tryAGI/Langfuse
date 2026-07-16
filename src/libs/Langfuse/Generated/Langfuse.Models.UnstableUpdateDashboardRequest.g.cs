
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnstableUpdateDashboardRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        public global::Langfuse.UnstableDashboardDefinition? Definition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableUpdateDashboardRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="definition"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableUpdateDashboardRequest(
            string? name,
            string? description,
            global::Langfuse.UnstableDashboardDefinition? definition,
            global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>? filters)
        {
            this.Name = name;
            this.Description = description;
            this.Definition = definition;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableUpdateDashboardRequest" /> class.
        /// </summary>
        public UnstableUpdateDashboardRequest()
        {
        }

    }
}