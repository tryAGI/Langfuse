#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One filter condition used to decide whether a live-ingested target should be evaluated.<br/>
    /// An evaluation rule can include zero or more filter objects. All filters must be satisfied for the target to run.<br/>
    /// How to build a valid filter object:<br/>
    /// - Pick the `target` first, because it changes the supported columns.<br/>
    /// - Pick the filter `type`. That determines which fields are required.<br/>
    /// - Use `key` only for object filters such as `metadata`.<br/>
    /// - Use the correct `value` shape for the chosen filter `type`.<br/>
    /// Operator quick reference by filter `type`:<br/>
    /// - `string`: `"="`, `contains`, `does not contain`, `starts with`, `ends with`<br/>
    /// - `number`: `"="`, `"&gt;"`, `"&lt;"`, `"&gt;="`, `"&lt;="`<br/>
    /// - `datetime`: `"="`, `"&gt;"`, `"&lt;"`, `"&gt;="`, `"&lt;="`<br/>
    /// - `stringOptions`: `any of`, `none of`<br/>
    /// - `arrayOptions`: `any of`, `none of`, `all of`<br/>
    /// - `stringObject`: same operators as `string`<br/>
    /// - `boolean`: `"="`, `"&lt;&gt;"`<br/>
    /// - `null`: `is null`, `is not null`<br/>
    /// Supported columns by target:<br/>
    /// - `target=observation`<br/>
    ///   - `type`: `stringOptions`, operators `any of` / `none of`, values `GENERATION`, `SPAN`, `EVENT`<br/>
    ///   - `name`: `stringOptions`, operators `any of` / `none of`<br/>
    ///   - `environment`: `stringOptions`, operators `any of` / `none of`<br/>
    ///   - `level`: `stringOptions`, operators `any of` / `none of`, values `DEBUG`, `DEFAULT`, `WARNING`, `ERROR`<br/>
    ///   - `version`: `string`<br/>
    ///   - `traceName`: `stringOptions`, operators `any of` / `none of`<br/>
    ///   - `userId`: `string`<br/>
    ///   - `sessionId`: `string`<br/>
    ///   - `tags`: `arrayOptions`, operators `any of` / `none of` / `all of`<br/>
    ///   - `metadata`: `stringObject` with `key`<br/>
    ///   - `isRootObservation`: `boolean`, operators `=` / `&lt;&gt;`; true when the observation has no parent or is explicitly marked as an application root<br/>
    ///   - `parentObservationId`: `null`, operators `is null` / `is not null`<br/>
    ///   - `calledToolNames`: `arrayOptions`, operators `any of` / `none of` / `all of`<br/>
    ///   - `toolCalls`: `number`<br/>
    /// - `target=experiment`<br/>
    ///   - `datasetId`: `stringOptions`, operators `any of` / `none of`<br/>
    ///     Use dataset `id` values from `GET /api/public/v2/datasets`, not dataset names.<br/>
    /// Recovery guidance:<br/>
    /// - `invalid_filter_value` with `details.column` but no `invalidValues`: the selected `column` is not supported for the chosen `target`<br/>
    /// - `invalid_filter_value` with `details.invalidValues`: the selected values are not allowed for that column. Replace them with one of `details.allowedValues` when provided.<br/>
    /// - `invalid_filter_value` for `column=datasetId`: call `GET /api/public/v2/datasets`, then retry with dataset `id` values from that response.
    /// </summary>
    public readonly partial struct UnstableEvaluationRuleFilter : global::System.IEquatable<UnstableEvaluationRuleFilter>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? UnstableDateTimeEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? UnstableDateTimeEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableDateTimeEvaluationRuleFilter))]
#endif
        public bool IsUnstableDateTimeEvaluationRuleFilter => UnstableDateTimeEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableDateTimeEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? value)
        {
            value = UnstableDateTimeEvaluationRuleFilter;
            return IsUnstableDateTimeEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter> PickUnstableDateTimeEvaluationRuleFilter() => IsUnstableDateTimeEvaluationRuleFilter
            ? UnstableDateTimeEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableDateTimeEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>? UnstableStringEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>? UnstableStringEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableStringEvaluationRuleFilter))]
#endif
        public bool IsUnstableStringEvaluationRuleFilter => UnstableStringEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableStringEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>? value)
        {
            value = UnstableStringEvaluationRuleFilter;
            return IsUnstableStringEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter> PickUnstableStringEvaluationRuleFilter() => IsUnstableStringEvaluationRuleFilter
            ? UnstableStringEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableStringEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>? UnstableNumberEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>? UnstableNumberEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableNumberEvaluationRuleFilter))]
#endif
        public bool IsUnstableNumberEvaluationRuleFilter => UnstableNumberEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableNumberEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>? value)
        {
            value = UnstableNumberEvaluationRuleFilter;
            return IsUnstableNumberEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter> PickUnstableNumberEvaluationRuleFilter() => IsUnstableNumberEvaluationRuleFilter
            ? UnstableNumberEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableNumberEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? UnstableStringOptionsEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? UnstableStringOptionsEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableStringOptionsEvaluationRuleFilter))]
#endif
        public bool IsUnstableStringOptionsEvaluationRuleFilter => UnstableStringOptionsEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableStringOptionsEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? value)
        {
            value = UnstableStringOptionsEvaluationRuleFilter;
            return IsUnstableStringOptionsEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter> PickUnstableStringOptionsEvaluationRuleFilter() => IsUnstableStringOptionsEvaluationRuleFilter
            ? UnstableStringOptionsEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableStringOptionsEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? UnstableCategoryOptionsEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? UnstableCategoryOptionsEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCategoryOptionsEvaluationRuleFilter))]
#endif
        public bool IsUnstableCategoryOptionsEvaluationRuleFilter => UnstableCategoryOptionsEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableCategoryOptionsEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? value)
        {
            value = UnstableCategoryOptionsEvaluationRuleFilter;
            return IsUnstableCategoryOptionsEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter> PickUnstableCategoryOptionsEvaluationRuleFilter() => IsUnstableCategoryOptionsEvaluationRuleFilter
            ? UnstableCategoryOptionsEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCategoryOptionsEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? UnstableArrayOptionsEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? UnstableArrayOptionsEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableArrayOptionsEvaluationRuleFilter))]
#endif
        public bool IsUnstableArrayOptionsEvaluationRuleFilter => UnstableArrayOptionsEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableArrayOptionsEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? value)
        {
            value = UnstableArrayOptionsEvaluationRuleFilter;
            return IsUnstableArrayOptionsEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter> PickUnstableArrayOptionsEvaluationRuleFilter() => IsUnstableArrayOptionsEvaluationRuleFilter
            ? UnstableArrayOptionsEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableArrayOptionsEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? UnstableStringObjectEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? UnstableStringObjectEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableStringObjectEvaluationRuleFilter))]
#endif
        public bool IsUnstableStringObjectEvaluationRuleFilter => UnstableStringObjectEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableStringObjectEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? value)
        {
            value = UnstableStringObjectEvaluationRuleFilter;
            return IsUnstableStringObjectEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter> PickUnstableStringObjectEvaluationRuleFilter() => IsUnstableStringObjectEvaluationRuleFilter
            ? UnstableStringObjectEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableStringObjectEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? UnstableNumberObjectEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? UnstableNumberObjectEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableNumberObjectEvaluationRuleFilter))]
#endif
        public bool IsUnstableNumberObjectEvaluationRuleFilter => UnstableNumberObjectEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableNumberObjectEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? value)
        {
            value = UnstableNumberObjectEvaluationRuleFilter;
            return IsUnstableNumberObjectEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter> PickUnstableNumberObjectEvaluationRuleFilter() => IsUnstableNumberObjectEvaluationRuleFilter
            ? UnstableNumberObjectEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableNumberObjectEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? UnstableBooleanEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? UnstableBooleanEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableBooleanEvaluationRuleFilter))]
#endif
        public bool IsUnstableBooleanEvaluationRuleFilter => UnstableBooleanEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableBooleanEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? value)
        {
            value = UnstableBooleanEvaluationRuleFilter;
            return IsUnstableBooleanEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter> PickUnstableBooleanEvaluationRuleFilter() => IsUnstableBooleanEvaluationRuleFilter
            ? UnstableBooleanEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableBooleanEvaluationRuleFilter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>? UnstableNullEvaluationRuleFilter { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>? UnstableNullEvaluationRuleFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableNullEvaluationRuleFilter))]
#endif
        public bool IsUnstableNullEvaluationRuleFilter => UnstableNullEvaluationRuleFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableNullEvaluationRuleFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>? value)
        {
            value = UnstableNullEvaluationRuleFilter;
            return IsUnstableNullEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter> PickUnstableNullEvaluationRuleFilter() => IsUnstableNullEvaluationRuleFilter
            ? UnstableNullEvaluationRuleFilter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableNullEvaluationRuleFilter' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableDateTimeEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? value)
        {
            UnstableDateTimeEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluationRuleFilter FromUnstableDateTimeEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? value) => new UnstableEvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableStringEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>? value)
        {
            UnstableStringEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluationRuleFilter FromUnstableStringEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>? value) => new UnstableEvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableNumberEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>? value)
        {
            UnstableNumberEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluationRuleFilter FromUnstableNumberEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>? value) => new UnstableEvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableStringOptionsEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? value)
        {
            UnstableStringOptionsEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluationRuleFilter FromUnstableStringOptionsEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? value) => new UnstableEvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableCategoryOptionsEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? value)
        {
            UnstableCategoryOptionsEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluationRuleFilter FromUnstableCategoryOptionsEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? value) => new UnstableEvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableArrayOptionsEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? value)
        {
            UnstableArrayOptionsEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluationRuleFilter FromUnstableArrayOptionsEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? value) => new UnstableEvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableStringObjectEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? value)
        {
            UnstableStringObjectEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluationRuleFilter FromUnstableStringObjectEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? value) => new UnstableEvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableNumberObjectEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? value)
        {
            UnstableNumberObjectEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluationRuleFilter FromUnstableNumberObjectEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? value) => new UnstableEvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableBooleanEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? value)
        {
            UnstableBooleanEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluationRuleFilter FromUnstableBooleanEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? value) => new UnstableEvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableNullEvaluationRuleFilter;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>? value)
        {
            UnstableNullEvaluationRuleFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluationRuleFilter FromUnstableNullEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>? value) => new UnstableEvaluationRuleFilter(value);

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluationRuleFilter(
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? unstableDateTimeEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>? unstableStringEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>? unstableNumberEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? unstableStringOptionsEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? unstableCategoryOptionsEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? unstableArrayOptionsEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? unstableStringObjectEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? unstableNumberObjectEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? unstableBooleanEvaluationRuleFilter,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>? unstableNullEvaluationRuleFilter
            )
        {
            UnstableDateTimeEvaluationRuleFilter = unstableDateTimeEvaluationRuleFilter;
            UnstableStringEvaluationRuleFilter = unstableStringEvaluationRuleFilter;
            UnstableNumberEvaluationRuleFilter = unstableNumberEvaluationRuleFilter;
            UnstableStringOptionsEvaluationRuleFilter = unstableStringOptionsEvaluationRuleFilter;
            UnstableCategoryOptionsEvaluationRuleFilter = unstableCategoryOptionsEvaluationRuleFilter;
            UnstableArrayOptionsEvaluationRuleFilter = unstableArrayOptionsEvaluationRuleFilter;
            UnstableStringObjectEvaluationRuleFilter = unstableStringObjectEvaluationRuleFilter;
            UnstableNumberObjectEvaluationRuleFilter = unstableNumberObjectEvaluationRuleFilter;
            UnstableBooleanEvaluationRuleFilter = unstableBooleanEvaluationRuleFilter;
            UnstableNullEvaluationRuleFilter = unstableNullEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UnstableNullEvaluationRuleFilter as object ??
            UnstableBooleanEvaluationRuleFilter as object ??
            UnstableNumberObjectEvaluationRuleFilter as object ??
            UnstableStringObjectEvaluationRuleFilter as object ??
            UnstableArrayOptionsEvaluationRuleFilter as object ??
            UnstableCategoryOptionsEvaluationRuleFilter as object ??
            UnstableStringOptionsEvaluationRuleFilter as object ??
            UnstableNumberEvaluationRuleFilter as object ??
            UnstableStringEvaluationRuleFilter as object ??
            UnstableDateTimeEvaluationRuleFilter as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UnstableDateTimeEvaluationRuleFilter?.ToString() ??
            UnstableStringEvaluationRuleFilter?.ToString() ??
            UnstableNumberEvaluationRuleFilter?.ToString() ??
            UnstableStringOptionsEvaluationRuleFilter?.ToString() ??
            UnstableCategoryOptionsEvaluationRuleFilter?.ToString() ??
            UnstableArrayOptionsEvaluationRuleFilter?.ToString() ??
            UnstableStringObjectEvaluationRuleFilter?.ToString() ??
            UnstableNumberObjectEvaluationRuleFilter?.ToString() ??
            UnstableBooleanEvaluationRuleFilter?.ToString() ??
            UnstableNullEvaluationRuleFilter?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnstableDateTimeEvaluationRuleFilter && !IsUnstableStringEvaluationRuleFilter && !IsUnstableNumberEvaluationRuleFilter && !IsUnstableStringOptionsEvaluationRuleFilter && !IsUnstableCategoryOptionsEvaluationRuleFilter && !IsUnstableArrayOptionsEvaluationRuleFilter && !IsUnstableStringObjectEvaluationRuleFilter && !IsUnstableNumberObjectEvaluationRuleFilter && !IsUnstableBooleanEvaluationRuleFilter && !IsUnstableNullEvaluationRuleFilter || !IsUnstableDateTimeEvaluationRuleFilter && IsUnstableStringEvaluationRuleFilter && !IsUnstableNumberEvaluationRuleFilter && !IsUnstableStringOptionsEvaluationRuleFilter && !IsUnstableCategoryOptionsEvaluationRuleFilter && !IsUnstableArrayOptionsEvaluationRuleFilter && !IsUnstableStringObjectEvaluationRuleFilter && !IsUnstableNumberObjectEvaluationRuleFilter && !IsUnstableBooleanEvaluationRuleFilter && !IsUnstableNullEvaluationRuleFilter || !IsUnstableDateTimeEvaluationRuleFilter && !IsUnstableStringEvaluationRuleFilter && IsUnstableNumberEvaluationRuleFilter && !IsUnstableStringOptionsEvaluationRuleFilter && !IsUnstableCategoryOptionsEvaluationRuleFilter && !IsUnstableArrayOptionsEvaluationRuleFilter && !IsUnstableStringObjectEvaluationRuleFilter && !IsUnstableNumberObjectEvaluationRuleFilter && !IsUnstableBooleanEvaluationRuleFilter && !IsUnstableNullEvaluationRuleFilter || !IsUnstableDateTimeEvaluationRuleFilter && !IsUnstableStringEvaluationRuleFilter && !IsUnstableNumberEvaluationRuleFilter && IsUnstableStringOptionsEvaluationRuleFilter && !IsUnstableCategoryOptionsEvaluationRuleFilter && !IsUnstableArrayOptionsEvaluationRuleFilter && !IsUnstableStringObjectEvaluationRuleFilter && !IsUnstableNumberObjectEvaluationRuleFilter && !IsUnstableBooleanEvaluationRuleFilter && !IsUnstableNullEvaluationRuleFilter || !IsUnstableDateTimeEvaluationRuleFilter && !IsUnstableStringEvaluationRuleFilter && !IsUnstableNumberEvaluationRuleFilter && !IsUnstableStringOptionsEvaluationRuleFilter && IsUnstableCategoryOptionsEvaluationRuleFilter && !IsUnstableArrayOptionsEvaluationRuleFilter && !IsUnstableStringObjectEvaluationRuleFilter && !IsUnstableNumberObjectEvaluationRuleFilter && !IsUnstableBooleanEvaluationRuleFilter && !IsUnstableNullEvaluationRuleFilter || !IsUnstableDateTimeEvaluationRuleFilter && !IsUnstableStringEvaluationRuleFilter && !IsUnstableNumberEvaluationRuleFilter && !IsUnstableStringOptionsEvaluationRuleFilter && !IsUnstableCategoryOptionsEvaluationRuleFilter && IsUnstableArrayOptionsEvaluationRuleFilter && !IsUnstableStringObjectEvaluationRuleFilter && !IsUnstableNumberObjectEvaluationRuleFilter && !IsUnstableBooleanEvaluationRuleFilter && !IsUnstableNullEvaluationRuleFilter || !IsUnstableDateTimeEvaluationRuleFilter && !IsUnstableStringEvaluationRuleFilter && !IsUnstableNumberEvaluationRuleFilter && !IsUnstableStringOptionsEvaluationRuleFilter && !IsUnstableCategoryOptionsEvaluationRuleFilter && !IsUnstableArrayOptionsEvaluationRuleFilter && IsUnstableStringObjectEvaluationRuleFilter && !IsUnstableNumberObjectEvaluationRuleFilter && !IsUnstableBooleanEvaluationRuleFilter && !IsUnstableNullEvaluationRuleFilter || !IsUnstableDateTimeEvaluationRuleFilter && !IsUnstableStringEvaluationRuleFilter && !IsUnstableNumberEvaluationRuleFilter && !IsUnstableStringOptionsEvaluationRuleFilter && !IsUnstableCategoryOptionsEvaluationRuleFilter && !IsUnstableArrayOptionsEvaluationRuleFilter && !IsUnstableStringObjectEvaluationRuleFilter && IsUnstableNumberObjectEvaluationRuleFilter && !IsUnstableBooleanEvaluationRuleFilter && !IsUnstableNullEvaluationRuleFilter || !IsUnstableDateTimeEvaluationRuleFilter && !IsUnstableStringEvaluationRuleFilter && !IsUnstableNumberEvaluationRuleFilter && !IsUnstableStringOptionsEvaluationRuleFilter && !IsUnstableCategoryOptionsEvaluationRuleFilter && !IsUnstableArrayOptionsEvaluationRuleFilter && !IsUnstableStringObjectEvaluationRuleFilter && !IsUnstableNumberObjectEvaluationRuleFilter && IsUnstableBooleanEvaluationRuleFilter && !IsUnstableNullEvaluationRuleFilter || !IsUnstableDateTimeEvaluationRuleFilter && !IsUnstableStringEvaluationRuleFilter && !IsUnstableNumberEvaluationRuleFilter && !IsUnstableStringOptionsEvaluationRuleFilter && !IsUnstableCategoryOptionsEvaluationRuleFilter && !IsUnstableArrayOptionsEvaluationRuleFilter && !IsUnstableStringObjectEvaluationRuleFilter && !IsUnstableNumberObjectEvaluationRuleFilter && !IsUnstableBooleanEvaluationRuleFilter && IsUnstableNullEvaluationRuleFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?, TResult>? unstableDateTimeEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>?, TResult>? unstableStringEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>?, TResult>? unstableNumberEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?, TResult>? unstableStringOptionsEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?, TResult>? unstableCategoryOptionsEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?, TResult>? unstableArrayOptionsEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?, TResult>? unstableStringObjectEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?, TResult>? unstableNumberObjectEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?, TResult>? unstableBooleanEvaluationRuleFilter = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>?, TResult>? unstableNullEvaluationRuleFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableDateTimeEvaluationRuleFilter && unstableDateTimeEvaluationRuleFilter != null)
            {
                return unstableDateTimeEvaluationRuleFilter(UnstableDateTimeEvaluationRuleFilter!);
            }
            else if (IsUnstableStringEvaluationRuleFilter && unstableStringEvaluationRuleFilter != null)
            {
                return unstableStringEvaluationRuleFilter(UnstableStringEvaluationRuleFilter!);
            }
            else if (IsUnstableNumberEvaluationRuleFilter && unstableNumberEvaluationRuleFilter != null)
            {
                return unstableNumberEvaluationRuleFilter(UnstableNumberEvaluationRuleFilter!);
            }
            else if (IsUnstableStringOptionsEvaluationRuleFilter && unstableStringOptionsEvaluationRuleFilter != null)
            {
                return unstableStringOptionsEvaluationRuleFilter(UnstableStringOptionsEvaluationRuleFilter!);
            }
            else if (IsUnstableCategoryOptionsEvaluationRuleFilter && unstableCategoryOptionsEvaluationRuleFilter != null)
            {
                return unstableCategoryOptionsEvaluationRuleFilter(UnstableCategoryOptionsEvaluationRuleFilter!);
            }
            else if (IsUnstableArrayOptionsEvaluationRuleFilter && unstableArrayOptionsEvaluationRuleFilter != null)
            {
                return unstableArrayOptionsEvaluationRuleFilter(UnstableArrayOptionsEvaluationRuleFilter!);
            }
            else if (IsUnstableStringObjectEvaluationRuleFilter && unstableStringObjectEvaluationRuleFilter != null)
            {
                return unstableStringObjectEvaluationRuleFilter(UnstableStringObjectEvaluationRuleFilter!);
            }
            else if (IsUnstableNumberObjectEvaluationRuleFilter && unstableNumberObjectEvaluationRuleFilter != null)
            {
                return unstableNumberObjectEvaluationRuleFilter(UnstableNumberObjectEvaluationRuleFilter!);
            }
            else if (IsUnstableBooleanEvaluationRuleFilter && unstableBooleanEvaluationRuleFilter != null)
            {
                return unstableBooleanEvaluationRuleFilter(UnstableBooleanEvaluationRuleFilter!);
            }
            else if (IsUnstableNullEvaluationRuleFilter && unstableNullEvaluationRuleFilter != null)
            {
                return unstableNullEvaluationRuleFilter(UnstableNullEvaluationRuleFilter!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?>? unstableDateTimeEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>?>? unstableStringEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>?>? unstableNumberEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?>? unstableStringOptionsEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?>? unstableCategoryOptionsEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?>? unstableArrayOptionsEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?>? unstableStringObjectEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?>? unstableNumberObjectEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?>? unstableBooleanEvaluationRuleFilter = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>?>? unstableNullEvaluationRuleFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableDateTimeEvaluationRuleFilter)
            {
                unstableDateTimeEvaluationRuleFilter?.Invoke(UnstableDateTimeEvaluationRuleFilter!);
            }
            else if (IsUnstableStringEvaluationRuleFilter)
            {
                unstableStringEvaluationRuleFilter?.Invoke(UnstableStringEvaluationRuleFilter!);
            }
            else if (IsUnstableNumberEvaluationRuleFilter)
            {
                unstableNumberEvaluationRuleFilter?.Invoke(UnstableNumberEvaluationRuleFilter!);
            }
            else if (IsUnstableStringOptionsEvaluationRuleFilter)
            {
                unstableStringOptionsEvaluationRuleFilter?.Invoke(UnstableStringOptionsEvaluationRuleFilter!);
            }
            else if (IsUnstableCategoryOptionsEvaluationRuleFilter)
            {
                unstableCategoryOptionsEvaluationRuleFilter?.Invoke(UnstableCategoryOptionsEvaluationRuleFilter!);
            }
            else if (IsUnstableArrayOptionsEvaluationRuleFilter)
            {
                unstableArrayOptionsEvaluationRuleFilter?.Invoke(UnstableArrayOptionsEvaluationRuleFilter!);
            }
            else if (IsUnstableStringObjectEvaluationRuleFilter)
            {
                unstableStringObjectEvaluationRuleFilter?.Invoke(UnstableStringObjectEvaluationRuleFilter!);
            }
            else if (IsUnstableNumberObjectEvaluationRuleFilter)
            {
                unstableNumberObjectEvaluationRuleFilter?.Invoke(UnstableNumberObjectEvaluationRuleFilter!);
            }
            else if (IsUnstableBooleanEvaluationRuleFilter)
            {
                unstableBooleanEvaluationRuleFilter?.Invoke(UnstableBooleanEvaluationRuleFilter!);
            }
            else if (IsUnstableNullEvaluationRuleFilter)
            {
                unstableNullEvaluationRuleFilter?.Invoke(UnstableNullEvaluationRuleFilter!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?>? unstableDateTimeEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>?>? unstableStringEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>?>? unstableNumberEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?>? unstableStringOptionsEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?>? unstableCategoryOptionsEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?>? unstableArrayOptionsEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?>? unstableStringObjectEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?>? unstableNumberObjectEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?>? unstableBooleanEvaluationRuleFilter = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>?>? unstableNullEvaluationRuleFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableDateTimeEvaluationRuleFilter)
            {
                unstableDateTimeEvaluationRuleFilter?.Invoke(UnstableDateTimeEvaluationRuleFilter!);
            }
            else if (IsUnstableStringEvaluationRuleFilter)
            {
                unstableStringEvaluationRuleFilter?.Invoke(UnstableStringEvaluationRuleFilter!);
            }
            else if (IsUnstableNumberEvaluationRuleFilter)
            {
                unstableNumberEvaluationRuleFilter?.Invoke(UnstableNumberEvaluationRuleFilter!);
            }
            else if (IsUnstableStringOptionsEvaluationRuleFilter)
            {
                unstableStringOptionsEvaluationRuleFilter?.Invoke(UnstableStringOptionsEvaluationRuleFilter!);
            }
            else if (IsUnstableCategoryOptionsEvaluationRuleFilter)
            {
                unstableCategoryOptionsEvaluationRuleFilter?.Invoke(UnstableCategoryOptionsEvaluationRuleFilter!);
            }
            else if (IsUnstableArrayOptionsEvaluationRuleFilter)
            {
                unstableArrayOptionsEvaluationRuleFilter?.Invoke(UnstableArrayOptionsEvaluationRuleFilter!);
            }
            else if (IsUnstableStringObjectEvaluationRuleFilter)
            {
                unstableStringObjectEvaluationRuleFilter?.Invoke(UnstableStringObjectEvaluationRuleFilter!);
            }
            else if (IsUnstableNumberObjectEvaluationRuleFilter)
            {
                unstableNumberObjectEvaluationRuleFilter?.Invoke(UnstableNumberObjectEvaluationRuleFilter!);
            }
            else if (IsUnstableBooleanEvaluationRuleFilter)
            {
                unstableBooleanEvaluationRuleFilter?.Invoke(UnstableBooleanEvaluationRuleFilter!);
            }
            else if (IsUnstableNullEvaluationRuleFilter)
            {
                unstableNullEvaluationRuleFilter?.Invoke(UnstableNullEvaluationRuleFilter!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableDateTimeEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>),
                UnstableStringEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>),
                UnstableNumberEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>),
                UnstableStringOptionsEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>),
                UnstableCategoryOptionsEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>),
                UnstableArrayOptionsEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>),
                UnstableStringObjectEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>),
                UnstableNumberObjectEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>),
                UnstableBooleanEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>),
                UnstableNullEvaluationRuleFilter,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>),
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
        public bool Equals(UnstableEvaluationRuleFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableDateTimeEvaluationRuleFilter2, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?>.Default.Equals(UnstableDateTimeEvaluationRuleFilter, other.UnstableDateTimeEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringEvaluationRuleFilter2, global::Langfuse.UnstableStringEvaluationRuleFilter>?>.Default.Equals(UnstableStringEvaluationRuleFilter, other.UnstableStringEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberEvaluationRuleFilter2, global::Langfuse.UnstableNumberEvaluationRuleFilter>?>.Default.Equals(UnstableNumberEvaluationRuleFilter, other.UnstableNumberEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringOptionsEvaluationRuleFilter2, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?>.Default.Equals(UnstableStringOptionsEvaluationRuleFilter, other.UnstableStringOptionsEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableCategoryOptionsEvaluationRuleFilter2, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?>.Default.Equals(UnstableCategoryOptionsEvaluationRuleFilter, other.UnstableCategoryOptionsEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableArrayOptionsEvaluationRuleFilter2, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?>.Default.Equals(UnstableArrayOptionsEvaluationRuleFilter, other.UnstableArrayOptionsEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableStringObjectEvaluationRuleFilter2, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?>.Default.Equals(UnstableStringObjectEvaluationRuleFilter, other.UnstableStringObjectEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNumberObjectEvaluationRuleFilter2, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?>.Default.Equals(UnstableNumberObjectEvaluationRuleFilter, other.UnstableNumberObjectEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableBooleanEvaluationRuleFilter2, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?>.Default.Equals(UnstableBooleanEvaluationRuleFilter, other.UnstableBooleanEvaluationRuleFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterUnstableNullEvaluationRuleFilter2, global::Langfuse.UnstableNullEvaluationRuleFilter>?>.Default.Equals(UnstableNullEvaluationRuleFilter, other.UnstableNullEvaluationRuleFilter)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UnstableEvaluationRuleFilter obj1, UnstableEvaluationRuleFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnstableEvaluationRuleFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnstableEvaluationRuleFilter obj1, UnstableEvaluationRuleFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnstableEvaluationRuleFilter o && Equals(o);
        }
    }
}
