#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class UnstableEvaluationRuleFilterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.UnstableEvaluationRuleFilter>
    {
        /// <inheritdoc />
        public override global::Langfuse.UnstableEvaluationRuleFilter Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __score5 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score5++;
                    }
                }
            }
            var __score6 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score6++;
                    }
                }
            }
            var __score7 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score7++;
                    }
                }
            }
            var __score8 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score8++;
                    }
                }
            }
            var __score9 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score9++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }

            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? unstableDateTimeEvaluationRuleFilter = default;
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>? unstableStringEvaluationRuleFilter = default;
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>? unstableNumberEvaluationRuleFilter = default;
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? unstableStringOptionsEvaluationRuleFilter = default;
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? unstableCategoryOptionsEvaluationRuleFilter = default;
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? unstableArrayOptionsEvaluationRuleFilter = default;
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? unstableStringObjectEvaluationRuleFilter = default;
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? unstableNumberObjectEvaluationRuleFilter = default;
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? unstableBooleanEvaluationRuleFilter = default;
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>? unstableNullEvaluationRuleFilter = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>).Name}");
                        unstableDateTimeEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>).Name}");
                        unstableStringEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>).Name}");
                        unstableNumberEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>).Name}");
                        unstableStringOptionsEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>).Name}");
                        unstableCategoryOptionsEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 5)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>).Name}");
                        unstableArrayOptionsEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 6)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>).Name}");
                        unstableStringObjectEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 7)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>).Name}");
                        unstableNumberObjectEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 8)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>).Name}");
                        unstableBooleanEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 9)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>).Name}");
                        unstableNullEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (unstableDateTimeEvaluationRuleFilter == null && unstableStringEvaluationRuleFilter == null && unstableNumberEvaluationRuleFilter == null && unstableStringOptionsEvaluationRuleFilter == null && unstableCategoryOptionsEvaluationRuleFilter == null && unstableArrayOptionsEvaluationRuleFilter == null && unstableStringObjectEvaluationRuleFilter == null && unstableNumberObjectEvaluationRuleFilter == null && unstableBooleanEvaluationRuleFilter == null && unstableNullEvaluationRuleFilter == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>).Name}");
                    unstableDateTimeEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableDateTimeEvaluationRuleFilter == null && unstableStringEvaluationRuleFilter == null && unstableNumberEvaluationRuleFilter == null && unstableStringOptionsEvaluationRuleFilter == null && unstableCategoryOptionsEvaluationRuleFilter == null && unstableArrayOptionsEvaluationRuleFilter == null && unstableStringObjectEvaluationRuleFilter == null && unstableNumberObjectEvaluationRuleFilter == null && unstableBooleanEvaluationRuleFilter == null && unstableNullEvaluationRuleFilter == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>).Name}");
                    unstableStringEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableDateTimeEvaluationRuleFilter == null && unstableStringEvaluationRuleFilter == null && unstableNumberEvaluationRuleFilter == null && unstableStringOptionsEvaluationRuleFilter == null && unstableCategoryOptionsEvaluationRuleFilter == null && unstableArrayOptionsEvaluationRuleFilter == null && unstableStringObjectEvaluationRuleFilter == null && unstableNumberObjectEvaluationRuleFilter == null && unstableBooleanEvaluationRuleFilter == null && unstableNullEvaluationRuleFilter == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>).Name}");
                    unstableNumberEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableDateTimeEvaluationRuleFilter == null && unstableStringEvaluationRuleFilter == null && unstableNumberEvaluationRuleFilter == null && unstableStringOptionsEvaluationRuleFilter == null && unstableCategoryOptionsEvaluationRuleFilter == null && unstableArrayOptionsEvaluationRuleFilter == null && unstableStringObjectEvaluationRuleFilter == null && unstableNumberObjectEvaluationRuleFilter == null && unstableBooleanEvaluationRuleFilter == null && unstableNullEvaluationRuleFilter == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>).Name}");
                    unstableStringOptionsEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableDateTimeEvaluationRuleFilter == null && unstableStringEvaluationRuleFilter == null && unstableNumberEvaluationRuleFilter == null && unstableStringOptionsEvaluationRuleFilter == null && unstableCategoryOptionsEvaluationRuleFilter == null && unstableArrayOptionsEvaluationRuleFilter == null && unstableStringObjectEvaluationRuleFilter == null && unstableNumberObjectEvaluationRuleFilter == null && unstableBooleanEvaluationRuleFilter == null && unstableNullEvaluationRuleFilter == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>).Name}");
                    unstableCategoryOptionsEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableDateTimeEvaluationRuleFilter == null && unstableStringEvaluationRuleFilter == null && unstableNumberEvaluationRuleFilter == null && unstableStringOptionsEvaluationRuleFilter == null && unstableCategoryOptionsEvaluationRuleFilter == null && unstableArrayOptionsEvaluationRuleFilter == null && unstableStringObjectEvaluationRuleFilter == null && unstableNumberObjectEvaluationRuleFilter == null && unstableBooleanEvaluationRuleFilter == null && unstableNullEvaluationRuleFilter == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>).Name}");
                    unstableArrayOptionsEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableDateTimeEvaluationRuleFilter == null && unstableStringEvaluationRuleFilter == null && unstableNumberEvaluationRuleFilter == null && unstableStringOptionsEvaluationRuleFilter == null && unstableCategoryOptionsEvaluationRuleFilter == null && unstableArrayOptionsEvaluationRuleFilter == null && unstableStringObjectEvaluationRuleFilter == null && unstableNumberObjectEvaluationRuleFilter == null && unstableBooleanEvaluationRuleFilter == null && unstableNullEvaluationRuleFilter == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>).Name}");
                    unstableStringObjectEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableDateTimeEvaluationRuleFilter == null && unstableStringEvaluationRuleFilter == null && unstableNumberEvaluationRuleFilter == null && unstableStringOptionsEvaluationRuleFilter == null && unstableCategoryOptionsEvaluationRuleFilter == null && unstableArrayOptionsEvaluationRuleFilter == null && unstableStringObjectEvaluationRuleFilter == null && unstableNumberObjectEvaluationRuleFilter == null && unstableBooleanEvaluationRuleFilter == null && unstableNullEvaluationRuleFilter == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>).Name}");
                    unstableNumberObjectEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableDateTimeEvaluationRuleFilter == null && unstableStringEvaluationRuleFilter == null && unstableNumberEvaluationRuleFilter == null && unstableStringOptionsEvaluationRuleFilter == null && unstableCategoryOptionsEvaluationRuleFilter == null && unstableArrayOptionsEvaluationRuleFilter == null && unstableStringObjectEvaluationRuleFilter == null && unstableNumberObjectEvaluationRuleFilter == null && unstableBooleanEvaluationRuleFilter == null && unstableNullEvaluationRuleFilter == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>).Name}");
                    unstableBooleanEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (unstableDateTimeEvaluationRuleFilter == null && unstableStringEvaluationRuleFilter == null && unstableNumberEvaluationRuleFilter == null && unstableStringOptionsEvaluationRuleFilter == null && unstableCategoryOptionsEvaluationRuleFilter == null && unstableArrayOptionsEvaluationRuleFilter == null && unstableStringObjectEvaluationRuleFilter == null && unstableNumberObjectEvaluationRuleFilter == null && unstableBooleanEvaluationRuleFilter == null && unstableNullEvaluationRuleFilter == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>).Name}");
                    unstableNullEvaluationRuleFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.UnstableEvaluationRuleFilter(
                unstableDateTimeEvaluationRuleFilter,

                unstableStringEvaluationRuleFilter,

                unstableNumberEvaluationRuleFilter,

                unstableStringOptionsEvaluationRuleFilter,

                unstableCategoryOptionsEvaluationRuleFilter,

                unstableArrayOptionsEvaluationRuleFilter,

                unstableStringObjectEvaluationRuleFilter,

                unstableNumberObjectEvaluationRuleFilter,

                unstableBooleanEvaluationRuleFilter,

                unstableNullEvaluationRuleFilter
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.UnstableEvaluationRuleFilter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnstableDateTimeEvaluationRuleFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableDateTimeEvaluationRuleFilter!.Value, typeInfo);
            }
            else if (value.IsUnstableStringEvaluationRuleFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableStringEvaluationRuleFilter!.Value, typeInfo);
            }
            else if (value.IsUnstableNumberEvaluationRuleFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableNumberEvaluationRuleFilter!.Value, typeInfo);
            }
            else if (value.IsUnstableStringOptionsEvaluationRuleFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableStringOptionsEvaluationRuleFilter!.Value, typeInfo);
            }
            else if (value.IsUnstableCategoryOptionsEvaluationRuleFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableCategoryOptionsEvaluationRuleFilter!.Value, typeInfo);
            }
            else if (value.IsUnstableArrayOptionsEvaluationRuleFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableArrayOptionsEvaluationRuleFilter!.Value, typeInfo);
            }
            else if (value.IsUnstableStringObjectEvaluationRuleFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableStringObjectEvaluationRuleFilter!.Value, typeInfo);
            }
            else if (value.IsUnstableNumberObjectEvaluationRuleFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableNumberObjectEvaluationRuleFilter!.Value, typeInfo);
            }
            else if (value.IsUnstableBooleanEvaluationRuleFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableBooleanEvaluationRuleFilter!.Value, typeInfo);
            }
            else if (value.IsUnstableNullEvaluationRuleFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnstableNullEvaluationRuleFilter!.Value, typeInfo);
            }
        }
    }
}