#nullable enable

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnstableEvaluationRuleTimeScopeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableEvaluationRuleTimeScope>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableEvaluationRuleTimeScope Read(
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
                        return global::Langfuse.UnstableEvaluationRuleTimeScopeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Langfuse.UnstableEvaluationRuleTimeScope)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Langfuse.UnstableEvaluationRuleTimeScope);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableEvaluationRuleTimeScope value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Langfuse.UnstableEvaluationRuleTimeScopeExtensions.ToValueString(value));
        }
    }
}
