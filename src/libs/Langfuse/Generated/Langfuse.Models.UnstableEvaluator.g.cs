#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One evaluator that can be used for scoring.<br/>
    /// An evaluator describes **how** to score data.<br/>
    /// It does not define **which** live objects are evaluated. That is the job of `evaluation-rules`.<br/>
    /// For agent clients, the most important fields are:<br/>
    /// - `type`: determines which evaluator fields are present<br/>
    /// - `variables`: for LLM evaluators, use these exact names when building the evaluation-rule `mapping` array. LLM evaluators require every variable to be mapped. Code evaluators always expose the fixed runtime payload fields and Langfuse maps them automatically.<br/>
    /// Versioning behavior:<br/>
    /// - `GET /evaluators` returns the latest version of each available evaluator.<br/>
    /// - `GET /evaluators/{id}` returns the latest version.<br/>
    /// - `id` identifies the evaluator family and remains stable when a new version is created.<br/>
    /// - Evaluation rules always run against the latest version for the selected evaluator name within the same source (`project` or `managed`).
    /// </summary>
    public readonly partial struct UnstableEvaluator : global::System.IEquatable<UnstableEvaluator>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>? UnstableLlmAsJudgeEvaluator { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>? UnstableLlmAsJudgeEvaluator { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableLlmAsJudgeEvaluator))]
#endif
        public bool IsUnstableLlmAsJudgeEvaluator => UnstableLlmAsJudgeEvaluator != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableLlmAsJudgeEvaluator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>? value)
        {
            value = UnstableLlmAsJudgeEvaluator;
            return IsUnstableLlmAsJudgeEvaluator;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator> PickUnstableLlmAsJudgeEvaluator() => IsUnstableLlmAsJudgeEvaluator
            ? UnstableLlmAsJudgeEvaluator!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableLlmAsJudgeEvaluator' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>? UnstableCodeEvaluator { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>? UnstableCodeEvaluator { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCodeEvaluator))]
#endif
        public bool IsUnstableCodeEvaluator => UnstableCodeEvaluator != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableCodeEvaluator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>? value)
        {
            value = UnstableCodeEvaluator;
            return IsUnstableCodeEvaluator;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator> PickUnstableCodeEvaluator() => IsUnstableCodeEvaluator
            ? UnstableCodeEvaluator!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCodeEvaluator' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluator(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator> value) => new UnstableEvaluator((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>?(UnstableEvaluator @this) => @this.UnstableLlmAsJudgeEvaluator;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluator(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>? value)
        {
            UnstableLlmAsJudgeEvaluator = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluator FromUnstableLlmAsJudgeEvaluator(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>? value) => new UnstableEvaluator(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableEvaluator(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator> value) => new UnstableEvaluator((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>?(UnstableEvaluator @this) => @this.UnstableCodeEvaluator;

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluator(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>? value)
        {
            UnstableCodeEvaluator = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableEvaluator FromUnstableCodeEvaluator(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>? value) => new UnstableEvaluator(value);

        /// <summary>
        ///
        /// </summary>
        public UnstableEvaluator(
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>? unstableLlmAsJudgeEvaluator,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>? unstableCodeEvaluator
            )
        {
            UnstableLlmAsJudgeEvaluator = unstableLlmAsJudgeEvaluator;
            UnstableCodeEvaluator = unstableCodeEvaluator;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UnstableCodeEvaluator as object ??
            UnstableLlmAsJudgeEvaluator as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UnstableLlmAsJudgeEvaluator?.ToString() ??
            UnstableCodeEvaluator?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnstableLlmAsJudgeEvaluator && !IsUnstableCodeEvaluator || !IsUnstableLlmAsJudgeEvaluator && IsUnstableCodeEvaluator;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>?, TResult>? unstableLlmAsJudgeEvaluator = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>?, TResult>? unstableCodeEvaluator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableLlmAsJudgeEvaluator && unstableLlmAsJudgeEvaluator != null)
            {
                return unstableLlmAsJudgeEvaluator(UnstableLlmAsJudgeEvaluator!);
            }
            else if (IsUnstableCodeEvaluator && unstableCodeEvaluator != null)
            {
                return unstableCodeEvaluator(UnstableCodeEvaluator!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>?>? unstableLlmAsJudgeEvaluator = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>?>? unstableCodeEvaluator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableLlmAsJudgeEvaluator)
            {
                unstableLlmAsJudgeEvaluator?.Invoke(UnstableLlmAsJudgeEvaluator!);
            }
            else if (IsUnstableCodeEvaluator)
            {
                unstableCodeEvaluator?.Invoke(UnstableCodeEvaluator!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>?>? unstableLlmAsJudgeEvaluator = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>?>? unstableCodeEvaluator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableLlmAsJudgeEvaluator)
            {
                unstableLlmAsJudgeEvaluator?.Invoke(UnstableLlmAsJudgeEvaluator!);
            }
            else if (IsUnstableCodeEvaluator)
            {
                unstableCodeEvaluator?.Invoke(UnstableCodeEvaluator!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableLlmAsJudgeEvaluator,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>),
                UnstableCodeEvaluator,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>),
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
        public bool Equals(UnstableEvaluator other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableLlmAsJudgeEvaluator2, global::Langfuse.UnstableLlmAsJudgeEvaluator>?>.Default.Equals(UnstableLlmAsJudgeEvaluator, other.UnstableLlmAsJudgeEvaluator) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorUnstableCodeEvaluator2, global::Langfuse.UnstableCodeEvaluator>?>.Default.Equals(UnstableCodeEvaluator, other.UnstableCodeEvaluator)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UnstableEvaluator obj1, UnstableEvaluator obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnstableEvaluator>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnstableEvaluator obj1, UnstableEvaluator obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnstableEvaluator o && Equals(o);
        }
    }
}
