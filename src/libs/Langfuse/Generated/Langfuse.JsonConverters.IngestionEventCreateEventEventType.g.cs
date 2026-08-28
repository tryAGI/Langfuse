#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class IngestionEventCreateEventEventTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.IngestionEventCreateEventEventType>
    {
        /// <inheritdoc />
        public override global::Langfuse.IngestionEventCreateEventEventType Read(
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
                        return global::Langfuse.IngestionEventCreateEventEventTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.IngestionEventCreateEventEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.IngestionEventCreateEventEventType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.IngestionEventCreateEventEventType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.IngestionEventCreateEventEventTypeExtensions.ToValueString(value));
        }
    }
}
