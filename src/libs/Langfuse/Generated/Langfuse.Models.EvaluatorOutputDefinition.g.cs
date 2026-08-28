#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Flat structured output definition used when creating or updating an evaluator.<br/>
    /// - `dataType` is required.<br/>
    /// - `scoreReasoningInstructions` and `scoreValueInstructions` are optional instructions.<br/>
    /// - `minValue` and `maxValue` apply only to `NUMERIC` outputs. If both are set, `minValue` must not exceed `maxValue`.<br/>
    /// - `categories` and `shouldAllowMultipleMatches` apply only to `CATEGORICAL` outputs.<br/>
    /// - Do not send `version`; that is an internal storage detail.
    /// </summary>
    public readonly partial struct EvaluatorOutputDefinition : global::System.IEquatable<EvaluatorOutputDefinition>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? PublicEvaluatorNumericScore { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? PublicEvaluatorNumericScore { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PublicEvaluatorNumericScore))]
#endif
        public bool IsPublicEvaluatorNumericScore => PublicEvaluatorNumericScore != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPublicEvaluatorNumericScore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? value)
        {
            value = PublicEvaluatorNumericScore;
            return IsPublicEvaluatorNumericScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore> PickPublicEvaluatorNumericScore() => IsPublicEvaluatorNumericScore
            ? PublicEvaluatorNumericScore!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PublicEvaluatorNumericScore' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? PublicEvaluatorBooleanScore { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? PublicEvaluatorBooleanScore { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PublicEvaluatorBooleanScore))]
#endif
        public bool IsPublicEvaluatorBooleanScore => PublicEvaluatorBooleanScore != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPublicEvaluatorBooleanScore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? value)
        {
            value = PublicEvaluatorBooleanScore;
            return IsPublicEvaluatorBooleanScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore> PickPublicEvaluatorBooleanScore() => IsPublicEvaluatorBooleanScore
            ? PublicEvaluatorBooleanScore!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PublicEvaluatorBooleanScore' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? PublicEvaluatorCategoricalScore { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? PublicEvaluatorCategoricalScore { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PublicEvaluatorCategoricalScore))]
#endif
        public bool IsPublicEvaluatorCategoricalScore => PublicEvaluatorCategoricalScore != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPublicEvaluatorCategoricalScore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? value)
        {
            value = PublicEvaluatorCategoricalScore;
            return IsPublicEvaluatorCategoricalScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore> PickPublicEvaluatorCategoricalScore() => IsPublicEvaluatorCategoricalScore
            ? PublicEvaluatorCategoricalScore!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PublicEvaluatorCategoricalScore' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore> value) => new EvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?(EvaluatorOutputDefinition @this) => @this.PublicEvaluatorNumericScore;

        /// <summary>
        ///
        /// </summary>
        public EvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? value)
        {
            PublicEvaluatorNumericScore = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluatorOutputDefinition FromPublicEvaluatorNumericScore(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? value) => new EvaluatorOutputDefinition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore> value) => new EvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?(EvaluatorOutputDefinition @this) => @this.PublicEvaluatorBooleanScore;

        /// <summary>
        ///
        /// </summary>
        public EvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? value)
        {
            PublicEvaluatorBooleanScore = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluatorOutputDefinition FromPublicEvaluatorBooleanScore(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? value) => new EvaluatorOutputDefinition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore> value) => new EvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?(EvaluatorOutputDefinition @this) => @this.PublicEvaluatorCategoricalScore;

        /// <summary>
        ///
        /// </summary>
        public EvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? value)
        {
            PublicEvaluatorCategoricalScore = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluatorOutputDefinition FromPublicEvaluatorCategoricalScore(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? value) => new EvaluatorOutputDefinition(value);

        /// <summary>
        ///
        /// </summary>
        public EvaluatorOutputDefinition(
            global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? publicEvaluatorNumericScore,
            global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? publicEvaluatorBooleanScore,
            global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? publicEvaluatorCategoricalScore
            )
        {
            PublicEvaluatorNumericScore = publicEvaluatorNumericScore;
            PublicEvaluatorBooleanScore = publicEvaluatorBooleanScore;
            PublicEvaluatorCategoricalScore = publicEvaluatorCategoricalScore;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PublicEvaluatorCategoricalScore as object ??
            PublicEvaluatorBooleanScore as object ??
            PublicEvaluatorNumericScore as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PublicEvaluatorNumericScore?.ToString() ??
            PublicEvaluatorBooleanScore?.ToString() ??
            PublicEvaluatorCategoricalScore?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPublicEvaluatorNumericScore && !IsPublicEvaluatorBooleanScore && !IsPublicEvaluatorCategoricalScore || !IsPublicEvaluatorNumericScore && IsPublicEvaluatorBooleanScore && !IsPublicEvaluatorCategoricalScore || !IsPublicEvaluatorNumericScore && !IsPublicEvaluatorBooleanScore && IsPublicEvaluatorCategoricalScore;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?, TResult>? publicEvaluatorNumericScore = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?, TResult>? publicEvaluatorBooleanScore = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?, TResult>? publicEvaluatorCategoricalScore = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPublicEvaluatorNumericScore && publicEvaluatorNumericScore != null)
            {
                return publicEvaluatorNumericScore(PublicEvaluatorNumericScore!);
            }
            else if (IsPublicEvaluatorBooleanScore && publicEvaluatorBooleanScore != null)
            {
                return publicEvaluatorBooleanScore(PublicEvaluatorBooleanScore!);
            }
            else if (IsPublicEvaluatorCategoricalScore && publicEvaluatorCategoricalScore != null)
            {
                return publicEvaluatorCategoricalScore(PublicEvaluatorCategoricalScore!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?>? publicEvaluatorNumericScore = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?>? publicEvaluatorBooleanScore = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?>? publicEvaluatorCategoricalScore = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPublicEvaluatorNumericScore)
            {
                publicEvaluatorNumericScore?.Invoke(PublicEvaluatorNumericScore!);
            }
            else if (IsPublicEvaluatorBooleanScore)
            {
                publicEvaluatorBooleanScore?.Invoke(PublicEvaluatorBooleanScore!);
            }
            else if (IsPublicEvaluatorCategoricalScore)
            {
                publicEvaluatorCategoricalScore?.Invoke(PublicEvaluatorCategoricalScore!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?>? publicEvaluatorNumericScore = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?>? publicEvaluatorBooleanScore = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?>? publicEvaluatorCategoricalScore = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPublicEvaluatorNumericScore)
            {
                publicEvaluatorNumericScore?.Invoke(PublicEvaluatorNumericScore!);
            }
            else if (IsPublicEvaluatorBooleanScore)
            {
                publicEvaluatorBooleanScore?.Invoke(PublicEvaluatorBooleanScore!);
            }
            else if (IsPublicEvaluatorCategoricalScore)
            {
                publicEvaluatorCategoricalScore?.Invoke(PublicEvaluatorCategoricalScore!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PublicEvaluatorNumericScore,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>),
                PublicEvaluatorBooleanScore,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>),
                PublicEvaluatorCategoricalScore,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>),
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
        public bool Equals(EvaluatorOutputDefinition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?>.Default.Equals(PublicEvaluatorNumericScore, other.PublicEvaluatorNumericScore) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?>.Default.Equals(PublicEvaluatorBooleanScore, other.PublicEvaluatorBooleanScore) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?>.Default.Equals(PublicEvaluatorCategoricalScore, other.PublicEvaluatorCategoricalScore)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EvaluatorOutputDefinition obj1, EvaluatorOutputDefinition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvaluatorOutputDefinition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EvaluatorOutputDefinition obj1, EvaluatorOutputDefinition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvaluatorOutputDefinition o && Equals(o);
        }
    }
}
