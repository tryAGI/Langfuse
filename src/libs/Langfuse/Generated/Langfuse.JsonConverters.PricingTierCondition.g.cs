#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class PricingTierConditionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.PricingTierCondition>
    {
        /// <inheritdoc />
        public override global::Langfuse.PricingTierCondition Read(
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
            if (__jsonProps.Contains("caseSensitive")) __score0++;
            if (__jsonProps.Contains("operator")) __score0++;
            if (__jsonProps.Contains("usageDetailPattern")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("key")) __score1++;
            if (__jsonProps.Contains("operator")) __score1++;
            if (__jsonProps.Contains("source")) __score1++;
            if (__jsonProps.Contains("values")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Langfuse.PricingTierUsageCondition? pricingTierUsageCondition = default;
            global::Langfuse.PricingTierAttributeCondition? pricingTierAttributeCondition = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.PricingTierUsageCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.PricingTierUsageCondition> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.PricingTierUsageCondition).Name}");
                        pricingTierUsageCondition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.PricingTierAttributeCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.PricingTierAttributeCondition> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.PricingTierAttributeCondition).Name}");
                        pricingTierAttributeCondition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pricingTierUsageCondition == null && pricingTierAttributeCondition == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.PricingTierUsageCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.PricingTierUsageCondition> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.PricingTierUsageCondition).Name}");
                    pricingTierUsageCondition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (pricingTierUsageCondition == null && pricingTierAttributeCondition == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.PricingTierAttributeCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.PricingTierAttributeCondition> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.PricingTierAttributeCondition).Name}");
                    pricingTierAttributeCondition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.PricingTierCondition(
                pricingTierUsageCondition,

                pricingTierAttributeCondition
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.PricingTierCondition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPricingTierUsageCondition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.PricingTierUsageCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.PricingTierUsageCondition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.PricingTierUsageCondition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PricingTierUsageCondition!, typeInfo);
            }
            else if (value.IsPricingTierAttributeCondition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.PricingTierAttributeCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.PricingTierAttributeCondition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.PricingTierAttributeCondition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PricingTierAttributeCondition!, typeInfo);
            }
        }
    }
}