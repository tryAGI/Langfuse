#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class UnstableReadableEvaluationRuleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableReadableEvaluationRule>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableReadableEvaluationRule Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("evaluators")) __score0++;
            if (__jsonProps.Contains("filter")) __score0++;
            if (__jsonProps.Contains("mapping")) __score0++;
            if (__jsonProps.Contains("target")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("delay")) __score1++;
            if (__jsonProps.Contains("evaluators")) __score1++;
            if (__jsonProps.Contains("filter")) __score1++;
            if (__jsonProps.Contains("mapping")) __score1++;
            if (__jsonProps.Contains("target")) __score1++;
            if (__jsonProps.Contains("timeScope")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Langfuse.UnstableEvaluationRule? unstableEvaluationRule = default;
            global::Langfuse.UnstableLegacyEvaluationRule? unstableLegacyEvaluationRule = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UnstableEvaluationRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UnstableEvaluationRule> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UnstableEvaluationRule).Name}");
                        unstableEvaluationRule = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UnstableLegacyEvaluationRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UnstableLegacyEvaluationRule> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UnstableLegacyEvaluationRule).Name}");
                        unstableLegacyEvaluationRule = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (unstableEvaluationRule == null && unstableLegacyEvaluationRule == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UnstableEvaluationRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UnstableEvaluationRule> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UnstableEvaluationRule).Name}");
                    unstableEvaluationRule = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableEvaluationRule == null && unstableLegacyEvaluationRule == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UnstableLegacyEvaluationRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UnstableLegacyEvaluationRule> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UnstableLegacyEvaluationRule).Name}");
                    unstableLegacyEvaluationRule = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.UnstableReadableEvaluationRule(
                unstableEvaluationRule,

                unstableLegacyEvaluationRule
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableReadableEvaluationRule value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnstableEvaluationRule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UnstableEvaluationRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UnstableEvaluationRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UnstableEvaluationRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableEvaluationRule!, typeInfo);
            }
            else if (value.IsUnstableLegacyEvaluationRule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.UnstableLegacyEvaluationRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.UnstableLegacyEvaluationRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.UnstableLegacyEvaluationRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableLegacyEvaluationRule!, typeInfo);
            }
        }
    }
}