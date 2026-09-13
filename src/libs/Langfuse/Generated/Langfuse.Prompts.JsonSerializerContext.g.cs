
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UtilsMetaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptMetaListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.PromptMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptType), TypeInfoPropertyName = "PromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreatePromptRequest), TypeInfoPropertyName = "CreatePromptRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateChatPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateTextPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.ChatMessageWithPlaceholders>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessageWithPlaceholders), TypeInfoPropertyName = "ChatMessageWithPlaceholders2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateChatPromptType), TypeInfoPropertyName = "CreateChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateTextPromptType), TypeInfoPropertyName = "CreateTextPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Prompt), TypeInfoPropertyName = "Prompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>), TypeInfoPropertyName = "AllOfPromptChatPrompt2ChatPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptChatPrompt2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptChatPromptType), TypeInfoPropertyName = "PromptChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>), TypeInfoPropertyName = "AllOfPromptTextPrompt2TextPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptTextPrompt2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptTextPromptType), TypeInfoPropertyName = "PromptTextPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.TextPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BasePrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PlaceholderMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessageType), TypeInfoPropertyName = "ChatMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PlaceholderMessageType), TypeInfoPropertyName = "PlaceholderMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptType?), TypeInfoPropertyName = "NullablePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreatePromptRequest?), TypeInfoPropertyName = "NullableCreatePromptRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessageWithPlaceholders?), TypeInfoPropertyName = "NullableChatMessageWithPlaceholders2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateChatPromptType?), TypeInfoPropertyName = "NullableCreateChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateTextPromptType?), TypeInfoPropertyName = "NullableCreateTextPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.Prompt?), TypeInfoPropertyName = "NullablePrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>?), TypeInfoPropertyName = "NullableAllOfPromptChatPrompt2ChatPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptChatPromptType?), TypeInfoPropertyName = "NullablePromptChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>?), TypeInfoPropertyName = "NullableAllOfPromptTextPrompt2TextPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PromptTextPromptType?), TypeInfoPropertyName = "NullablePromptTextPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.ChatMessageType?), TypeInfoPropertyName = "NullableChatMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.PlaceholderMessageType?), TypeInfoPropertyName = "NullablePlaceholderMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.PromptMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.ChatMessageWithPlaceholders>))]
    internal sealed partial class PromptsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PromptsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PromptsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Langfuse.JsonConverters.CreatePromptRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.PromptJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.ChatMessageWithPlaceholdersJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptChatPrompt2, global::Langfuse.ChatPrompt>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.PromptTextPrompt2, global::Langfuse.TextPrompt>());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Langfuse.PromptChatPromptType)

                    || typeToConvert == typeof(global::Langfuse.PromptChatPromptType?)

                    || typeToConvert == typeof(global::Langfuse.PromptTextPromptType)

                    || typeToConvert == typeof(global::Langfuse.PromptTextPromptType?)

                    || typeToConvert == typeof(global::Langfuse.PromptType)

                    || typeToConvert == typeof(global::Langfuse.PromptType?)

                    || typeToConvert == typeof(global::Langfuse.ChatMessageType)

                    || typeToConvert == typeof(global::Langfuse.ChatMessageType?)

                    || typeToConvert == typeof(global::Langfuse.PlaceholderMessageType)

                    || typeToConvert == typeof(global::Langfuse.PlaceholderMessageType?)

                    || typeToConvert == typeof(global::Langfuse.CreateChatPromptType)

                    || typeToConvert == typeof(global::Langfuse.CreateChatPromptType?)

                    || typeToConvert == typeof(global::Langfuse.CreateTextPromptType)

                    || typeToConvert == typeof(global::Langfuse.CreateTextPromptType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.PromptChatPromptType))
                {
                    return new global::Langfuse.JsonConverters.PromptChatPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptChatPromptType?))
                {
                    return new global::Langfuse.JsonConverters.PromptChatPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptTextPromptType))
                {
                    return new global::Langfuse.JsonConverters.PromptTextPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptTextPromptType?))
                {
                    return new global::Langfuse.JsonConverters.PromptTextPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptType))
                {
                    return new global::Langfuse.JsonConverters.PromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PromptType?))
                {
                    return new global::Langfuse.JsonConverters.PromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ChatMessageType))
                {
                    return new global::Langfuse.JsonConverters.ChatMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.ChatMessageType?))
                {
                    return new global::Langfuse.JsonConverters.ChatMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PlaceholderMessageType))
                {
                    return new global::Langfuse.JsonConverters.PlaceholderMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.PlaceholderMessageType?))
                {
                    return new global::Langfuse.JsonConverters.PlaceholderMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateChatPromptType))
                {
                    return new global::Langfuse.JsonConverters.CreateChatPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateChatPromptType?))
                {
                    return new global::Langfuse.JsonConverters.CreateChatPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateTextPromptType))
                {
                    return new global::Langfuse.JsonConverters.CreateTextPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.CreateTextPromptType?))
                {
                    return new global::Langfuse.JsonConverters.CreateTextPromptTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new PromptsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}