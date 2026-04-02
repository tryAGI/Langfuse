#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class IngestionEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.IngestionEvent>
    {
        /// <inheritdoc />
        public override global::Langfuse.IngestionEvent Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>), options);
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

            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>? ingestionEventVariant1 = default;
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>? ingestionEventVariant2 = default;
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>? ingestionEventVariant3 = default;
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>? ingestionEventVariant4 = default;
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>? ingestionEventVariant5 = default;
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>? ingestionEventVariant6 = default;
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>? ingestionEventVariant7 = default;
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>? ingestionEventVariant8 = default;
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>? ingestionEventVariant9 = default;
            global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>? ingestionEventVariant10 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>).Name}");
                        ingestionEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>).Name}");
                        ingestionEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>).Name}");
                        ingestionEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>).Name}");
                        ingestionEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>).Name}");
                        ingestionEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>).Name}");
                        ingestionEventVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>).Name}");
                        ingestionEventVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>).Name}");
                        ingestionEventVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>).Name}");
                        ingestionEventVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>).Name}");
                        ingestionEventVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (ingestionEventVariant1 == null && ingestionEventVariant2 == null && ingestionEventVariant3 == null && ingestionEventVariant4 == null && ingestionEventVariant5 == null && ingestionEventVariant6 == null && ingestionEventVariant7 == null && ingestionEventVariant8 == null && ingestionEventVariant9 == null && ingestionEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>).Name}");
                    ingestionEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>).Name}");
                    ingestionEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>).Name}");
                    ingestionEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>).Name}");
                    ingestionEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>).Name}");
                    ingestionEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>).Name}");
                    ingestionEventVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>).Name}");
                    ingestionEventVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>).Name}");
                    ingestionEventVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>).Name}");
                    ingestionEventVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>).Name}");
                    ingestionEventVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Langfuse.IngestionEvent(
                ingestionEventVariant1,

                ingestionEventVariant2,

                ingestionEventVariant3,

                ingestionEventVariant4,

                ingestionEventVariant5,

                ingestionEventVariant6,

                ingestionEventVariant7,

                ingestionEventVariant8,

                ingestionEventVariant9,

                ingestionEventVariant10
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.IngestionEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsIngestionEventVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant12, global::Langfuse.TraceEvent>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IngestionEventVariant1!.Value, typeInfo);
            }
            else if (value.IsIngestionEventVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant22, global::Langfuse.ScoreEvent>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IngestionEventVariant2!.Value, typeInfo);
            }
            else if (value.IsIngestionEventVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant32, global::Langfuse.CreateSpanEvent>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IngestionEventVariant3!.Value, typeInfo);
            }
            else if (value.IsIngestionEventVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant42, global::Langfuse.UpdateSpanEvent>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IngestionEventVariant4!.Value, typeInfo);
            }
            else if (value.IsIngestionEventVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant52, global::Langfuse.CreateGenerationEvent>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IngestionEventVariant5!.Value, typeInfo);
            }
            else if (value.IsIngestionEventVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant62, global::Langfuse.UpdateGenerationEvent>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IngestionEventVariant6!.Value, typeInfo);
            }
            else if (value.IsIngestionEventVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant72, global::Langfuse.CreateEventEvent>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IngestionEventVariant7!.Value, typeInfo);
            }
            else if (value.IsIngestionEventVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant82, global::Langfuse.SDKLogEvent>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IngestionEventVariant8!.Value, typeInfo);
            }
            else if (value.IsIngestionEventVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant92, global::Langfuse.CreateObservationEvent>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IngestionEventVariant9!.Value, typeInfo);
            }
            else if (value.IsIngestionEventVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.IngestionEventVariant102, global::Langfuse.UpdateObservationEvent>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IngestionEventVariant10!.Value, typeInfo);
            }
        }
    }
}