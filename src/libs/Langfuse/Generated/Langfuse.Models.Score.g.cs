#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Score : global::System.IEquatable<Score>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>? ScoreVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>? ScoreVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreVariant1))]
#endif
        public bool IsScoreVariant1 => ScoreVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>? ScoreVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>? ScoreVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreVariant2))]
#endif
        public bool IsScoreVariant2 => ScoreVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>? ScoreVariant3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>? ScoreVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreVariant3))]
#endif
        public bool IsScoreVariant3 => ScoreVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>? ScoreVariant4 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>? ScoreVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreVariant4))]
#endif
        public bool IsScoreVariant4 => ScoreVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>? ScoreVariant5 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>? ScoreVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreVariant5))]
#endif
        public bool IsScoreVariant5 => ScoreVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore> value) => new Score((global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?(Score @this) => @this.ScoreVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>? value)
        {
            ScoreVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore> value) => new Score((global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?(Score @this) => @this.ScoreVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>? value)
        {
            ScoreVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore> value) => new Score((global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?(Score @this) => @this.ScoreVariant3;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>? value)
        {
            ScoreVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore> value) => new Score((global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?(Score @this) => @this.ScoreVariant4;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>? value)
        {
            ScoreVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore> value) => new Score((global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>?(Score @this) => @this.ScoreVariant5;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>? value)
        {
            ScoreVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Score(
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>? scoreVariant1,
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>? scoreVariant2,
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>? scoreVariant3,
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>? scoreVariant4,
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>? scoreVariant5
            )
        {
            ScoreVariant1 = scoreVariant1;
            ScoreVariant2 = scoreVariant2;
            ScoreVariant3 = scoreVariant3;
            ScoreVariant4 = scoreVariant4;
            ScoreVariant5 = scoreVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScoreVariant5 as object ??
            ScoreVariant4 as object ??
            ScoreVariant3 as object ??
            ScoreVariant2 as object ??
            ScoreVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScoreVariant1?.ToString() ??
            ScoreVariant2?.ToString() ??
            ScoreVariant3?.ToString() ??
            ScoreVariant4?.ToString() ??
            ScoreVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScoreVariant1 && !IsScoreVariant2 && !IsScoreVariant3 && !IsScoreVariant4 && !IsScoreVariant5 || !IsScoreVariant1 && IsScoreVariant2 && !IsScoreVariant3 && !IsScoreVariant4 && !IsScoreVariant5 || !IsScoreVariant1 && !IsScoreVariant2 && IsScoreVariant3 && !IsScoreVariant4 && !IsScoreVariant5 || !IsScoreVariant1 && !IsScoreVariant2 && !IsScoreVariant3 && IsScoreVariant4 && !IsScoreVariant5 || !IsScoreVariant1 && !IsScoreVariant2 && !IsScoreVariant3 && !IsScoreVariant4 && IsScoreVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?, TResult>? scoreVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?, TResult>? scoreVariant2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?, TResult>? scoreVariant3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?, TResult>? scoreVariant4 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>?, TResult>? scoreVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreVariant1 && scoreVariant1 != null)
            {
                return scoreVariant1(ScoreVariant1!);
            }
            else if (IsScoreVariant2 && scoreVariant2 != null)
            {
                return scoreVariant2(ScoreVariant2!);
            }
            else if (IsScoreVariant3 && scoreVariant3 != null)
            {
                return scoreVariant3(ScoreVariant3!);
            }
            else if (IsScoreVariant4 && scoreVariant4 != null)
            {
                return scoreVariant4(ScoreVariant4!);
            }
            else if (IsScoreVariant5 && scoreVariant5 != null)
            {
                return scoreVariant5(ScoreVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?>? scoreVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?>? scoreVariant2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?>? scoreVariant3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?>? scoreVariant4 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>?>? scoreVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreVariant1)
            {
                scoreVariant1?.Invoke(ScoreVariant1!);
            }
            else if (IsScoreVariant2)
            {
                scoreVariant2?.Invoke(ScoreVariant2!);
            }
            else if (IsScoreVariant3)
            {
                scoreVariant3?.Invoke(ScoreVariant3!);
            }
            else if (IsScoreVariant4)
            {
                scoreVariant4?.Invoke(ScoreVariant4!);
            }
            else if (IsScoreVariant5)
            {
                scoreVariant5?.Invoke(ScoreVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScoreVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>),
                ScoreVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>),
                ScoreVariant3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>),
                ScoreVariant4,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>),
                ScoreVariant5,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>),
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
        public bool Equals(Score other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?>.Default.Equals(ScoreVariant1, other.ScoreVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?>.Default.Equals(ScoreVariant2, other.ScoreVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?>.Default.Equals(ScoreVariant3, other.ScoreVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?>.Default.Equals(ScoreVariant4, other.ScoreVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreVariant52, global::Langfuse.TextScore>?>.Default.Equals(ScoreVariant5, other.ScoreVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Score obj1, Score obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Score>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Score obj1, Score obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Score o && Equals(o);
        }
    }
}
