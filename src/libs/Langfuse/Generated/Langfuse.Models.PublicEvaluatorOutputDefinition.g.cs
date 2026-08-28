#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Flat evaluator output definition returned by the public API.<br/>
    /// This response always includes `dataType` and never includes an internal output-definition `version`.<br/>
    /// Optional empty descriptions from legacy definitions are omitted.
    /// </summary>
    public readonly partial struct PublicEvaluatorOutputDefinition : global::System.IEquatable<PublicEvaluatorOutputDefinition>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? PublicEvaluatorNumericScore { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? PublicEvaluatorNumericScore { get; }
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
            out global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? value)
        {
            value = PublicEvaluatorNumericScore;
            return IsPublicEvaluatorNumericScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore> PickPublicEvaluatorNumericScore() => IsPublicEvaluatorNumericScore
            ? PublicEvaluatorNumericScore!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PublicEvaluatorNumericScore' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? PublicEvaluatorBooleanScore { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? PublicEvaluatorBooleanScore { get; }
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
            out global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? value)
        {
            value = PublicEvaluatorBooleanScore;
            return IsPublicEvaluatorBooleanScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore> PickPublicEvaluatorBooleanScore() => IsPublicEvaluatorBooleanScore
            ? PublicEvaluatorBooleanScore!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PublicEvaluatorBooleanScore' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? PublicEvaluatorCategoricalScore { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? PublicEvaluatorCategoricalScore { get; }
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
            out global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? value)
        {
            value = PublicEvaluatorCategoricalScore;
            return IsPublicEvaluatorCategoricalScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore> PickPublicEvaluatorCategoricalScore() => IsPublicEvaluatorCategoricalScore
            ? PublicEvaluatorCategoricalScore!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PublicEvaluatorCategoricalScore' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore> value) => new PublicEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?(PublicEvaluatorOutputDefinition @this) => @this.PublicEvaluatorNumericScore;

        /// <summary>
        ///
        /// </summary>
        public PublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? value)
        {
            PublicEvaluatorNumericScore = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PublicEvaluatorOutputDefinition FromPublicEvaluatorNumericScore(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? value) => new PublicEvaluatorOutputDefinition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore> value) => new PublicEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?(PublicEvaluatorOutputDefinition @this) => @this.PublicEvaluatorBooleanScore;

        /// <summary>
        ///
        /// </summary>
        public PublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? value)
        {
            PublicEvaluatorBooleanScore = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PublicEvaluatorOutputDefinition FromPublicEvaluatorBooleanScore(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? value) => new PublicEvaluatorOutputDefinition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore> value) => new PublicEvaluatorOutputDefinition((global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?(PublicEvaluatorOutputDefinition @this) => @this.PublicEvaluatorCategoricalScore;

        /// <summary>
        ///
        /// </summary>
        public PublicEvaluatorOutputDefinition(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? value)
        {
            PublicEvaluatorCategoricalScore = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PublicEvaluatorOutputDefinition FromPublicEvaluatorCategoricalScore(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? value) => new PublicEvaluatorOutputDefinition(value);

        /// <summary>
        ///
        /// </summary>
        public PublicEvaluatorOutputDefinition(
            global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>? publicEvaluatorNumericScore,
            global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>? publicEvaluatorBooleanScore,
            global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>? publicEvaluatorCategoricalScore
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
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?, TResult>? publicEvaluatorNumericScore = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?, TResult>? publicEvaluatorBooleanScore = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?, TResult>? publicEvaluatorCategoricalScore = null,
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
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?>? publicEvaluatorNumericScore = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?>? publicEvaluatorBooleanScore = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?>? publicEvaluatorCategoricalScore = null,
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
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?>? publicEvaluatorNumericScore = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?>? publicEvaluatorBooleanScore = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?>? publicEvaluatorCategoricalScore = null,
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
                typeof(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>),
                PublicEvaluatorBooleanScore,
                typeof(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>),
                PublicEvaluatorCategoricalScore,
                typeof(global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>),
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
        public bool Equals(PublicEvaluatorOutputDefinition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorNumericScore2, global::Langfuse.PublicEvaluatorNumericScore>?>.Default.Equals(PublicEvaluatorNumericScore, other.PublicEvaluatorNumericScore) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorBooleanScore2, global::Langfuse.PublicEvaluatorBooleanScore>?>.Default.Equals(PublicEvaluatorBooleanScore, other.PublicEvaluatorBooleanScore) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.PublicEvaluatorOutputDefinitionPublicEvaluatorCategoricalScore2, global::Langfuse.PublicEvaluatorCategoricalScore>?>.Default.Equals(PublicEvaluatorCategoricalScore, other.PublicEvaluatorCategoricalScore)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PublicEvaluatorOutputDefinition obj1, PublicEvaluatorOutputDefinition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PublicEvaluatorOutputDefinition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PublicEvaluatorOutputDefinition obj1, PublicEvaluatorOutputDefinition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PublicEvaluatorOutputDefinition o && Equals(o);
        }
    }
}
