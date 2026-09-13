
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationType), TypeInfoPropertyName = "BlobStorageIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationFileType), TypeInfoPropertyName = "BlobStorageIntegrationFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse), TypeInfoPropertyName = "BlobStorageIntegrationFileTypeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportMode), TypeInfoPropertyName = "BlobStorageExportMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportFrequency), TypeInfoPropertyName = "BlobStorageExportFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportSource), TypeInfoPropertyName = "BlobStorageExportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportFieldGroup), TypeInfoPropertyName = "BlobStorageExportFieldGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.CreateBlobStorageIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.BlobStorageExportFieldGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.BlobStorageIntegrationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageSyncStatus), TypeInfoPropertyName = "BlobStorageSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationDeletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationType?), TypeInfoPropertyName = "NullableBlobStorageIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationFileType?), TypeInfoPropertyName = "NullableBlobStorageIntegrationFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse?), TypeInfoPropertyName = "NullableBlobStorageIntegrationFileTypeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportMode?), TypeInfoPropertyName = "NullableBlobStorageExportMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportFrequency?), TypeInfoPropertyName = "NullableBlobStorageExportFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportSource?), TypeInfoPropertyName = "NullableBlobStorageExportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageExportFieldGroup?), TypeInfoPropertyName = "NullableBlobStorageExportFieldGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.BlobStorageSyncStatus?), TypeInfoPropertyName = "NullableBlobStorageSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.BlobStorageExportFieldGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.BlobStorageIntegrationResponse>))]
    internal sealed partial class BlobStorageIntegrationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BlobStorageIntegrationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BlobStorageIntegrationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BlobStorageIntegrationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationType)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationType?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileType)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileType?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportMode)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportMode?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportFrequency)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportFrequency?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportSource)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportSource?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportFieldGroup)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageExportFieldGroup?)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageSyncStatus)

                    || typeToConvert == typeof(global::Langfuse.BlobStorageSyncStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationType))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationType?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileType))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileType?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeResponseJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageIntegrationFileTypeResponse?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageIntegrationFileTypeResponseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportMode))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportMode?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportFrequency))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportFrequencyJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportFrequency?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportFrequencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportSource))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportSource?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportFieldGroup))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportFieldGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageExportFieldGroup?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageExportFieldGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageSyncStatus))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.BlobStorageSyncStatus?))
                {
                    return new global::Langfuse.JsonConverters.BlobStorageSyncStatusNullableJsonConverter();
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
                    0 => new BlobStorageIntegrationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}