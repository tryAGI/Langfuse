#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One filter condition used to decide whether a live-ingested observation should be evaluated.<br/>
    /// All filters must be satisfied for the rule to run. Experiment scope is expressed with filters rather than a separate target field:<br/>
    /// - `isExperimentItemRootSpan = true` limits execution to experiment item roots.<br/>
    /// - `datasetId` limits execution to experiments for the selected datasets. Use dataset IDs from `GET /api/public/v2/datasets`.<br/>
    /// Pick the filter `type` first, as it determines the required fields and value shape. Use `key` only for object filters such as `metadata`.<br/>
    /// Operator quick reference by filter `type`:<br/>
    /// - `string`: `"="`, `contains`, `does not contain`, `starts with`, `ends with`<br/>
    /// - `number`: `"="`, `"&gt;"`, `"&lt;"`, `"&gt;="`, `"&lt;="`<br/>
    /// - `datetime`: `"="`, `"&gt;"`, `"&lt;"`, `"&gt;="`, `"&lt;="`<br/>
    /// - `stringOptions`: `any of`, `none of`<br/>
    /// - `arrayOptions`: `any of`, `none of`, `all of`<br/>
    /// - `stringObject`: same operators as `string`<br/>
    /// - `boolean`: `"="`, `"&lt;&gt;"`<br/>
    /// - `null`: `is null`, `is not null`<br/>
    /// Supported columns. Each column accepts exactly one filter `type`; sending a column with a different `type` is rejected with `400`.<br/>
    /// - `type`: `stringOptions`, values `SPAN`, `EVENT`, `GENERATION`, `AGENT`, `TOOL`, `CHAIN`, `RETRIEVER`, `EVALUATOR`, `EMBEDDING`, `GUARDRAIL`<br/>
    /// - `name`: `stringOptions`<br/>
    /// - `environment`: `stringOptions`<br/>
    /// - `level`: `stringOptions`, values `DEBUG`, `DEFAULT`, `WARNING`, `ERROR`<br/>
    /// - `version`: `string`<br/>
    /// - `traceName`: `stringOptions`<br/>
    /// - `userId`: `string`<br/>
    /// - `sessionId`: `string`<br/>
    /// - `tags`: `arrayOptions`<br/>
    /// - `metadata`: `stringObject`, requires `key`<br/>
    /// - `isRootObservation`: `boolean`; true when the observation has no parent or is explicitly marked as an application root<br/>
    /// - `parentObservationId`: `null`<br/>
    /// - `experimentId`: `stringOptions`<br/>
    /// - `isExperimentItemRootSpan`: `boolean`<br/>
    /// - `calledToolNames`: `arrayOptions`<br/>
    /// - `toolCalls`: `number`, the number of tool calls on the observation<br/>
    /// - `datasetId`: `stringOptions`. Use dataset `id` values from `GET /api/public/v2/datasets`, not dataset names.
    /// </summary>
    public readonly partial struct EvaluationRuleFilter : global::System.IEquatable<EvaluationRuleFilter>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>? DateTimeEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>? DateTimeEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DateTimeEvaluationRuleFilter))]
#endif
        public bool IsDateTimeEvaluationRuleFilter => DateTimeEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDateTimeEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>? value)
        {
            value = DateTimeEvaluationRuleFilter;
            return IsDateTimeEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter> PickDateTimeEvaluationRuleFilter() => IsDateTimeEvaluationRuleFilter
            ? DateTimeEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DateTimeEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>? StringEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>? StringEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringEvaluationRuleFilter))]
#endif
        public bool IsStringEvaluationRuleFilter => StringEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStringEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>? value)
        {
            value = StringEvaluationRuleFilter;
            return IsStringEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter> PickStringEvaluationRuleFilter() => IsStringEvaluationRuleFilter
            ? StringEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StringEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>? NumberEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>? NumberEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumberEvaluationRuleFilter))]
#endif
        public bool IsNumberEvaluationRuleFilter => NumberEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNumberEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>? value)
        {
            value = NumberEvaluationRuleFilter;
            return IsNumberEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter> PickNumberEvaluationRuleFilter() => IsNumberEvaluationRuleFilter
            ? NumberEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NumberEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>? StringOptionsEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>? StringOptionsEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringOptionsEvaluationRuleFilter))]
#endif
        public bool IsStringOptionsEvaluationRuleFilter => StringOptionsEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStringOptionsEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>? value)
        {
            value = StringOptionsEvaluationRuleFilter;
            return IsStringOptionsEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter> PickStringOptionsEvaluationRuleFilter() => IsStringOptionsEvaluationRuleFilter
            ? StringOptionsEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StringOptionsEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>? CategoryOptionsEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>? CategoryOptionsEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CategoryOptionsEvaluationRuleFilter))]
#endif
        public bool IsCategoryOptionsEvaluationRuleFilter => CategoryOptionsEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCategoryOptionsEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>? value)
        {
            value = CategoryOptionsEvaluationRuleFilter;
            return IsCategoryOptionsEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter> PickCategoryOptionsEvaluationRuleFilter() => IsCategoryOptionsEvaluationRuleFilter
            ? CategoryOptionsEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CategoryOptionsEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>? ArrayOptionsEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>? ArrayOptionsEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArrayOptionsEvaluationRuleFilter))]
#endif
        public bool IsArrayOptionsEvaluationRuleFilter => ArrayOptionsEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArrayOptionsEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>? value)
        {
            value = ArrayOptionsEvaluationRuleFilter;
            return IsArrayOptionsEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter> PickArrayOptionsEvaluationRuleFilter() => IsArrayOptionsEvaluationRuleFilter
            ? ArrayOptionsEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArrayOptionsEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>? StringObjectEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>? StringObjectEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringObjectEvaluationRuleFilter))]
#endif
        public bool IsStringObjectEvaluationRuleFilter => StringObjectEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStringObjectEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>? value)
        {
            value = StringObjectEvaluationRuleFilter;
            return IsStringObjectEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter> PickStringObjectEvaluationRuleFilter() => IsStringObjectEvaluationRuleFilter
            ? StringObjectEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StringObjectEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>? NumberObjectEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>? NumberObjectEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumberObjectEvaluationRuleFilter))]
#endif
        public bool IsNumberObjectEvaluationRuleFilter => NumberObjectEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNumberObjectEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>? value)
        {
            value = NumberObjectEvaluationRuleFilter;
            return IsNumberObjectEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter> PickNumberObjectEvaluationRuleFilter() => IsNumberObjectEvaluationRuleFilter
            ? NumberObjectEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NumberObjectEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>? BooleanEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>? BooleanEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BooleanEvaluationRuleFilter))]
#endif
        public bool IsBooleanEvaluationRuleFilter => BooleanEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBooleanEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>? value)
        {
            value = BooleanEvaluationRuleFilter;
            return IsBooleanEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter> PickBooleanEvaluationRuleFilter() => IsBooleanEvaluationRuleFilter
            ? BooleanEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BooleanEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>? NullEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>? NullEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NullEvaluationRuleFilter))]
#endif
        public bool IsNullEvaluationRuleFilter => NullEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNullEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>? value)
        {
            value = NullEvaluationRuleFilter;
            return IsNullEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter> PickNullEvaluationRuleFilter() => IsNullEvaluationRuleFilter
            ? NullEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NullEvaluationRuleFilter' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter> value) => new EvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>?(EvaluationRuleFilter @this) => @this.DateTimeEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>? value)
        {
            DateTimeEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleFilter FromDateTimeEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>? value) => new EvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter> value) => new EvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>?(EvaluationRuleFilter @this) => @this.StringEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>? value)
        {
            StringEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleFilter FromStringEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>? value) => new EvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter> value) => new EvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>?(EvaluationRuleFilter @this) => @this.NumberEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>? value)
        {
            NumberEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleFilter FromNumberEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>? value) => new EvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter> value) => new EvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>?(EvaluationRuleFilter @this) => @this.StringOptionsEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>? value)
        {
            StringOptionsEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleFilter FromStringOptionsEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>? value) => new EvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter> value) => new EvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>?(EvaluationRuleFilter @this) => @this.CategoryOptionsEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>? value)
        {
            CategoryOptionsEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleFilter FromCategoryOptionsEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>? value) => new EvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter> value) => new EvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>?(EvaluationRuleFilter @this) => @this.ArrayOptionsEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>? value)
        {
            ArrayOptionsEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleFilter FromArrayOptionsEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>? value) => new EvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter> value) => new EvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>?(EvaluationRuleFilter @this) => @this.StringObjectEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>? value)
        {
            StringObjectEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleFilter FromStringObjectEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>? value) => new EvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter> value) => new EvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>?(EvaluationRuleFilter @this) => @this.NumberObjectEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>? value)
        {
            NumberObjectEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleFilter FromNumberObjectEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>? value) => new EvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter> value) => new EvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>?(EvaluationRuleFilter @this) => @this.BooleanEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>? value)
        {
            BooleanEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleFilter FromBooleanEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>? value) => new EvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter> value) => new EvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>?(EvaluationRuleFilter @this) => @this.NullEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>? value)
        {
            NullEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleFilter FromNullEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>? value) => new EvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleFilter(
            global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>? dateTimeEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>? stringEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>? numberEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>? stringOptionsEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>? categoryOptionsEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>? arrayOptionsEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>? stringObjectEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>? numberObjectEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>? booleanEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>? nullEvaluationRuleFilter
            )
        {
            DateTimeEvaluationRuleFilter = dateTimeEvaluationRuleFilter;
            StringEvaluationRuleFilter = stringEvaluationRuleFilter;
            NumberEvaluationRuleFilter = numberEvaluationRuleFilter;
            StringOptionsEvaluationRuleFilter = stringOptionsEvaluationRuleFilter;
            CategoryOptionsEvaluationRuleFilter = categoryOptionsEvaluationRuleFilter;
            ArrayOptionsEvaluationRuleFilter = arrayOptionsEvaluationRuleFilter;
            StringObjectEvaluationRuleFilter = stringObjectEvaluationRuleFilter;
            NumberObjectEvaluationRuleFilter = numberObjectEvaluationRuleFilter;
            BooleanEvaluationRuleFilter = booleanEvaluationRuleFilter;
            NullEvaluationRuleFilter = nullEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            NullEvaluationRuleFilter as object ??
            BooleanEvaluationRuleFilter as object ??
            NumberObjectEvaluationRuleFilter as object ??
            StringObjectEvaluationRuleFilter as object ??
            ArrayOptionsEvaluationRuleFilter as object ??
            CategoryOptionsEvaluationRuleFilter as object ??
            StringOptionsEvaluationRuleFilter as object ??
            NumberEvaluationRuleFilter as object ??
            StringEvaluationRuleFilter as object ??
            DateTimeEvaluationRuleFilter as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DateTimeEvaluationRuleFilter?.ToString() ??
            StringEvaluationRuleFilter?.ToString() ??
            NumberEvaluationRuleFilter?.ToString() ??
            StringOptionsEvaluationRuleFilter?.ToString() ??
            CategoryOptionsEvaluationRuleFilter?.ToString() ??
            ArrayOptionsEvaluationRuleFilter?.ToString() ??
            StringObjectEvaluationRuleFilter?.ToString() ??
            NumberObjectEvaluationRuleFilter?.ToString() ??
            BooleanEvaluationRuleFilter?.ToString() ??
            NullEvaluationRuleFilter?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDateTimeEvaluationRuleFilter && !IsStringEvaluationRuleFilter && !IsNumberEvaluationRuleFilter && !IsStringOptionsEvaluationRuleFilter && !IsCategoryOptionsEvaluationRuleFilter && !IsArrayOptionsEvaluationRuleFilter && !IsStringObjectEvaluationRuleFilter && !IsNumberObjectEvaluationRuleFilter && !IsBooleanEvaluationRuleFilter && !IsNullEvaluationRuleFilter || !IsDateTimeEvaluationRuleFilter && IsStringEvaluationRuleFilter && !IsNumberEvaluationRuleFilter && !IsStringOptionsEvaluationRuleFilter && !IsCategoryOptionsEvaluationRuleFilter && !IsArrayOptionsEvaluationRuleFilter && !IsStringObjectEvaluationRuleFilter && !IsNumberObjectEvaluationRuleFilter && !IsBooleanEvaluationRuleFilter && !IsNullEvaluationRuleFilter || !IsDateTimeEvaluationRuleFilter && !IsStringEvaluationRuleFilter && IsNumberEvaluationRuleFilter && !IsStringOptionsEvaluationRuleFilter && !IsCategoryOptionsEvaluationRuleFilter && !IsArrayOptionsEvaluationRuleFilter && !IsStringObjectEvaluationRuleFilter && !IsNumberObjectEvaluationRuleFilter && !IsBooleanEvaluationRuleFilter && !IsNullEvaluationRuleFilter || !IsDateTimeEvaluationRuleFilter && !IsStringEvaluationRuleFilter && !IsNumberEvaluationRuleFilter && IsStringOptionsEvaluationRuleFilter && !IsCategoryOptionsEvaluationRuleFilter && !IsArrayOptionsEvaluationRuleFilter && !IsStringObjectEvaluationRuleFilter && !IsNumberObjectEvaluationRuleFilter && !IsBooleanEvaluationRuleFilter && !IsNullEvaluationRuleFilter || !IsDateTimeEvaluationRuleFilter && !IsStringEvaluationRuleFilter && !IsNumberEvaluationRuleFilter && !IsStringOptionsEvaluationRuleFilter && IsCategoryOptionsEvaluationRuleFilter && !IsArrayOptionsEvaluationRuleFilter && !IsStringObjectEvaluationRuleFilter && !IsNumberObjectEvaluationRuleFilter && !IsBooleanEvaluationRuleFilter && !IsNullEvaluationRuleFilter || !IsDateTimeEvaluationRuleFilter && !IsStringEvaluationRuleFilter && !IsNumberEvaluationRuleFilter && !IsStringOptionsEvaluationRuleFilter && !IsCategoryOptionsEvaluationRuleFilter && IsArrayOptionsEvaluationRuleFilter && !IsStringObjectEvaluationRuleFilter && !IsNumberObjectEvaluationRuleFilter && !IsBooleanEvaluationRuleFilter && !IsNullEvaluationRuleFilter || !IsDateTimeEvaluationRuleFilter && !IsStringEvaluationRuleFilter && !IsNumberEvaluationRuleFilter && !IsStringOptionsEvaluationRuleFilter && !IsCategoryOptionsEvaluationRuleFilter && !IsArrayOptionsEvaluationRuleFilter && IsStringObjectEvaluationRuleFilter && !IsNumberObjectEvaluationRuleFilter && !IsBooleanEvaluationRuleFilter && !IsNullEvaluationRuleFilter || !IsDateTimeEvaluationRuleFilter && !IsStringEvaluationRuleFilter && !IsNumberEvaluationRuleFilter && !IsStringOptionsEvaluationRuleFilter && !IsCategoryOptionsEvaluationRuleFilter && !IsArrayOptionsEvaluationRuleFilter && !IsStringObjectEvaluationRuleFilter && IsNumberObjectEvaluationRuleFilter && !IsBooleanEvaluationRuleFilter && !IsNullEvaluationRuleFilter || !IsDateTimeEvaluationRuleFilter && !IsStringEvaluationRuleFilter && !IsNumberEvaluationRuleFilter && !IsStringOptionsEvaluationRuleFilter && !IsCategoryOptionsEvaluationRuleFilter && !IsArrayOptionsEvaluationRuleFilter && !IsStringObjectEvaluationRuleFilter && !IsNumberObjectEvaluationRuleFilter && IsBooleanEvaluationRuleFilter && !IsNullEvaluationRuleFilter || !IsDateTimeEvaluationRuleFilter && !IsStringEvaluationRuleFilter && !IsNumberEvaluationRuleFilter && !IsStringOptionsEvaluationRuleFilter && !IsCategoryOptionsEvaluationRuleFilter && !IsArrayOptionsEvaluationRuleFilter && !IsStringObjectEvaluationRuleFilter && !IsNumberObjectEvaluationRuleFilter && !IsBooleanEvaluationRuleFilter && IsNullEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>?, TResult>? dateTimeEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>?, TResult>? stringEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>?, TResult>? numberEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>?, TResult>? stringOptionsEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>?, TResult>? categoryOptionsEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>?, TResult>? arrayOptionsEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>?, TResult>? stringObjectEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>?, TResult>? numberObjectEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>?, TResult>? booleanEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>?, TResult>? nullEvaluationRuleFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDateTimeEvaluationRuleFilter && dateTimeEvaluationRuleFilter != null)
            {
                return dateTimeEvaluationRuleFilter(DateTimeEvaluationRuleFilter!);
            }
            else if (IsStringEvaluationRuleFilter && stringEvaluationRuleFilter != null)
            {
                return stringEvaluationRuleFilter(StringEvaluationRuleFilter!);
            }
            else if (IsNumberEvaluationRuleFilter && numberEvaluationRuleFilter != null)
            {
                return numberEvaluationRuleFilter(NumberEvaluationRuleFilter!);
            }
            else if (IsStringOptionsEvaluationRuleFilter && stringOptionsEvaluationRuleFilter != null)
            {
                return stringOptionsEvaluationRuleFilter(StringOptionsEvaluationRuleFilter!);
            }
            else if (IsCategoryOptionsEvaluationRuleFilter && categoryOptionsEvaluationRuleFilter != null)
            {
                return categoryOptionsEvaluationRuleFilter(CategoryOptionsEvaluationRuleFilter!);
            }
            else if (IsArrayOptionsEvaluationRuleFilter && arrayOptionsEvaluationRuleFilter != null)
            {
                return arrayOptionsEvaluationRuleFilter(ArrayOptionsEvaluationRuleFilter!);
            }
            else if (IsStringObjectEvaluationRuleFilter && stringObjectEvaluationRuleFilter != null)
            {
                return stringObjectEvaluationRuleFilter(StringObjectEvaluationRuleFilter!);
            }
            else if (IsNumberObjectEvaluationRuleFilter && numberObjectEvaluationRuleFilter != null)
            {
                return numberObjectEvaluationRuleFilter(NumberObjectEvaluationRuleFilter!);
            }
            else if (IsBooleanEvaluationRuleFilter && booleanEvaluationRuleFilter != null)
            {
                return booleanEvaluationRuleFilter(BooleanEvaluationRuleFilter!);
            }
            else if (IsNullEvaluationRuleFilter && nullEvaluationRuleFilter != null)
            {
                return nullEvaluationRuleFilter(NullEvaluationRuleFilter!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>?>? dateTimeEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>?>? stringEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>?>? numberEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>?>? stringOptionsEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>?>? categoryOptionsEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>?>? arrayOptionsEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>?>? stringObjectEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>?>? numberObjectEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>?>? booleanEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>?>? nullEvaluationRuleFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDateTimeEvaluationRuleFilter)
            {
                dateTimeEvaluationRuleFilter?.Invoke(DateTimeEvaluationRuleFilter!);
            }
            else if (IsStringEvaluationRuleFilter)
            {
                stringEvaluationRuleFilter?.Invoke(StringEvaluationRuleFilter!);
            }
            else if (IsNumberEvaluationRuleFilter)
            {
                numberEvaluationRuleFilter?.Invoke(NumberEvaluationRuleFilter!);
            }
            else if (IsStringOptionsEvaluationRuleFilter)
            {
                stringOptionsEvaluationRuleFilter?.Invoke(StringOptionsEvaluationRuleFilter!);
            }
            else if (IsCategoryOptionsEvaluationRuleFilter)
            {
                categoryOptionsEvaluationRuleFilter?.Invoke(CategoryOptionsEvaluationRuleFilter!);
            }
            else if (IsArrayOptionsEvaluationRuleFilter)
            {
                arrayOptionsEvaluationRuleFilter?.Invoke(ArrayOptionsEvaluationRuleFilter!);
            }
            else if (IsStringObjectEvaluationRuleFilter)
            {
                stringObjectEvaluationRuleFilter?.Invoke(StringObjectEvaluationRuleFilter!);
            }
            else if (IsNumberObjectEvaluationRuleFilter)
            {
                numberObjectEvaluationRuleFilter?.Invoke(NumberObjectEvaluationRuleFilter!);
            }
            else if (IsBooleanEvaluationRuleFilter)
            {
                booleanEvaluationRuleFilter?.Invoke(BooleanEvaluationRuleFilter!);
            }
            else if (IsNullEvaluationRuleFilter)
            {
                nullEvaluationRuleFilter?.Invoke(NullEvaluationRuleFilter!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>?>? dateTimeEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>?>? stringEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>?>? numberEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>?>? stringOptionsEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>?>? categoryOptionsEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>?>? arrayOptionsEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>?>? stringObjectEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>?>? numberObjectEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>?>? booleanEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>?>? nullEvaluationRuleFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDateTimeEvaluationRuleFilter)
            {
                dateTimeEvaluationRuleFilter?.Invoke(DateTimeEvaluationRuleFilter!);
            }
            else if (IsStringEvaluationRuleFilter)
            {
                stringEvaluationRuleFilter?.Invoke(StringEvaluationRuleFilter!);
            }
            else if (IsNumberEvaluationRuleFilter)
            {
                numberEvaluationRuleFilter?.Invoke(NumberEvaluationRuleFilter!);
            }
            else if (IsStringOptionsEvaluationRuleFilter)
            {
                stringOptionsEvaluationRuleFilter?.Invoke(StringOptionsEvaluationRuleFilter!);
            }
            else if (IsCategoryOptionsEvaluationRuleFilter)
            {
                categoryOptionsEvaluationRuleFilter?.Invoke(CategoryOptionsEvaluationRuleFilter!);
            }
            else if (IsArrayOptionsEvaluationRuleFilter)
            {
                arrayOptionsEvaluationRuleFilter?.Invoke(ArrayOptionsEvaluationRuleFilter!);
            }
            else if (IsStringObjectEvaluationRuleFilter)
            {
                stringObjectEvaluationRuleFilter?.Invoke(StringObjectEvaluationRuleFilter!);
            }
            else if (IsNumberObjectEvaluationRuleFilter)
            {
                numberObjectEvaluationRuleFilter?.Invoke(NumberObjectEvaluationRuleFilter!);
            }
            else if (IsBooleanEvaluationRuleFilter)
            {
                booleanEvaluationRuleFilter?.Invoke(BooleanEvaluationRuleFilter!);
            }
            else if (IsNullEvaluationRuleFilter)
            {
                nullEvaluationRuleFilter?.Invoke(NullEvaluationRuleFilter!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DateTimeEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>),
                StringEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>),
                NumberEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>),
                StringOptionsEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>),
                CategoryOptionsEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>),
                ArrayOptionsEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>),
                StringObjectEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>),
                NumberObjectEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>),
                BooleanEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>),
                NullEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(EvaluationRuleFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterDateTimeEvaluationRuleFilter2, global::Langfuse.DateTimeEvaluationRuleFilter>?>.Default.Equals(DateTimeEvaluationRuleFilter, other.DateTimeEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringEvaluationRuleFilter2, global::Langfuse.StringEvaluationRuleFilter>?>.Default.Equals(StringEvaluationRuleFilter, other.StringEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberEvaluationRuleFilter2, global::Langfuse.NumberEvaluationRuleFilter>?>.Default.Equals(NumberEvaluationRuleFilter, other.NumberEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringOptionsEvaluationRuleFilter2, global::Langfuse.StringOptionsEvaluationRuleFilter>?>.Default.Equals(StringOptionsEvaluationRuleFilter, other.StringOptionsEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterCategoryOptionsEvaluationRuleFilter2, global::Langfuse.CategoryOptionsEvaluationRuleFilter>?>.Default.Equals(CategoryOptionsEvaluationRuleFilter, other.CategoryOptionsEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterArrayOptionsEvaluationRuleFilter2, global::Langfuse.ArrayOptionsEvaluationRuleFilter>?>.Default.Equals(ArrayOptionsEvaluationRuleFilter, other.ArrayOptionsEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterStringObjectEvaluationRuleFilter2, global::Langfuse.StringObjectEvaluationRuleFilter>?>.Default.Equals(StringObjectEvaluationRuleFilter, other.StringObjectEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNumberObjectEvaluationRuleFilter2, global::Langfuse.NumberObjectEvaluationRuleFilter>?>.Default.Equals(NumberObjectEvaluationRuleFilter, other.NumberObjectEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterBooleanEvaluationRuleFilter2, global::Langfuse.BooleanEvaluationRuleFilter>?>.Default.Equals(BooleanEvaluationRuleFilter, other.BooleanEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluationRuleFilterNullEvaluationRuleFilter2, global::Langfuse.NullEvaluationRuleFilter>?>.Default.Equals(NullEvaluationRuleFilter, other.NullEvaluationRuleFilter)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EvaluationRuleFilter obj1, EvaluationRuleFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvaluationRuleFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EvaluationRuleFilter obj1, EvaluationRuleFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvaluationRuleFilter o && Equals(o);
        }
    }
}
