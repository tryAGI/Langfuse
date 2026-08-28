#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType?>
    {
        /// <inheritdoc />
        public override global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType? Read(
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
                        return global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScoreDataTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
