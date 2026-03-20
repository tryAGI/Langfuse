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
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>? Value1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>? Value2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>? Value3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>? Value4 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore> value) => new Score((global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?(Score @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore> value) => new Score((global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?(Score @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore> value) => new Score((global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?(Score @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore> value) => new Score((global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?(Score @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Score(
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>? value1,
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>? value2,
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>? value3,
            global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>? value4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?, TResult>? value1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?, TResult>? value2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?, TResult>? value3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?, TResult>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?>? value1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?>? value2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?>? value3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>),
                Value2,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>),
                Value3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>),
                Value4,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>),
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
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreVariant12, global::Langfuse.NumericScore>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreVariant22, global::Langfuse.CategoricalScore>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreVariant32, global::Langfuse.BooleanScore>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreVariant42, global::Langfuse.CorrectionScore>?>.Default.Equals(Value4, other.Value4) 
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
