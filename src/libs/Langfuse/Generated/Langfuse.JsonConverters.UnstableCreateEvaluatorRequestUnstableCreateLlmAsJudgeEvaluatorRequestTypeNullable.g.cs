#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequestTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequestType?>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequestType? Read(
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
                        return global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequestTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequestType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequestType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequestType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequestTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
