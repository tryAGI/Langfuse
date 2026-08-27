#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ScoreV3 : global::System.IEquatable<ScoreV3>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>? ScoreV3Variant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>? ScoreV3Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreV3Variant1))]
#endif
        public bool IsScoreV3Variant1 => ScoreV3Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreV3Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>? value)
        {
            value = ScoreV3Variant1;
            return IsScoreV3Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3> PickScoreV3Variant1() => IsScoreV3Variant1
            ? ScoreV3Variant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreV3Variant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>? ScoreV3Variant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>? ScoreV3Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreV3Variant2))]
#endif
        public bool IsScoreV3Variant2 => ScoreV3Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreV3Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>? value)
        {
            value = ScoreV3Variant2;
            return IsScoreV3Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3> PickScoreV3Variant2() => IsScoreV3Variant2
            ? ScoreV3Variant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreV3Variant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>? ScoreV3Variant3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>? ScoreV3Variant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreV3Variant3))]
#endif
        public bool IsScoreV3Variant3 => ScoreV3Variant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreV3Variant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>? value)
        {
            value = ScoreV3Variant3;
            return IsScoreV3Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3> PickScoreV3Variant3() => IsScoreV3Variant3
            ? ScoreV3Variant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreV3Variant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>? ScoreV3Variant4 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>? ScoreV3Variant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreV3Variant4))]
#endif
        public bool IsScoreV3Variant4 => ScoreV3Variant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreV3Variant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>? value)
        {
            value = ScoreV3Variant4;
            return IsScoreV3Variant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3> PickScoreV3Variant4() => IsScoreV3Variant4
            ? ScoreV3Variant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreV3Variant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>? ScoreV3Variant5 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>? ScoreV3Variant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreV3Variant5))]
#endif
        public bool IsScoreV3Variant5 => ScoreV3Variant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreV3Variant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>? value)
        {
            value = ScoreV3Variant5;
            return IsScoreV3Variant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3> PickScoreV3Variant5() => IsScoreV3Variant5
            ? ScoreV3Variant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreV3Variant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3> value) => new ScoreV3((global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>?(ScoreV3 @this) => @this.ScoreV3Variant1;

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>? value)
        {
            ScoreV3Variant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV3 FromScoreV3Variant1(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>? value) => new ScoreV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3> value) => new ScoreV3((global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>?(ScoreV3 @this) => @this.ScoreV3Variant2;

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>? value)
        {
            ScoreV3Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV3 FromScoreV3Variant2(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>? value) => new ScoreV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3> value) => new ScoreV3((global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>?(ScoreV3 @this) => @this.ScoreV3Variant3;

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>? value)
        {
            ScoreV3Variant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV3 FromScoreV3Variant3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>? value) => new ScoreV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3> value) => new ScoreV3((global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>?(ScoreV3 @this) => @this.ScoreV3Variant4;

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>? value)
        {
            ScoreV3Variant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV3 FromScoreV3Variant4(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>? value) => new ScoreV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3> value) => new ScoreV3((global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>?(ScoreV3 @this) => @this.ScoreV3Variant5;

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>? value)
        {
            ScoreV3Variant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreV3 FromScoreV3Variant5(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>? value) => new ScoreV3(value);

        /// <summary>
        ///
        /// </summary>
        public ScoreV3(
            global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>? scoreV3Variant1,
            global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>? scoreV3Variant2,
            global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>? scoreV3Variant3,
            global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>? scoreV3Variant4,
            global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>? scoreV3Variant5
            )
        {
            ScoreV3Variant1 = scoreV3Variant1;
            ScoreV3Variant2 = scoreV3Variant2;
            ScoreV3Variant3 = scoreV3Variant3;
            ScoreV3Variant4 = scoreV3Variant4;
            ScoreV3Variant5 = scoreV3Variant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ScoreV3Variant5 as object ??
            ScoreV3Variant4 as object ??
            ScoreV3Variant3 as object ??
            ScoreV3Variant2 as object ??
            ScoreV3Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ScoreV3Variant1?.ToString() ??
            ScoreV3Variant2?.ToString() ??
            ScoreV3Variant3?.ToString() ??
            ScoreV3Variant4?.ToString() ??
            ScoreV3Variant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsScoreV3Variant1 && !IsScoreV3Variant2 && !IsScoreV3Variant3 && !IsScoreV3Variant4 && !IsScoreV3Variant5 || !IsScoreV3Variant1 && IsScoreV3Variant2 && !IsScoreV3Variant3 && !IsScoreV3Variant4 && !IsScoreV3Variant5 || !IsScoreV3Variant1 && !IsScoreV3Variant2 && IsScoreV3Variant3 && !IsScoreV3Variant4 && !IsScoreV3Variant5 || !IsScoreV3Variant1 && !IsScoreV3Variant2 && !IsScoreV3Variant3 && IsScoreV3Variant4 && !IsScoreV3Variant5 || !IsScoreV3Variant1 && !IsScoreV3Variant2 && !IsScoreV3Variant3 && !IsScoreV3Variant4 && IsScoreV3Variant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>?, TResult>? scoreV3Variant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>?, TResult>? scoreV3Variant2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>?, TResult>? scoreV3Variant3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>?, TResult>? scoreV3Variant4 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>?, TResult>? scoreV3Variant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreV3Variant1 && scoreV3Variant1 != null)
            {
                return scoreV3Variant1(ScoreV3Variant1!);
            }
            else if (IsScoreV3Variant2 && scoreV3Variant2 != null)
            {
                return scoreV3Variant2(ScoreV3Variant2!);
            }
            else if (IsScoreV3Variant3 && scoreV3Variant3 != null)
            {
                return scoreV3Variant3(ScoreV3Variant3!);
            }
            else if (IsScoreV3Variant4 && scoreV3Variant4 != null)
            {
                return scoreV3Variant4(ScoreV3Variant4!);
            }
            else if (IsScoreV3Variant5 && scoreV3Variant5 != null)
            {
                return scoreV3Variant5(ScoreV3Variant5!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>?>? scoreV3Variant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>?>? scoreV3Variant2 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>?>? scoreV3Variant3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>?>? scoreV3Variant4 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>?>? scoreV3Variant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreV3Variant1)
            {
                scoreV3Variant1?.Invoke(ScoreV3Variant1!);
            }
            else if (IsScoreV3Variant2)
            {
                scoreV3Variant2?.Invoke(ScoreV3Variant2!);
            }
            else if (IsScoreV3Variant3)
            {
                scoreV3Variant3?.Invoke(ScoreV3Variant3!);
            }
            else if (IsScoreV3Variant4)
            {
                scoreV3Variant4?.Invoke(ScoreV3Variant4!);
            }
            else if (IsScoreV3Variant5)
            {
                scoreV3Variant5?.Invoke(ScoreV3Variant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>?>? scoreV3Variant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>?>? scoreV3Variant2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>?>? scoreV3Variant3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>?>? scoreV3Variant4 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>?>? scoreV3Variant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreV3Variant1)
            {
                scoreV3Variant1?.Invoke(ScoreV3Variant1!);
            }
            else if (IsScoreV3Variant2)
            {
                scoreV3Variant2?.Invoke(ScoreV3Variant2!);
            }
            else if (IsScoreV3Variant3)
            {
                scoreV3Variant3?.Invoke(ScoreV3Variant3!);
            }
            else if (IsScoreV3Variant4)
            {
                scoreV3Variant4?.Invoke(ScoreV3Variant4!);
            }
            else if (IsScoreV3Variant5)
            {
                scoreV3Variant5?.Invoke(ScoreV3Variant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScoreV3Variant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>),
                ScoreV3Variant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>),
                ScoreV3Variant3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>),
                ScoreV3Variant4,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>),
                ScoreV3Variant5,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>),
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
        public bool Equals(ScoreV3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant12, global::Langfuse.NumericScoreV3>?>.Default.Equals(ScoreV3Variant1, other.ScoreV3Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant22, global::Langfuse.BooleanScoreV3>?>.Default.Equals(ScoreV3Variant2, other.ScoreV3Variant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant32, global::Langfuse.CategoricalScoreV3>?>.Default.Equals(ScoreV3Variant3, other.ScoreV3Variant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant42, global::Langfuse.TextScoreV3>?>.Default.Equals(ScoreV3Variant4, other.ScoreV3Variant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreV3Variant52, global::Langfuse.CorrectionScoreV3>?>.Default.Equals(ScoreV3Variant5, other.ScoreV3Variant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ScoreV3 obj1, ScoreV3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScoreV3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScoreV3 obj1, ScoreV3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScoreV3 o && Equals(o);
        }
    }
}
