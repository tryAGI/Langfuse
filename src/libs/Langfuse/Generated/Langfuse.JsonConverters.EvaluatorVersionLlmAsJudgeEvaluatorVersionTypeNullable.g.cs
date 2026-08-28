#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class EvaluatorVersionLlmAsJudgeEvaluatorVersionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType?>
    {
        /// <inheritdoc />
        public override global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType? Read(
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
                        return global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
