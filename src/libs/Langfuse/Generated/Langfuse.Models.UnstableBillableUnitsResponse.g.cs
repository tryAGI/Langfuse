
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableBillableUnitsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Langfuse.UnstableBillableUnitsRow> Data { get; set; }

        /// <summary>
        /// When usage recording started on this deployment. Buckets before it show no usage. Null while nothing has been recorded, and on deployments that count the legacy tables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageRecordedFrom")]
        public global::System.DateTime? UsageRecordedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableBillableUnitsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="usageRecordedFrom">
        /// When usage recording started on this deployment. Buckets before it show no usage. Null while nothing has been recorded, and on deployments that count the legacy tables.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableBillableUnitsResponse(
            global::System.Collections.Generic.IList<global::Langfuse.UnstableBillableUnitsRow> data,
            global::System.DateTime? usageRecordedFrom)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.UsageRecordedFrom = usageRecordedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableBillableUnitsResponse" /> class.
        /// </summary>
        public UnstableBillableUnitsResponse()
        {
        }

    }
}