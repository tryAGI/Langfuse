
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetView), TypeInfoPropertyName = "UnstableDashboardWidgetView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy), TypeInfoPropertyName = "UnstableDashboardWidgetViewWithLegacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetChartType), TypeInfoPropertyName = "UnstableDashboardWidgetChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation), TypeInfoPropertyName = "UnstableDashboardWidgetMetricAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetChartConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetDefaultSort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetSortOrder), TypeInfoPropertyName = "UnstableDashboardWidgetSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetChartConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableCreateDashboardWidgetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidgetFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableUpdateDashboardWidgetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstableDashboardWidget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDeleteDashboardWidgetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorCode), TypeInfoPropertyName = "UnstablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Langfuse.UnstablePublicApiValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetView?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetViewWithLegacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetChartType?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetMetricAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstableDashboardWidgetSortOrder?), TypeInfoPropertyName = "NullableUnstableDashboardWidgetSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Langfuse.UnstablePublicApiErrorCode?), TypeInfoPropertyName = "NullableUnstablePublicApiErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidgetFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstableDashboardWidget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Langfuse.UnstablePublicApiValidationIssue>))]
    internal sealed partial class UnstableDashboardWidgetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnstableDashboardWidgetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UnstableDashboardWidgetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UnstableDashboardWidgetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetView)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetView?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetChartType)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetChartType?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation?)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetSortOrder)

                    || typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetSortOrder?)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode)

                    || typeToConvert == typeof(global::Langfuse.UnstablePublicApiErrorCode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetView))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetView?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetViewWithLegacyJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetViewWithLegacy?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetViewWithLegacyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetChartType))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetChartType?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetMetricAggregationJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetMetricAggregation?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetMetricAggregationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetSortOrder))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Langfuse.UnstableDashboardWidgetSortOrder?))
                {
                    return new global::Langfuse.JsonConverters.UnstableDashboardWidgetSortOrderNullableJsonConverter();
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
                    0 => new UnstableDashboardWidgetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}