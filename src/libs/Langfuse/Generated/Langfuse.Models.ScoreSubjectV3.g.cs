#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// A reference to the entity this score is attached to. Discriminated by "kind" — one of trace, observation, session, or experiment.
    /// </summary>
    public readonly partial struct ScoreSubjectV3 : global::System.IEquatable<ScoreSubjectV3>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>? ScoreSubjectV3Variant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>? ScoreSubjectV3Variant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectV3Variant1))]
#endif
        public bool IsScoreSubjectV3Variant1 => ScoreSubjectV3Variant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScoreSubjectV3Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>? value)
        {
            value = ScoreSubjectV3Variant1;
            return IsScoreSubjectV3Variant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3> PickScoreSubjectV3Variant1() => IsScoreSubjectV3Variant1
            ? ScoreSubjectV3Variant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectV3Variant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>? ScoreSubjectV3Variant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>? ScoreSubjectV3Variant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectV3Variant2))]
#endif
        public bool IsScoreSubjectV3Variant2 => ScoreSubjectV3Variant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScoreSubjectV3Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>? value)
        {
            value = ScoreSubjectV3Variant2;
            return IsScoreSubjectV3Variant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3> PickScoreSubjectV3Variant2() => IsScoreSubjectV3Variant2
            ? ScoreSubjectV3Variant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectV3Variant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>? ScoreSubjectV3Variant3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>? ScoreSubjectV3Variant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectV3Variant3))]
#endif
        public bool IsScoreSubjectV3Variant3 => ScoreSubjectV3Variant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScoreSubjectV3Variant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>? value)
        {
            value = ScoreSubjectV3Variant3;
            return IsScoreSubjectV3Variant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3> PickScoreSubjectV3Variant3() => IsScoreSubjectV3Variant3
            ? ScoreSubjectV3Variant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectV3Variant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>? ScoreSubjectV3Variant4 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>? ScoreSubjectV3Variant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectV3Variant4))]
#endif
        public bool IsScoreSubjectV3Variant4 => ScoreSubjectV3Variant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScoreSubjectV3Variant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>? value)
        {
            value = ScoreSubjectV3Variant4;
            return IsScoreSubjectV3Variant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3> PickScoreSubjectV3Variant4() => IsScoreSubjectV3Variant4
            ? ScoreSubjectV3Variant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectV3Variant4' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3> value) => new ScoreSubjectV3((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>?(ScoreSubjectV3 @this) => @this.ScoreSubjectV3Variant1;

        /// <summary>
        /// 
        /// </summary>
        public ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>? value)
        {
            ScoreSubjectV3Variant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScoreSubjectV3 FromScoreSubjectV3Variant1(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>? value) => new ScoreSubjectV3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3> value) => new ScoreSubjectV3((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>?(ScoreSubjectV3 @this) => @this.ScoreSubjectV3Variant2;

        /// <summary>
        /// 
        /// </summary>
        public ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>? value)
        {
            ScoreSubjectV3Variant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScoreSubjectV3 FromScoreSubjectV3Variant2(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>? value) => new ScoreSubjectV3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3> value) => new ScoreSubjectV3((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>?(ScoreSubjectV3 @this) => @this.ScoreSubjectV3Variant3;

        /// <summary>
        /// 
        /// </summary>
        public ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>? value)
        {
            ScoreSubjectV3Variant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScoreSubjectV3 FromScoreSubjectV3Variant3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>? value) => new ScoreSubjectV3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3> value) => new ScoreSubjectV3((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>?(ScoreSubjectV3 @this) => @this.ScoreSubjectV3Variant4;

        /// <summary>
        /// 
        /// </summary>
        public ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>? value)
        {
            ScoreSubjectV3Variant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScoreSubjectV3 FromScoreSubjectV3Variant4(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>? value) => new ScoreSubjectV3(value);

        /// <summary>
        /// 
        /// </summary>
        public ScoreSubjectV3(
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>? scoreSubjectV3Variant1,
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>? scoreSubjectV3Variant2,
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>? scoreSubjectV3Variant3,
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>? scoreSubjectV3Variant4
            )
        {
            ScoreSubjectV3Variant1 = scoreSubjectV3Variant1;
            ScoreSubjectV3Variant2 = scoreSubjectV3Variant2;
            ScoreSubjectV3Variant3 = scoreSubjectV3Variant3;
            ScoreSubjectV3Variant4 = scoreSubjectV3Variant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScoreSubjectV3Variant4 as object ??
            ScoreSubjectV3Variant3 as object ??
            ScoreSubjectV3Variant2 as object ??
            ScoreSubjectV3Variant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScoreSubjectV3Variant1?.ToString() ??
            ScoreSubjectV3Variant2?.ToString() ??
            ScoreSubjectV3Variant3?.ToString() ??
            ScoreSubjectV3Variant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScoreSubjectV3Variant1 && !IsScoreSubjectV3Variant2 && !IsScoreSubjectV3Variant3 && !IsScoreSubjectV3Variant4 || !IsScoreSubjectV3Variant1 && IsScoreSubjectV3Variant2 && !IsScoreSubjectV3Variant3 && !IsScoreSubjectV3Variant4 || !IsScoreSubjectV3Variant1 && !IsScoreSubjectV3Variant2 && IsScoreSubjectV3Variant3 && !IsScoreSubjectV3Variant4 || !IsScoreSubjectV3Variant1 && !IsScoreSubjectV3Variant2 && !IsScoreSubjectV3Variant3 && IsScoreSubjectV3Variant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>?, TResult>? scoreSubjectV3Variant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>?, TResult>? scoreSubjectV3Variant2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>?, TResult>? scoreSubjectV3Variant3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>?, TResult>? scoreSubjectV3Variant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreSubjectV3Variant1 && scoreSubjectV3Variant1 != null)
            {
                return scoreSubjectV3Variant1(ScoreSubjectV3Variant1!);
            }
            else if (IsScoreSubjectV3Variant2 && scoreSubjectV3Variant2 != null)
            {
                return scoreSubjectV3Variant2(ScoreSubjectV3Variant2!);
            }
            else if (IsScoreSubjectV3Variant3 && scoreSubjectV3Variant3 != null)
            {
                return scoreSubjectV3Variant3(ScoreSubjectV3Variant3!);
            }
            else if (IsScoreSubjectV3Variant4 && scoreSubjectV3Variant4 != null)
            {
                return scoreSubjectV3Variant4(ScoreSubjectV3Variant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>?>? scoreSubjectV3Variant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>?>? scoreSubjectV3Variant2 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>?>? scoreSubjectV3Variant3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>?>? scoreSubjectV3Variant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreSubjectV3Variant1)
            {
                scoreSubjectV3Variant1?.Invoke(ScoreSubjectV3Variant1!);
            }
            else if (IsScoreSubjectV3Variant2)
            {
                scoreSubjectV3Variant2?.Invoke(ScoreSubjectV3Variant2!);
            }
            else if (IsScoreSubjectV3Variant3)
            {
                scoreSubjectV3Variant3?.Invoke(ScoreSubjectV3Variant3!);
            }
            else if (IsScoreSubjectV3Variant4)
            {
                scoreSubjectV3Variant4?.Invoke(ScoreSubjectV3Variant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>?>? scoreSubjectV3Variant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>?>? scoreSubjectV3Variant2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>?>? scoreSubjectV3Variant3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>?>? scoreSubjectV3Variant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreSubjectV3Variant1)
            {
                scoreSubjectV3Variant1?.Invoke(ScoreSubjectV3Variant1!);
            }
            else if (IsScoreSubjectV3Variant2)
            {
                scoreSubjectV3Variant2?.Invoke(ScoreSubjectV3Variant2!);
            }
            else if (IsScoreSubjectV3Variant3)
            {
                scoreSubjectV3Variant3?.Invoke(ScoreSubjectV3Variant3!);
            }
            else if (IsScoreSubjectV3Variant4)
            {
                scoreSubjectV3Variant4?.Invoke(ScoreSubjectV3Variant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScoreSubjectV3Variant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>),
                ScoreSubjectV3Variant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>),
                ScoreSubjectV3Variant3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>),
                ScoreSubjectV3Variant4,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>),
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
        public bool Equals(ScoreSubjectV3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant12, global::Langfuse.ScoreSubjectTraceV3>?>.Default.Equals(ScoreSubjectV3Variant1, other.ScoreSubjectV3Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant22, global::Langfuse.ScoreSubjectObservationV3>?>.Default.Equals(ScoreSubjectV3Variant2, other.ScoreSubjectV3Variant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant32, global::Langfuse.ScoreSubjectSessionV3>?>.Default.Equals(ScoreSubjectV3Variant3, other.ScoreSubjectV3Variant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3Variant42, global::Langfuse.ScoreSubjectExperimentV3>?>.Default.Equals(ScoreSubjectV3Variant4, other.ScoreSubjectV3Variant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ScoreSubjectV3 obj1, ScoreSubjectV3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScoreSubjectV3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ScoreSubjectV3 obj1, ScoreSubjectV3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScoreSubjectV3 o && Equals(o);
        }
    }
}
