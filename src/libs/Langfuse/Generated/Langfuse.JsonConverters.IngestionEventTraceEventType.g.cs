#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class IngestionEventTraceEventTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.IngestionEventTraceEventType>
    {
        /// <inheritdoc />
        public override global::Langfuse.IngestionEventTraceEventType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Langfuse.IngestionEventTraceEventTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.IngestionEventTraceEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.IngestionEventTraceEventType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.IngestionEventTraceEventType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.IngestionEventTraceEventTypeExtensions.ToValueString(value));
        }
    }
}
