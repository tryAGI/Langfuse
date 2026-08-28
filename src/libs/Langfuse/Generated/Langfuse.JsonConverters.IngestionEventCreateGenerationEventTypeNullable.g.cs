#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class IngestionEventCreateGenerationEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.IngestionEventCreateGenerationEventType?>
    {
        /// <inheritdoc />
        public override global::Langfuse.IngestionEventCreateGenerationEventType? Read(
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
                        return global::Langfuse.IngestionEventCreateGenerationEventTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.IngestionEventCreateGenerationEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.IngestionEventCreateGenerationEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.IngestionEventCreateGenerationEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Langfuse.IngestionEventCreateGenerationEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
