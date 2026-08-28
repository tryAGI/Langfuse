#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType Read(
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
                        return global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilterTypeExtensions.ToValueString(value));
        }
    }
}
