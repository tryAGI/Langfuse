
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// A filter in Langfuse filter-state shape. The `value` shape and the<br/>
    /// allowed operators depend on `type`:<br/>
    /// | `type` | `value` | operators |<br/>
    /// |---|---|---|<br/>
    /// | `string` | string | `=`, `contains`, `does not contain`, `starts with`, `ends with` |<br/>
    /// | `number` | number | `=`, `&gt;`, `&lt;`, `&gt;=`, `&lt;=` |<br/>
    /// | `datetime` | ISO datetime string | `&gt;`, `&lt;`, `&gt;=`, `&lt;=` |<br/>
    /// | `boolean` | boolean | `=`, `&lt;&gt;` |<br/>
    /// | `null` | `""` | `is null`, `is not null` |<br/>
    /// | `stringOptions` | list of strings | `any of`, `none of` |<br/>
    /// | `arrayOptions` | list of strings | `any of`, `none of`, `all of` |<br/>
    /// | `categoryOptions` | list of strings (requires `key`) | `any of`, `none of` |<br/>
    /// | `stringObject` | string (requires `key`, e.g. a metadata key) | same as `string` |<br/>
    /// | `numberObject` | number (requires `key`, e.g. a score name) | same as `number` |<br/>
    /// | `booleanObject` | boolean (requires `key`) | `=`, `&lt;&gt;` |
    /// </summary>
    public sealed partial class UnstableDashboardWidgetFilter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidgetFilter" /> class.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="operator"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="key"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnstableDashboardWidgetFilter(
            string column,
            string @operator,
            string type,
            object? value,
            string? key)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnstableDashboardWidgetFilter" /> class.
        /// </summary>
        public UnstableDashboardWidgetFilter()
        {
        }

    }
}