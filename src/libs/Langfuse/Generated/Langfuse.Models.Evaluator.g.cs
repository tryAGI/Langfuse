#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One evaluator that can be used for scoring.<br/>
    /// An evaluator describes **how** to score data. Associated evaluation rules describe **which** live objects should be evaluated.
    /// </summary>
    public readonly partial struct Evaluator : global::System.IEquatable<Evaluator>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? LlmAsJudgeEvaluator { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? LlmAsJudgeEvaluator { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LlmAsJudgeEvaluator))]
#endif
        public bool IsLlmAsJudgeEvaluator => LlmAsJudgeEvaluator != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLlmAsJudgeEvaluator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? value)
        {
            value = LlmAsJudgeEvaluator;
            return IsLlmAsJudgeEvaluator;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator> PickLlmAsJudgeEvaluator() => IsLlmAsJudgeEvaluator
            ? LlmAsJudgeEvaluator!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LlmAsJudgeEvaluator' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? CodeEvaluator { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? CodeEvaluator { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeEvaluator))]
#endif
        public bool IsCodeEvaluator => CodeEvaluator != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeEvaluator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? value)
        {
            value = CodeEvaluator;
            return IsCodeEvaluator;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator> PickCodeEvaluator() => IsCodeEvaluator
            ? CodeEvaluator!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeEvaluator' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Evaluator(global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator> value) => new Evaluator((global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>?(Evaluator @this) => @this.LlmAsJudgeEvaluator;

        /// <summary>
        ///
        /// </summary>
        public Evaluator(global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? value)
        {
            LlmAsJudgeEvaluator = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Evaluator FromLlmAsJudgeEvaluator(global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? value) => new Evaluator(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Evaluator(global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator> value) => new Evaluator((global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>?(Evaluator @this) => @this.CodeEvaluator;

        /// <summary>
        ///
        /// </summary>
        public Evaluator(global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? value)
        {
            CodeEvaluator = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Evaluator FromCodeEvaluator(global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? value) => new Evaluator(value);

        /// <summary>
        ///
        /// </summary>
        public Evaluator(
            global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>? llmAsJudgeEvaluator,
            global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>? codeEvaluator
            )
        {
            LlmAsJudgeEvaluator = llmAsJudgeEvaluator;
            CodeEvaluator = codeEvaluator;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CodeEvaluator as object ??
            LlmAsJudgeEvaluator as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            LlmAsJudgeEvaluator?.ToString() ??
            CodeEvaluator?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLlmAsJudgeEvaluator && !IsCodeEvaluator || !IsLlmAsJudgeEvaluator && IsCodeEvaluator;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>?, TResult>? llmAsJudgeEvaluator = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>?, TResult>? codeEvaluator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLlmAsJudgeEvaluator && llmAsJudgeEvaluator != null)
            {
                return llmAsJudgeEvaluator(LlmAsJudgeEvaluator!);
            }
            else if (IsCodeEvaluator && codeEvaluator != null)
            {
                return codeEvaluator(CodeEvaluator!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>?>? llmAsJudgeEvaluator = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>?>? codeEvaluator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLlmAsJudgeEvaluator)
            {
                llmAsJudgeEvaluator?.Invoke(LlmAsJudgeEvaluator!);
            }
            else if (IsCodeEvaluator)
            {
                codeEvaluator?.Invoke(CodeEvaluator!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>?>? llmAsJudgeEvaluator = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>?>? codeEvaluator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLlmAsJudgeEvaluator)
            {
                llmAsJudgeEvaluator?.Invoke(LlmAsJudgeEvaluator!);
            }
            else if (IsCodeEvaluator)
            {
                codeEvaluator?.Invoke(CodeEvaluator!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LlmAsJudgeEvaluator,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>),
                CodeEvaluator,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>),
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
        public bool Equals(Evaluator other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluatorLlmAsJudgeEvaluator2, global::Langfuse.LlmAsJudgeEvaluator>?>.Default.Equals(LlmAsJudgeEvaluator, other.LlmAsJudgeEvaluator) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluatorCodeEvaluator2, global::Langfuse.CodeEvaluator>?>.Default.Equals(CodeEvaluator, other.CodeEvaluator)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Evaluator obj1, Evaluator obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Evaluator>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Evaluator obj1, Evaluator obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Evaluator o && Equals(o);
        }
    }
}
