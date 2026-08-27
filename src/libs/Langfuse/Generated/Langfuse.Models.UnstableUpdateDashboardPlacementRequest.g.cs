
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableUpdateDashboardPlacementRequest
    {
        /// <summary>
        /// Grid column (12-column grid).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public int? X { get; set; }

        /// <summary>
        /// Grid row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public int? Y { get; set; }

        /// <summary>
        /// Width in grid columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height in grid rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableUpdateDashboardPlacementRequest" /> class.
        /// </summary>
        /// <param name="x">
        /// Grid column (12-column grid).
        /// </param>
        /// <param name="y">
        /// Grid row.
        /// </param>
        /// <param name="width">
        /// Width in grid columns.
        /// </param>
        /// <param name="height">
        /// Height in grid rows.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableUpdateDashboardPlacementRequest(
            int? x,
            int? y,
            int? width,
            int? height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableUpdateDashboardPlacementRequest" /> class.
        /// </summary>
        public UnstableUpdateDashboardPlacementRequest()
        {
        }

    }
}