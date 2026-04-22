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
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRuleFilterVariant1))]
#endif
        public bool IsUnstableEvaluationRuleFilterVariant1 => UnstableEvaluationRuleFilterVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRuleFilterVariant2))]
#endif
        public bool IsUnstableEvaluationRuleFilterVariant2 => UnstableEvaluationRuleFilterVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRuleFilterVariant3))]
#endif
        public bool IsUnstableEvaluationRuleFilterVariant3 => UnstableEvaluationRuleFilterVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant4 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRuleFilterVariant4))]
#endif
        public bool IsUnstableEvaluationRuleFilterVariant4 => UnstableEvaluationRuleFilterVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant5 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRuleFilterVariant5))]
#endif
        public bool IsUnstableEvaluationRuleFilterVariant5 => UnstableEvaluationRuleFilterVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant6 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRuleFilterVariant6))]
#endif
        public bool IsUnstableEvaluationRuleFilterVariant6 => UnstableEvaluationRuleFilterVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant7 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRuleFilterVariant7))]
#endif
        public bool IsUnstableEvaluationRuleFilterVariant7 => UnstableEvaluationRuleFilterVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant8 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRuleFilterVariant8))]
#endif
        public bool IsUnstableEvaluationRuleFilterVariant8 => UnstableEvaluationRuleFilterVariant8 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant9 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRuleFilterVariant9))]
#endif
        public bool IsUnstableEvaluationRuleFilterVariant9 => UnstableEvaluationRuleFilterVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant10 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>? UnstableEvaluationRuleFilterVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluationRuleFilterVariant10))]
#endif
        public bool IsUnstableEvaluationRuleFilterVariant10 => UnstableEvaluationRuleFilterVariant10 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableEvaluationRuleFilterVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? value)
        {
            UnstableEvaluationRuleFilterVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableEvaluationRuleFilterVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>? value)
        {
            UnstableEvaluationRuleFilterVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableEvaluationRuleFilterVariant3;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>? value)
        {
            UnstableEvaluationRuleFilterVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableEvaluationRuleFilterVariant4;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? value)
        {
            UnstableEvaluationRuleFilterVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableEvaluationRuleFilterVariant5;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? value)
        {
            UnstableEvaluationRuleFilterVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableEvaluationRuleFilterVariant6;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? value)
        {
            UnstableEvaluationRuleFilterVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableEvaluationRuleFilterVariant7;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? value)
        {
            UnstableEvaluationRuleFilterVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableEvaluationRuleFilterVariant8;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? value)
        {
            UnstableEvaluationRuleFilterVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableEvaluationRuleFilterVariant9;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? value)
        {
            UnstableEvaluationRuleFilterVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter> value) => new UnstableEvaluationRuleFilter((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>?(UnstableEvaluationRuleFilter @this) => @this.UnstableEvaluationRuleFilterVariant10;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>? value)
        {
            UnstableEvaluationRuleFilterVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluationRuleFilter(
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>? unstableEvaluationRuleFilterVariant1,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>? unstableEvaluationRuleFilterVariant2,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>? unstableEvaluationRuleFilterVariant3,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>? unstableEvaluationRuleFilterVariant4,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>? unstableEvaluationRuleFilterVariant5,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>? unstableEvaluationRuleFilterVariant6,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>? unstableEvaluationRuleFilterVariant7,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>? unstableEvaluationRuleFilterVariant8,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>? unstableEvaluationRuleFilterVariant9,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>? unstableEvaluationRuleFilterVariant10
            )
        {
            UnstableEvaluationRuleFilterVariant1 = unstableEvaluationRuleFilterVariant1;
            UnstableEvaluationRuleFilterVariant2 = unstableEvaluationRuleFilterVariant2;
            UnstableEvaluationRuleFilterVariant3 = unstableEvaluationRuleFilterVariant3;
            UnstableEvaluationRuleFilterVariant4 = unstableEvaluationRuleFilterVariant4;
            UnstableEvaluationRuleFilterVariant5 = unstableEvaluationRuleFilterVariant5;
            UnstableEvaluationRuleFilterVariant6 = unstableEvaluationRuleFilterVariant6;
            UnstableEvaluationRuleFilterVariant7 = unstableEvaluationRuleFilterVariant7;
            UnstableEvaluationRuleFilterVariant8 = unstableEvaluationRuleFilterVariant8;
            UnstableEvaluationRuleFilterVariant9 = unstableEvaluationRuleFilterVariant9;
            UnstableEvaluationRuleFilterVariant10 = unstableEvaluationRuleFilterVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnstableEvaluationRuleFilterVariant10 as object ??
            UnstableEvaluationRuleFilterVariant9 as object ??
            UnstableEvaluationRuleFilterVariant8 as object ??
            UnstableEvaluationRuleFilterVariant7 as object ??
            UnstableEvaluationRuleFilterVariant6 as object ??
            UnstableEvaluationRuleFilterVariant5 as object ??
            UnstableEvaluationRuleFilterVariant4 as object ??
            UnstableEvaluationRuleFilterVariant3 as object ??
            UnstableEvaluationRuleFilterVariant2 as object ??
            UnstableEvaluationRuleFilterVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnstableEvaluationRuleFilterVariant1?.ToString() ??
            UnstableEvaluationRuleFilterVariant2?.ToString() ??
            UnstableEvaluationRuleFilterVariant3?.ToString() ??
            UnstableEvaluationRuleFilterVariant4?.ToString() ??
            UnstableEvaluationRuleFilterVariant5?.ToString() ??
            UnstableEvaluationRuleFilterVariant6?.ToString() ??
            UnstableEvaluationRuleFilterVariant7?.ToString() ??
            UnstableEvaluationRuleFilterVariant8?.ToString() ??
            UnstableEvaluationRuleFilterVariant9?.ToString() ??
            UnstableEvaluationRuleFilterVariant10?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnstableEvaluationRuleFilterVariant1 && !IsUnstableEvaluationRuleFilterVariant2 && !IsUnstableEvaluationRuleFilterVariant3 && !IsUnstableEvaluationRuleFilterVariant4 && !IsUnstableEvaluationRuleFilterVariant5 && !IsUnstableEvaluationRuleFilterVariant6 && !IsUnstableEvaluationRuleFilterVariant7 && !IsUnstableEvaluationRuleFilterVariant8 && !IsUnstableEvaluationRuleFilterVariant9 && !IsUnstableEvaluationRuleFilterVariant10 || !IsUnstableEvaluationRuleFilterVariant1 && IsUnstableEvaluationRuleFilterVariant2 && !IsUnstableEvaluationRuleFilterVariant3 && !IsUnstableEvaluationRuleFilterVariant4 && !IsUnstableEvaluationRuleFilterVariant5 && !IsUnstableEvaluationRuleFilterVariant6 && !IsUnstableEvaluationRuleFilterVariant7 && !IsUnstableEvaluationRuleFilterVariant8 && !IsUnstableEvaluationRuleFilterVariant9 && !IsUnstableEvaluationRuleFilterVariant10 || !IsUnstableEvaluationRuleFilterVariant1 && !IsUnstableEvaluationRuleFilterVariant2 && IsUnstableEvaluationRuleFilterVariant3 && !IsUnstableEvaluationRuleFilterVariant4 && !IsUnstableEvaluationRuleFilterVariant5 && !IsUnstableEvaluationRuleFilterVariant6 && !IsUnstableEvaluationRuleFilterVariant7 && !IsUnstableEvaluationRuleFilterVariant8 && !IsUnstableEvaluationRuleFilterVariant9 && !IsUnstableEvaluationRuleFilterVariant10 || !IsUnstableEvaluationRuleFilterVariant1 && !IsUnstableEvaluationRuleFilterVariant2 && !IsUnstableEvaluationRuleFilterVariant3 && IsUnstableEvaluationRuleFilterVariant4 && !IsUnstableEvaluationRuleFilterVariant5 && !IsUnstableEvaluationRuleFilterVariant6 && !IsUnstableEvaluationRuleFilterVariant7 && !IsUnstableEvaluationRuleFilterVariant8 && !IsUnstableEvaluationRuleFilterVariant9 && !IsUnstableEvaluationRuleFilterVariant10 || !IsUnstableEvaluationRuleFilterVariant1 && !IsUnstableEvaluationRuleFilterVariant2 && !IsUnstableEvaluationRuleFilterVariant3 && !IsUnstableEvaluationRuleFilterVariant4 && IsUnstableEvaluationRuleFilterVariant5 && !IsUnstableEvaluationRuleFilterVariant6 && !IsUnstableEvaluationRuleFilterVariant7 && !IsUnstableEvaluationRuleFilterVariant8 && !IsUnstableEvaluationRuleFilterVariant9 && !IsUnstableEvaluationRuleFilterVariant10 || !IsUnstableEvaluationRuleFilterVariant1 && !IsUnstableEvaluationRuleFilterVariant2 && !IsUnstableEvaluationRuleFilterVariant3 && !IsUnstableEvaluationRuleFilterVariant4 && !IsUnstableEvaluationRuleFilterVariant5 && IsUnstableEvaluationRuleFilterVariant6 && !IsUnstableEvaluationRuleFilterVariant7 && !IsUnstableEvaluationRuleFilterVariant8 && !IsUnstableEvaluationRuleFilterVariant9 && !IsUnstableEvaluationRuleFilterVariant10 || !IsUnstableEvaluationRuleFilterVariant1 && !IsUnstableEvaluationRuleFilterVariant2 && !IsUnstableEvaluationRuleFilterVariant3 && !IsUnstableEvaluationRuleFilterVariant4 && !IsUnstableEvaluationRuleFilterVariant5 && !IsUnstableEvaluationRuleFilterVariant6 && IsUnstableEvaluationRuleFilterVariant7 && !IsUnstableEvaluationRuleFilterVariant8 && !IsUnstableEvaluationRuleFilterVariant9 && !IsUnstableEvaluationRuleFilterVariant10 || !IsUnstableEvaluationRuleFilterVariant1 && !IsUnstableEvaluationRuleFilterVariant2 && !IsUnstableEvaluationRuleFilterVariant3 && !IsUnstableEvaluationRuleFilterVariant4 && !IsUnstableEvaluationRuleFilterVariant5 && !IsUnstableEvaluationRuleFilterVariant6 && !IsUnstableEvaluationRuleFilterVariant7 && IsUnstableEvaluationRuleFilterVariant8 && !IsUnstableEvaluationRuleFilterVariant9 && !IsUnstableEvaluationRuleFilterVariant10 || !IsUnstableEvaluationRuleFilterVariant1 && !IsUnstableEvaluationRuleFilterVariant2 && !IsUnstableEvaluationRuleFilterVariant3 && !IsUnstableEvaluationRuleFilterVariant4 && !IsUnstableEvaluationRuleFilterVariant5 && !IsUnstableEvaluationRuleFilterVariant6 && !IsUnstableEvaluationRuleFilterVariant7 && !IsUnstableEvaluationRuleFilterVariant8 && IsUnstableEvaluationRuleFilterVariant9 && !IsUnstableEvaluationRuleFilterVariant10 || !IsUnstableEvaluationRuleFilterVariant1 && !IsUnstableEvaluationRuleFilterVariant2 && !IsUnstableEvaluationRuleFilterVariant3 && !IsUnstableEvaluationRuleFilterVariant4 && !IsUnstableEvaluationRuleFilterVariant5 && !IsUnstableEvaluationRuleFilterVariant6 && !IsUnstableEvaluationRuleFilterVariant7 && !IsUnstableEvaluationRuleFilterVariant8 && !IsUnstableEvaluationRuleFilterVariant9 && IsUnstableEvaluationRuleFilterVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?, TResult>? unstableEvaluationRuleFilterVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>?, TResult>? unstableEvaluationRuleFilterVariant2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>?, TResult>? unstableEvaluationRuleFilterVariant3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?, TResult>? unstableEvaluationRuleFilterVariant4 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?, TResult>? unstableEvaluationRuleFilterVariant5 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?, TResult>? unstableEvaluationRuleFilterVariant6 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?, TResult>? unstableEvaluationRuleFilterVariant7 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?, TResult>? unstableEvaluationRuleFilterVariant8 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?, TResult>? unstableEvaluationRuleFilterVariant9 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>?, TResult>? unstableEvaluationRuleFilterVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluationRuleFilterVariant1 && unstableEvaluationRuleFilterVariant1 != null)
            {
                return unstableEvaluationRuleFilterVariant1(UnstableEvaluationRuleFilterVariant1!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant2 && unstableEvaluationRuleFilterVariant2 != null)
            {
                return unstableEvaluationRuleFilterVariant2(UnstableEvaluationRuleFilterVariant2!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant3 && unstableEvaluationRuleFilterVariant3 != null)
            {
                return unstableEvaluationRuleFilterVariant3(UnstableEvaluationRuleFilterVariant3!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant4 && unstableEvaluationRuleFilterVariant4 != null)
            {
                return unstableEvaluationRuleFilterVariant4(UnstableEvaluationRuleFilterVariant4!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant5 && unstableEvaluationRuleFilterVariant5 != null)
            {
                return unstableEvaluationRuleFilterVariant5(UnstableEvaluationRuleFilterVariant5!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant6 && unstableEvaluationRuleFilterVariant6 != null)
            {
                return unstableEvaluationRuleFilterVariant6(UnstableEvaluationRuleFilterVariant6!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant7 && unstableEvaluationRuleFilterVariant7 != null)
            {
                return unstableEvaluationRuleFilterVariant7(UnstableEvaluationRuleFilterVariant7!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant8 && unstableEvaluationRuleFilterVariant8 != null)
            {
                return unstableEvaluationRuleFilterVariant8(UnstableEvaluationRuleFilterVariant8!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant9 && unstableEvaluationRuleFilterVariant9 != null)
            {
                return unstableEvaluationRuleFilterVariant9(UnstableEvaluationRuleFilterVariant9!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant10 && unstableEvaluationRuleFilterVariant10 != null)
            {
                return unstableEvaluationRuleFilterVariant10(UnstableEvaluationRuleFilterVariant10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?>? unstableEvaluationRuleFilterVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>?>? unstableEvaluationRuleFilterVariant2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>?>? unstableEvaluationRuleFilterVariant3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?>? unstableEvaluationRuleFilterVariant4 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?>? unstableEvaluationRuleFilterVariant5 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?>? unstableEvaluationRuleFilterVariant6 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?>? unstableEvaluationRuleFilterVariant7 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?>? unstableEvaluationRuleFilterVariant8 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?>? unstableEvaluationRuleFilterVariant9 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>?>? unstableEvaluationRuleFilterVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluationRuleFilterVariant1)
            {
                unstableEvaluationRuleFilterVariant1?.Invoke(UnstableEvaluationRuleFilterVariant1!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant2)
            {
                unstableEvaluationRuleFilterVariant2?.Invoke(UnstableEvaluationRuleFilterVariant2!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant3)
            {
                unstableEvaluationRuleFilterVariant3?.Invoke(UnstableEvaluationRuleFilterVariant3!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant4)
            {
                unstableEvaluationRuleFilterVariant4?.Invoke(UnstableEvaluationRuleFilterVariant4!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant5)
            {
                unstableEvaluationRuleFilterVariant5?.Invoke(UnstableEvaluationRuleFilterVariant5!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant6)
            {
                unstableEvaluationRuleFilterVariant6?.Invoke(UnstableEvaluationRuleFilterVariant6!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant7)
            {
                unstableEvaluationRuleFilterVariant7?.Invoke(UnstableEvaluationRuleFilterVariant7!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant8)
            {
                unstableEvaluationRuleFilterVariant8?.Invoke(UnstableEvaluationRuleFilterVariant8!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant9)
            {
                unstableEvaluationRuleFilterVariant9?.Invoke(UnstableEvaluationRuleFilterVariant9!);
            }
            else if (IsUnstableEvaluationRuleFilterVariant10)
            {
                unstableEvaluationRuleFilterVariant10?.Invoke(UnstableEvaluationRuleFilterVariant10!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableEvaluationRuleFilterVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>),
                UnstableEvaluationRuleFilterVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>),
                UnstableEvaluationRuleFilterVariant3,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>),
                UnstableEvaluationRuleFilterVariant4,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>),
                UnstableEvaluationRuleFilterVariant5,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>),
                UnstableEvaluationRuleFilterVariant6,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>),
                UnstableEvaluationRuleFilterVariant7,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>),
                UnstableEvaluationRuleFilterVariant8,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>),
                UnstableEvaluationRuleFilterVariant9,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>),
                UnstableEvaluationRuleFilterVariant10,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>),
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
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant12, global::Langfuse.UnstableDateTimeEvaluationRuleFilter>?>.Default.Equals(UnstableEvaluationRuleFilterVariant1, other.UnstableEvaluationRuleFilterVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant22, global::Langfuse.UnstableStringEvaluationRuleFilter>?>.Default.Equals(UnstableEvaluationRuleFilterVariant2, other.UnstableEvaluationRuleFilterVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant32, global::Langfuse.UnstableNumberEvaluationRuleFilter>?>.Default.Equals(UnstableEvaluationRuleFilterVariant3, other.UnstableEvaluationRuleFilterVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant42, global::Langfuse.UnstableStringOptionsEvaluationRuleFilter>?>.Default.Equals(UnstableEvaluationRuleFilterVariant4, other.UnstableEvaluationRuleFilterVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant52, global::Langfuse.UnstableCategoryOptionsEvaluationRuleFilter>?>.Default.Equals(UnstableEvaluationRuleFilterVariant5, other.UnstableEvaluationRuleFilterVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant62, global::Langfuse.UnstableArrayOptionsEvaluationRuleFilter>?>.Default.Equals(UnstableEvaluationRuleFilterVariant6, other.UnstableEvaluationRuleFilterVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant72, global::Langfuse.UnstableStringObjectEvaluationRuleFilter>?>.Default.Equals(UnstableEvaluationRuleFilterVariant7, other.UnstableEvaluationRuleFilterVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant82, global::Langfuse.UnstableNumberObjectEvaluationRuleFilter>?>.Default.Equals(UnstableEvaluationRuleFilterVariant8, other.UnstableEvaluationRuleFilterVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant92, global::Langfuse.UnstableBooleanEvaluationRuleFilter>?>.Default.Equals(UnstableEvaluationRuleFilterVariant9, other.UnstableEvaluationRuleFilterVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluationRuleFilterVariant102, global::Langfuse.UnstableNullEvaluationRuleFilter>?>.Default.Equals(UnstableEvaluationRuleFilterVariant10, other.UnstableEvaluationRuleFilterVariant10) 
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
