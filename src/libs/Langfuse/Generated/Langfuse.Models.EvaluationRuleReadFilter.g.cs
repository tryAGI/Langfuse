#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Filter returned verbatim by evaluation-rule read endpoints.<br/>
    /// Filters with a stored `key` use the keyed shape. All other filters use the base shape. Response filters are intentionally not broken down by their internal `type` value.
    /// </summary>
    public readonly partial struct EvaluationRuleReadFilter : global::System.IEquatable<EvaluationRuleReadFilter>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.EvaluationRuleReadFilterWithKey? EvaluationRuleReadFilterWithKey { get; init; }
#else
        public global::Langfuse.EvaluationRuleReadFilterWithKey? EvaluationRuleReadFilterWithKey { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvaluationRuleReadFilterWithKey))]
#endif
        public bool IsEvaluationRuleReadFilterWithKey => EvaluationRuleReadFilterWithKey != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEvaluationRuleReadFilterWithKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.EvaluationRuleReadFilterWithKey? value)
        {
            value = EvaluationRuleReadFilterWithKey;
            return IsEvaluationRuleReadFilterWithKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilterWithKey PickEvaluationRuleReadFilterWithKey() => IsEvaluationRuleReadFilterWithKey
            ? EvaluationRuleReadFilterWithKey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EvaluationRuleReadFilterWithKey' but the value was {ToString()}.");

        /// <summary>
        /// Stored filter returned verbatim by evaluation-rule read endpoints.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.EvaluationRuleReadFilterBase? EvaluationRuleReadFilterBase { get; init; }
#else
        public global::Langfuse.EvaluationRuleReadFilterBase? EvaluationRuleReadFilterBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvaluationRuleReadFilterBase))]
#endif
        public bool IsEvaluationRuleReadFilterBase => EvaluationRuleReadFilterBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEvaluationRuleReadFilterBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.EvaluationRuleReadFilterBase? value)
        {
            value = EvaluationRuleReadFilterBase;
            return IsEvaluationRuleReadFilterBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.EvaluationRuleReadFilterBase PickEvaluationRuleReadFilterBase() => IsEvaluationRuleReadFilterBase
            ? EvaluationRuleReadFilterBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EvaluationRuleReadFilterBase' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleReadFilter(global::Langfuse.EvaluationRuleReadFilterWithKey value) => new EvaluationRuleReadFilter((global::Langfuse.EvaluationRuleReadFilterWithKey?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.EvaluationRuleReadFilterWithKey?(EvaluationRuleReadFilter @this) => @this.EvaluationRuleReadFilterWithKey;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleReadFilter(global::Langfuse.EvaluationRuleReadFilterWithKey? value)
        {
            EvaluationRuleReadFilterWithKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleReadFilter FromEvaluationRuleReadFilterWithKey(global::Langfuse.EvaluationRuleReadFilterWithKey? value) => new EvaluationRuleReadFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluationRuleReadFilter(global::Langfuse.EvaluationRuleReadFilterBase value) => new EvaluationRuleReadFilter((global::Langfuse.EvaluationRuleReadFilterBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.EvaluationRuleReadFilterBase?(EvaluationRuleReadFilter @this) => @this.EvaluationRuleReadFilterBase;

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleReadFilter(global::Langfuse.EvaluationRuleReadFilterBase? value)
        {
            EvaluationRuleReadFilterBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluationRuleReadFilter FromEvaluationRuleReadFilterBase(global::Langfuse.EvaluationRuleReadFilterBase? value) => new EvaluationRuleReadFilter(value);

        /// <summary>
        ///
        /// </summary>
        public EvaluationRuleReadFilter(
            global::Langfuse.EvaluationRuleReadFilterWithKey? evaluationRuleReadFilterWithKey,
            global::Langfuse.EvaluationRuleReadFilterBase? evaluationRuleReadFilterBase
            )
        {
            EvaluationRuleReadFilterWithKey = evaluationRuleReadFilterWithKey;
            EvaluationRuleReadFilterBase = evaluationRuleReadFilterBase;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EvaluationRuleReadFilterBase as object ??
            EvaluationRuleReadFilterWithKey as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            EvaluationRuleReadFilterWithKey?.ToString() ??
            EvaluationRuleReadFilterBase?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEvaluationRuleReadFilterWithKey && !IsEvaluationRuleReadFilterBase || !IsEvaluationRuleReadFilterWithKey && IsEvaluationRuleReadFilterBase;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.EvaluationRuleReadFilterWithKey, TResult>? evaluationRuleReadFilterWithKey = null,
            global::System.Func<global::Langfuse.EvaluationRuleReadFilterBase, TResult>? evaluationRuleReadFilterBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvaluationRuleReadFilterWithKey && evaluationRuleReadFilterWithKey != null)
            {
                return evaluationRuleReadFilterWithKey(EvaluationRuleReadFilterWithKey!);
            }
            else if (IsEvaluationRuleReadFilterBase && evaluationRuleReadFilterBase != null)
            {
                return evaluationRuleReadFilterBase(EvaluationRuleReadFilterBase!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.EvaluationRuleReadFilterWithKey>? evaluationRuleReadFilterWithKey = null,

            global::System.Action<global::Langfuse.EvaluationRuleReadFilterBase>? evaluationRuleReadFilterBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvaluationRuleReadFilterWithKey)
            {
                evaluationRuleReadFilterWithKey?.Invoke(EvaluationRuleReadFilterWithKey!);
            }
            else if (IsEvaluationRuleReadFilterBase)
            {
                evaluationRuleReadFilterBase?.Invoke(EvaluationRuleReadFilterBase!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.EvaluationRuleReadFilterWithKey>? evaluationRuleReadFilterWithKey = null,
            global::System.Action<global::Langfuse.EvaluationRuleReadFilterBase>? evaluationRuleReadFilterBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvaluationRuleReadFilterWithKey)
            {
                evaluationRuleReadFilterWithKey?.Invoke(EvaluationRuleReadFilterWithKey!);
            }
            else if (IsEvaluationRuleReadFilterBase)
            {
                evaluationRuleReadFilterBase?.Invoke(EvaluationRuleReadFilterBase!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EvaluationRuleReadFilterWithKey,
                typeof(global::Langfuse.EvaluationRuleReadFilterWithKey),
                EvaluationRuleReadFilterBase,
                typeof(global::Langfuse.EvaluationRuleReadFilterBase),
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
        public bool Equals(EvaluationRuleReadFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.EvaluationRuleReadFilterWithKey?>.Default.Equals(EvaluationRuleReadFilterWithKey, other.EvaluationRuleReadFilterWithKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.EvaluationRuleReadFilterBase?>.Default.Equals(EvaluationRuleReadFilterBase, other.EvaluationRuleReadFilterBase)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EvaluationRuleReadFilter obj1, EvaluationRuleReadFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvaluationRuleReadFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EvaluationRuleReadFilter obj1, EvaluationRuleReadFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvaluationRuleReadFilter o && Equals(o);
        }
    }
}
