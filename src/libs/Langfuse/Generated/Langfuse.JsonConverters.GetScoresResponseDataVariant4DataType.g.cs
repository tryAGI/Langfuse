#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetScoresResponseDataVariant4DataTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.GetScoresResponseDataVariant4DataType>
    {
        /// <inheritdoc />
        public override global::Langfuse.GetScoresResponseDataVariant4DataType Read(
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
                        return global::Langfuse.GetScoresResponseDataVariant4DataTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.GetScoresResponseDataVariant4DataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.GetScoresResponseDataVariant4DataType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.GetScoresResponseDataVariant4DataType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.GetScoresResponseDataVariant4DataTypeExtensions.ToValueString(value));
        }
    }
}
