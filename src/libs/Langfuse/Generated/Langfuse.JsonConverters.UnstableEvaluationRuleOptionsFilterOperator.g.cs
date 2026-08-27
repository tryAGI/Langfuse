#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnstableEvaluationRuleOptionsFilterOperatorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator Read(
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
                        return global::Langfuse.UnstableEvaluationRuleOptionsFilterOperatorExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableEvaluationRuleOptionsFilterOperator value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.UnstableEvaluationRuleOptionsFilterOperatorExtensions.ToValueString(value));
        }
    }
}
