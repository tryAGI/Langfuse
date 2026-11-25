#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Langfuse.JsonConverters
{
    /// <inheritdoc />
    public class DecisionModelQuestionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Langfuse.DecisionModelQuestion>
    {
        /// <inheritdoc />
        public override global::Langfuse.DecisionModelQuestion Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>? decisionModelChoiceQuestion = default;
            global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>? decisionModelScoreQuestion = default;
            global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>? decisionModelBooleanQuestion = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>).Name}");
                        decisionModelChoiceQuestion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>).Name}");
                        decisionModelScoreQuestion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>).Name}");
                        decisionModelBooleanQuestion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (decisionModelChoiceQuestion == null && decisionModelScoreQuestion == null && decisionModelBooleanQuestion == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>).Name}");
                    decisionModelChoiceQuestion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (decisionModelChoiceQuestion == null && decisionModelScoreQuestion == null && decisionModelBooleanQuestion == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>).Name}");
                    decisionModelScoreQuestion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (decisionModelChoiceQuestion == null && decisionModelScoreQuestion == null && decisionModelBooleanQuestion == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>).Name}");
                    decisionModelBooleanQuestion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Langfuse.DecisionModelQuestion(
                decisionModelChoiceQuestion,

                decisionModelScoreQuestion,

                decisionModelBooleanQuestion
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Langfuse.DecisionModelQuestion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDecisionModelChoiceQuestion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDecisionModelChoiceQuestion(), typeInfo);
            }
            else if (value.IsDecisionModelScoreQuestion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDecisionModelScoreQuestion(), typeInfo);
            }
            else if (value.IsDecisionModelBooleanQuestion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDecisionModelBooleanQuestion(), typeInfo);
            }
        }
    }
}