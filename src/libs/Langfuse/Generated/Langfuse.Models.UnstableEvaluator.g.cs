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
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>? UnstableEvaluatorVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>? UnstableEvaluatorVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluatorVariant1))]
#endif
        public bool IsUnstableEvaluatorVariant1 => UnstableEvaluatorVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableEvaluatorVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>? value)
        {
            value = UnstableEvaluatorVariant1;
            return IsUnstableEvaluatorVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator> PickUnstableEvaluatorVariant1() => IsUnstableEvaluatorVariant1
            ? UnstableEvaluatorVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableEvaluatorVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>? UnstableEvaluatorVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>? UnstableEvaluatorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableEvaluatorVariant2))]
#endif
        public bool IsUnstableEvaluatorVariant2 => UnstableEvaluatorVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableEvaluatorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>? value)
        {
            value = UnstableEvaluatorVariant2;
            return IsUnstableEvaluatorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator> PickUnstableEvaluatorVariant2() => IsUnstableEvaluatorVariant2
            ? UnstableEvaluatorVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableEvaluatorVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluator(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator> value) => new UnstableEvaluator((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>?(UnstableEvaluator @this) => @this.UnstableEvaluatorVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluator(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>? value)
        {
            UnstableEvaluatorVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstableEvaluator FromUnstableEvaluatorVariant1(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>? value) => new UnstableEvaluator(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableEvaluator(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator> value) => new UnstableEvaluator((global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>?(UnstableEvaluator @this) => @this.UnstableEvaluatorVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluator(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>? value)
        {
            UnstableEvaluatorVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstableEvaluator FromUnstableEvaluatorVariant2(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>? value) => new UnstableEvaluator(value);

        /// <summary>
        /// 
        /// </summary>
        public UnstableEvaluator(
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>? unstableEvaluatorVariant1,
            global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>? unstableEvaluatorVariant2
            )
        {
            UnstableEvaluatorVariant1 = unstableEvaluatorVariant1;
            UnstableEvaluatorVariant2 = unstableEvaluatorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnstableEvaluatorVariant2 as object ??
            UnstableEvaluatorVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnstableEvaluatorVariant1?.ToString() ??
            UnstableEvaluatorVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnstableEvaluatorVariant1 && !IsUnstableEvaluatorVariant2 || !IsUnstableEvaluatorVariant1 && IsUnstableEvaluatorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>?, TResult>? unstableEvaluatorVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>?, TResult>? unstableEvaluatorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluatorVariant1 && unstableEvaluatorVariant1 != null)
            {
                return unstableEvaluatorVariant1(UnstableEvaluatorVariant1!);
            }
            else if (IsUnstableEvaluatorVariant2 && unstableEvaluatorVariant2 != null)
            {
                return unstableEvaluatorVariant2(UnstableEvaluatorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>?>? unstableEvaluatorVariant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>?>? unstableEvaluatorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluatorVariant1)
            {
                unstableEvaluatorVariant1?.Invoke(UnstableEvaluatorVariant1!);
            }
            else if (IsUnstableEvaluatorVariant2)
            {
                unstableEvaluatorVariant2?.Invoke(UnstableEvaluatorVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>?>? unstableEvaluatorVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>?>? unstableEvaluatorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableEvaluatorVariant1)
            {
                unstableEvaluatorVariant1?.Invoke(UnstableEvaluatorVariant1!);
            }
            else if (IsUnstableEvaluatorVariant2)
            {
                unstableEvaluatorVariant2?.Invoke(UnstableEvaluatorVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableEvaluatorVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>),
                UnstableEvaluatorVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>),
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
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant12, global::Langfuse.UnstableLlmAsJudgeEvaluator>?>.Default.Equals(UnstableEvaluatorVariant1, other.UnstableEvaluatorVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableEvaluatorVariant22, global::Langfuse.UnstableCodeEvaluator>?>.Default.Equals(UnstableEvaluatorVariant2, other.UnstableEvaluatorVariant2) 
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
