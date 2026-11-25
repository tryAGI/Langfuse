#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// One typed question answered by a decision-model evaluator. Each question produces one score.
    /// </summary>
    public readonly partial struct DecisionModelQuestion : global::System.IEquatable<DecisionModelQuestion>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>? DecisionModelChoiceQuestion { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>? DecisionModelChoiceQuestion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionModelChoiceQuestion))]
#endif
        public bool IsDecisionModelChoiceQuestion => DecisionModelChoiceQuestion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionModelChoiceQuestion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>? value)
        {
            value = DecisionModelChoiceQuestion;
            return IsDecisionModelChoiceQuestion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion> PickDecisionModelChoiceQuestion() => DecisionModelChoiceQuestion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionModelChoiceQuestion' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>? DecisionModelScoreQuestion { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>? DecisionModelScoreQuestion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionModelScoreQuestion))]
#endif
        public bool IsDecisionModelScoreQuestion => DecisionModelScoreQuestion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionModelScoreQuestion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>? value)
        {
            value = DecisionModelScoreQuestion;
            return IsDecisionModelScoreQuestion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion> PickDecisionModelScoreQuestion() => DecisionModelScoreQuestion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionModelScoreQuestion' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>? DecisionModelBooleanQuestion { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>? DecisionModelBooleanQuestion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionModelBooleanQuestion))]
#endif
        public bool IsDecisionModelBooleanQuestion => DecisionModelBooleanQuestion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionModelBooleanQuestion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>? value)
        {
            value = DecisionModelBooleanQuestion;
            return IsDecisionModelBooleanQuestion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion> PickDecisionModelBooleanQuestion() => DecisionModelBooleanQuestion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionModelBooleanQuestion' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionModelQuestion(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion> value) => new DecisionModelQuestion((global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>?(DecisionModelQuestion @this) => @this.DecisionModelChoiceQuestion;

        /// <summary>
        ///
        /// </summary>
        public DecisionModelQuestion(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>? value)
        {
            DecisionModelChoiceQuestion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionModelQuestion FromDecisionModelChoiceQuestion(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>? value) => new DecisionModelQuestion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionModelQuestion(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion> value) => new DecisionModelQuestion((global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>?(DecisionModelQuestion @this) => @this.DecisionModelScoreQuestion;

        /// <summary>
        ///
        /// </summary>
        public DecisionModelQuestion(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>? value)
        {
            DecisionModelScoreQuestion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionModelQuestion FromDecisionModelScoreQuestion(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>? value) => new DecisionModelQuestion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionModelQuestion(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion> value) => new DecisionModelQuestion((global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>?(DecisionModelQuestion @this) => @this.DecisionModelBooleanQuestion;

        /// <summary>
        ///
        /// </summary>
        public DecisionModelQuestion(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>? value)
        {
            DecisionModelBooleanQuestion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionModelQuestion FromDecisionModelBooleanQuestion(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>? value) => new DecisionModelQuestion(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionModelQuestion(
            global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>? decisionModelChoiceQuestion,
            global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>? decisionModelScoreQuestion,
            global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>? decisionModelBooleanQuestion
            )
        {
            DecisionModelChoiceQuestion = decisionModelChoiceQuestion;
            DecisionModelScoreQuestion = decisionModelScoreQuestion;
            DecisionModelBooleanQuestion = decisionModelBooleanQuestion;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DecisionModelBooleanQuestion as object ??
            DecisionModelScoreQuestion as object ??
            DecisionModelChoiceQuestion as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DecisionModelChoiceQuestion?.ToString() ??
            DecisionModelScoreQuestion?.ToString() ??
            DecisionModelBooleanQuestion?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDecisionModelChoiceQuestion && !IsDecisionModelScoreQuestion && !IsDecisionModelBooleanQuestion || !IsDecisionModelChoiceQuestion && IsDecisionModelScoreQuestion && !IsDecisionModelBooleanQuestion || !IsDecisionModelChoiceQuestion && !IsDecisionModelScoreQuestion && IsDecisionModelBooleanQuestion;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>?, TResult>? decisionModelChoiceQuestion = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>?, TResult>? decisionModelScoreQuestion = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>?, TResult>? decisionModelBooleanQuestion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionModelChoiceQuestion is { } __value0 && decisionModelChoiceQuestion != null)
            {
                return decisionModelChoiceQuestion(__value0);
            }
            else if (DecisionModelScoreQuestion is { } __value1 && decisionModelScoreQuestion != null)
            {
                return decisionModelScoreQuestion(__value1);
            }
            else if (DecisionModelBooleanQuestion is { } __value2 && decisionModelBooleanQuestion != null)
            {
                return decisionModelBooleanQuestion(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>?>? decisionModelChoiceQuestion = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>?>? decisionModelScoreQuestion = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>?>? decisionModelBooleanQuestion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionModelChoiceQuestion is { } __value0)
            {
                decisionModelChoiceQuestion?.Invoke(__value0);
            }
            else if (DecisionModelScoreQuestion is { } __value1)
            {
                decisionModelScoreQuestion?.Invoke(__value1);
            }
            else if (DecisionModelBooleanQuestion is { } __value2)
            {
                decisionModelBooleanQuestion?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>?>? decisionModelChoiceQuestion = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>?>? decisionModelScoreQuestion = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>?>? decisionModelBooleanQuestion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionModelChoiceQuestion is { } __value0)
            {
                decisionModelChoiceQuestion?.Invoke(__value0);
            }
            else if (DecisionModelScoreQuestion is { } __value1)
            {
                decisionModelScoreQuestion?.Invoke(__value1);
            }
            else if (DecisionModelBooleanQuestion is { } __value2)
            {
                decisionModelBooleanQuestion?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DecisionModelChoiceQuestion,
                typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>),
                DecisionModelScoreQuestion,
                typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>),
                DecisionModelBooleanQuestion,
                typeof(global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>),
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
        public bool Equals(DecisionModelQuestion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelChoiceQuestion2, global::Langfuse.DecisionModelChoiceQuestion>?>.Default.Equals(DecisionModelChoiceQuestion, other.DecisionModelChoiceQuestion) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelScoreQuestion2, global::Langfuse.DecisionModelScoreQuestion>?>.Default.Equals(DecisionModelScoreQuestion, other.DecisionModelScoreQuestion) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.DecisionModelQuestionDecisionModelBooleanQuestion2, global::Langfuse.DecisionModelBooleanQuestion>?>.Default.Equals(DecisionModelBooleanQuestion, other.DecisionModelBooleanQuestion)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionModelQuestion obj1, DecisionModelQuestion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionModelQuestion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionModelQuestion obj1, DecisionModelQuestion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionModelQuestion o && Equals(o);
        }
    }
}
