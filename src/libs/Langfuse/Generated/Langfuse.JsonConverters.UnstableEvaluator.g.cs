#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class UnstableEvaluatorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableEvaluator>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableEvaluator Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>? unstableEvaluatorVariant1 = default;
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>? unstableEvaluatorVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>).Name}");
                        unstableEvaluatorVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>).Name}");
                        unstableEvaluatorVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (unstableEvaluatorVariant1 == null && unstableEvaluatorVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>).Name}");
                    unstableEvaluatorVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableEvaluatorVariant1 == null && unstableEvaluatorVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>).Name}");
                    unstableEvaluatorVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.UnstableEvaluator(
                unstableEvaluatorVariant1,

                unstableEvaluatorVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableEvaluator value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnstableEvaluatorVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableEvaluatorVariant1!.Value, typeInfo);
            }
            else if (value.IsUnstableEvaluatorVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableEvaluatorVariant2!.Value, typeInfo);
            }
        }
    }
}