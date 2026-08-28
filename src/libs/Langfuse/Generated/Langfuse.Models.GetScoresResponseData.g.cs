#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GetScoresResponseData : global::System.IEquatable<GetScoresResponseData>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>? GetScoresResponseDataNumeric { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>? GetScoresResponseDataNumeric { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataNumeric))]
#endif
        public bool IsGetScoresResponseDataNumeric => GetScoresResponseDataNumeric != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGetScoresResponseDataNumeric(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>? value)
        {
            value = GetScoresResponseDataNumeric;
            return IsGetScoresResponseDataNumeric;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric> PickGetScoresResponseDataNumeric() => IsGetScoresResponseDataNumeric
            ? GetScoresResponseDataNumeric!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetScoresResponseDataNumeric' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>? GetScoresResponseDataCategorical { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>? GetScoresResponseDataCategorical { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataCategorical))]
#endif
        public bool IsGetScoresResponseDataCategorical => GetScoresResponseDataCategorical != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGetScoresResponseDataCategorical(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>? value)
        {
            value = GetScoresResponseDataCategorical;
            return IsGetScoresResponseDataCategorical;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical> PickGetScoresResponseDataCategorical() => IsGetScoresResponseDataCategorical
            ? GetScoresResponseDataCategorical!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetScoresResponseDataCategorical' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>? GetScoresResponseDataBoolean { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>? GetScoresResponseDataBoolean { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataBoolean))]
#endif
        public bool IsGetScoresResponseDataBoolean => GetScoresResponseDataBoolean != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGetScoresResponseDataBoolean(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>? value)
        {
            value = GetScoresResponseDataBoolean;
            return IsGetScoresResponseDataBoolean;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean> PickGetScoresResponseDataBoolean() => IsGetScoresResponseDataBoolean
            ? GetScoresResponseDataBoolean!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetScoresResponseDataBoolean' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>? GetScoresResponseDataCorrection { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>? GetScoresResponseDataCorrection { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataCorrection))]
#endif
        public bool IsGetScoresResponseDataCorrection => GetScoresResponseDataCorrection != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGetScoresResponseDataCorrection(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>? value)
        {
            value = GetScoresResponseDataCorrection;
            return IsGetScoresResponseDataCorrection;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection> PickGetScoresResponseDataCorrection() => IsGetScoresResponseDataCorrection
            ? GetScoresResponseDataCorrection!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetScoresResponseDataCorrection' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>? GetScoresResponseDataText { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>? GetScoresResponseDataText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetScoresResponseDataText))]
#endif
        public bool IsGetScoresResponseDataText => GetScoresResponseDataText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGetScoresResponseDataText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>? value)
        {
            value = GetScoresResponseDataText;
            return IsGetScoresResponseDataText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText> PickGetScoresResponseDataText() => IsGetScoresResponseDataText
            ? GetScoresResponseDataText!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetScoresResponseDataText' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric> value) => new GetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>?(GetScoresResponseData @this) => @this.GetScoresResponseDataNumeric;

        /// <summary>
        ///
        /// </summary>
        public GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>? value)
        {
            GetScoresResponseDataNumeric = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetScoresResponseData FromGetScoresResponseDataNumeric(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>? value) => new GetScoresResponseData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical> value) => new GetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>?(GetScoresResponseData @this) => @this.GetScoresResponseDataCategorical;

        /// <summary>
        ///
        /// </summary>
        public GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>? value)
        {
            GetScoresResponseDataCategorical = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetScoresResponseData FromGetScoresResponseDataCategorical(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>? value) => new GetScoresResponseData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean> value) => new GetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>?(GetScoresResponseData @this) => @this.GetScoresResponseDataBoolean;

        /// <summary>
        ///
        /// </summary>
        public GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>? value)
        {
            GetScoresResponseDataBoolean = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetScoresResponseData FromGetScoresResponseDataBoolean(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>? value) => new GetScoresResponseData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection> value) => new GetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>?(GetScoresResponseData @this) => @this.GetScoresResponseDataCorrection;

        /// <summary>
        ///
        /// </summary>
        public GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>? value)
        {
            GetScoresResponseDataCorrection = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetScoresResponseData FromGetScoresResponseDataCorrection(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>? value) => new GetScoresResponseData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText> value) => new GetScoresResponseData((global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>?(GetScoresResponseData @this) => @this.GetScoresResponseDataText;

        /// <summary>
        ///
        /// </summary>
        public GetScoresResponseData(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>? value)
        {
            GetScoresResponseDataText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetScoresResponseData FromGetScoresResponseDataText(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>? value) => new GetScoresResponseData(value);

        /// <summary>
        ///
        /// </summary>
        public GetScoresResponseData(
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>? getScoresResponseDataNumeric,
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>? getScoresResponseDataCategorical,
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>? getScoresResponseDataBoolean,
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>? getScoresResponseDataCorrection,
            global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>? getScoresResponseDataText
            )
        {
            GetScoresResponseDataNumeric = getScoresResponseDataNumeric;
            GetScoresResponseDataCategorical = getScoresResponseDataCategorical;
            GetScoresResponseDataBoolean = getScoresResponseDataBoolean;
            GetScoresResponseDataCorrection = getScoresResponseDataCorrection;
            GetScoresResponseDataText = getScoresResponseDataText;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GetScoresResponseDataText as object ??
            GetScoresResponseDataCorrection as object ??
            GetScoresResponseDataBoolean as object ??
            GetScoresResponseDataCategorical as object ??
            GetScoresResponseDataNumeric as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GetScoresResponseDataNumeric?.ToString() ??
            GetScoresResponseDataCategorical?.ToString() ??
            GetScoresResponseDataBoolean?.ToString() ??
            GetScoresResponseDataCorrection?.ToString() ??
            GetScoresResponseDataText?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGetScoresResponseDataNumeric && !IsGetScoresResponseDataCategorical && !IsGetScoresResponseDataBoolean && !IsGetScoresResponseDataCorrection && !IsGetScoresResponseDataText || !IsGetScoresResponseDataNumeric && IsGetScoresResponseDataCategorical && !IsGetScoresResponseDataBoolean && !IsGetScoresResponseDataCorrection && !IsGetScoresResponseDataText || !IsGetScoresResponseDataNumeric && !IsGetScoresResponseDataCategorical && IsGetScoresResponseDataBoolean && !IsGetScoresResponseDataCorrection && !IsGetScoresResponseDataText || !IsGetScoresResponseDataNumeric && !IsGetScoresResponseDataCategorical && !IsGetScoresResponseDataBoolean && IsGetScoresResponseDataCorrection && !IsGetScoresResponseDataText || !IsGetScoresResponseDataNumeric && !IsGetScoresResponseDataCategorical && !IsGetScoresResponseDataBoolean && !IsGetScoresResponseDataCorrection && IsGetScoresResponseDataText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>?, TResult>? getScoresResponseDataNumeric = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>?, TResult>? getScoresResponseDataCategorical = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>?, TResult>? getScoresResponseDataBoolean = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>?, TResult>? getScoresResponseDataCorrection = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>?, TResult>? getScoresResponseDataText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetScoresResponseDataNumeric && getScoresResponseDataNumeric != null)
            {
                return getScoresResponseDataNumeric(GetScoresResponseDataNumeric!);
            }
            else if (IsGetScoresResponseDataCategorical && getScoresResponseDataCategorical != null)
            {
                return getScoresResponseDataCategorical(GetScoresResponseDataCategorical!);
            }
            else if (IsGetScoresResponseDataBoolean && getScoresResponseDataBoolean != null)
            {
                return getScoresResponseDataBoolean(GetScoresResponseDataBoolean!);
            }
            else if (IsGetScoresResponseDataCorrection && getScoresResponseDataCorrection != null)
            {
                return getScoresResponseDataCorrection(GetScoresResponseDataCorrection!);
            }
            else if (IsGetScoresResponseDataText && getScoresResponseDataText != null)
            {
                return getScoresResponseDataText(GetScoresResponseDataText!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>?>? getScoresResponseDataNumeric = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>?>? getScoresResponseDataCategorical = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>?>? getScoresResponseDataBoolean = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>?>? getScoresResponseDataCorrection = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>?>? getScoresResponseDataText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetScoresResponseDataNumeric)
            {
                getScoresResponseDataNumeric?.Invoke(GetScoresResponseDataNumeric!);
            }
            else if (IsGetScoresResponseDataCategorical)
            {
                getScoresResponseDataCategorical?.Invoke(GetScoresResponseDataCategorical!);
            }
            else if (IsGetScoresResponseDataBoolean)
            {
                getScoresResponseDataBoolean?.Invoke(GetScoresResponseDataBoolean!);
            }
            else if (IsGetScoresResponseDataCorrection)
            {
                getScoresResponseDataCorrection?.Invoke(GetScoresResponseDataCorrection!);
            }
            else if (IsGetScoresResponseDataText)
            {
                getScoresResponseDataText?.Invoke(GetScoresResponseDataText!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>?>? getScoresResponseDataNumeric = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>?>? getScoresResponseDataCategorical = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>?>? getScoresResponseDataBoolean = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>?>? getScoresResponseDataCorrection = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>?>? getScoresResponseDataText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetScoresResponseDataNumeric)
            {
                getScoresResponseDataNumeric?.Invoke(GetScoresResponseDataNumeric!);
            }
            else if (IsGetScoresResponseDataCategorical)
            {
                getScoresResponseDataCategorical?.Invoke(GetScoresResponseDataCategorical!);
            }
            else if (IsGetScoresResponseDataBoolean)
            {
                getScoresResponseDataBoolean?.Invoke(GetScoresResponseDataBoolean!);
            }
            else if (IsGetScoresResponseDataCorrection)
            {
                getScoresResponseDataCorrection?.Invoke(GetScoresResponseDataCorrection!);
            }
            else if (IsGetScoresResponseDataText)
            {
                getScoresResponseDataText?.Invoke(GetScoresResponseDataText!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GetScoresResponseDataNumeric,
                typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>),
                GetScoresResponseDataCategorical,
                typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>),
                GetScoresResponseDataBoolean,
                typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>),
                GetScoresResponseDataCorrection,
                typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>),
                GetScoresResponseDataText,
                typeof(global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>),
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
        public bool Equals(GetScoresResponseData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataNumeric2, global::Langfuse.GetScoresResponseDataNumeric>?>.Default.Equals(GetScoresResponseDataNumeric, other.GetScoresResponseDataNumeric) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCategorical2, global::Langfuse.GetScoresResponseDataCategorical>?>.Default.Equals(GetScoresResponseDataCategorical, other.GetScoresResponseDataCategorical) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataBoolean2, global::Langfuse.GetScoresResponseDataBoolean>?>.Default.Equals(GetScoresResponseDataBoolean, other.GetScoresResponseDataBoolean) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataCorrection2, global::Langfuse.GetScoresResponseDataCorrection>?>.Default.Equals(GetScoresResponseDataCorrection, other.GetScoresResponseDataCorrection) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.GetScoresResponseDataGetScoresResponseDataText2, global::Langfuse.GetScoresResponseDataText>?>.Default.Equals(GetScoresResponseDataText, other.GetScoresResponseDataText)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GetScoresResponseData obj1, GetScoresResponseData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetScoresResponseData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetScoresResponseData obj1, GetScoresResponseData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetScoresResponseData o && Equals(o);
        }
    }
}
