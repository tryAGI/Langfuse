
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacement), TypeInfoPropertyName = "UnstableDashboardPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>), TypeInfoPropertyName = "AllOfUnstableDashboardPlacementUnstableWidgetPlacement2UnstableWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType), TypeInfoPropertyName = "UnstableDashboardPlacementUnstableWidgetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableWidgetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>), TypeInfoPropertyName = "AllOfUnstableDashboardPlacementUnstablePresetPlacement2UnstablePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType), TypeInfoPropertyName = "UnstableDashboardPlacementUnstablePresetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePresetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequest), TypeInfoPropertyName = "UnstableCreateDashboardPlacementRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>), TypeInfoPropertyName = "AllOfUnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2UnstableCreateWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType), TypeInfoPropertyName = "UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateWidgetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>), TypeInfoPropertyName = "AllOfUnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2UnstableCreatePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType), TypeInfoPropertyName = "UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreatePresetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableUpdateDashboardPlacementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDeleteDashboardPlacementResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardPlacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableUpdateDashboardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDeleteDashboardResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorCode), TypeInfoPropertyName = "UnstablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacement?), TypeInfoPropertyName = "NullableUnstableDashboardPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableDashboardPlacementUnstableWidgetPlacement2UnstableWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType?), TypeInfoPropertyName = "NullableUnstableDashboardPlacementUnstableWidgetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableDashboardPlacementUnstablePresetPlacement2UnstablePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType?), TypeInfoPropertyName = "NullableUnstableDashboardPlacementUnstablePresetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequest?), TypeInfoPropertyName = "NullableUnstableCreateDashboardPlacementRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2UnstableCreateWidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType?), TypeInfoPropertyName = "NullableUnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>?), TypeInfoPropertyName = "NullableAllOfUnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2UnstableCreatePresetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType?), TypeInfoPropertyName = "NullableUnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorCode?), TypeInfoPropertyName = "NullableUnstablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardPlacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstablePublicApiValidationIssue>))]
    internal sealed partial class UnstableDashboardsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableDashboardsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UnstableDashboardsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UnstableDashboardsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableDashboardPlacementJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestJsonConverter());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacement2, global::Langfuse.UnstableWidgetPlacement>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacement2, global::Langfuse.UnstablePresetPlacement>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacement2, global::Langfuse.UnstableCreateWidgetPlacement>());
            options.Converters.Add(new global::Langfuse.JsonConverters.AllOfJsonConverter<global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacement2, global::Langfuse.UnstableCreatePresetPlacement>());
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
                    typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType)

                    || typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType?)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementUnstableWidgetPlacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstableWidgetPlacementType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementUnstableWidgetPlacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementUnstablePresetPlacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardPlacementUnstablePresetPlacementType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardPlacementUnstablePresetPlacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestUnstableCreateWidgetPlacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableCreateDashboardPlacementRequestUnstableCreatePresetPlacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode?))
                {
                    return new global::Langfuse.JsonConverters.UnstablePublicApiErrorCodeNullableJsonConverter();
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
                    0 => new UnstableDashboardsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}