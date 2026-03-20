#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class IngestionUsageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.IngestionUsage>
    {
        /// <inheritdoc />
        public override global::Langfuse.IngestionUsage Read(
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
            if (__jsonProps.Contains("input")) __score0++;
            if (__jsonProps.Contains("output")) __score0++;
            if (__jsonProps.Contains("total")) __score0++;
            if (__jsonProps.Contains("unit")) __score0++;
            if (__jsonProps.Contains("inputCost")) __score0++;
            if (__jsonProps.Contains("outputCost")) __score0++;
            if (__jsonProps.Contains("totalCost")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("promptTokens")) __score1++;
            if (__jsonProps.Contains("completionTokens")) __score1++;
            if (__jsonProps.Contains("totalTokens")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Langfuse.Usage? usage = default;
            global::Langfuse.OpenAIUsage? openAIUsage = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.Usage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.Usage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.Usage).Name}");
                        usage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.OpenAIUsage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.OpenAIUsage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.OpenAIUsage).Name}");
                        openAIUsage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (usage == null && openAIUsage == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.Usage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.Usage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.Usage).Name}");
                    usage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.OpenAIUsage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.OpenAIUsage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.OpenAIUsage).Name}");
                    openAIUsage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.IngestionUsage(
                usage,

                openAIUsage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.IngestionUsage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUsage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.Usage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.Usage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.Usage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Usage, typeInfo);
            }
            else if (value.IsOpenAIUsage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.OpenAIUsage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.OpenAIUsage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.OpenAIUsage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIUsage, typeInfo);
            }
        }
    }
}