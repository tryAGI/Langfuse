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
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? ScoreSubjectTraceV3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? ScoreSubjectTraceV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectTraceV3))]
#endif
        public bool IsScoreSubjectTraceV3 => ScoreSubjectTraceV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreSubjectTraceV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? value)
        {
            value = ScoreSubjectTraceV3;
            return IsScoreSubjectTraceV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3> PickScoreSubjectTraceV3() => IsScoreSubjectTraceV3
            ? ScoreSubjectTraceV3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectTraceV3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? ScoreSubjectObservationV3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? ScoreSubjectObservationV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectObservationV3))]
#endif
        public bool IsScoreSubjectObservationV3 => ScoreSubjectObservationV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreSubjectObservationV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? value)
        {
            value = ScoreSubjectObservationV3;
            return IsScoreSubjectObservationV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3> PickScoreSubjectObservationV3() => IsScoreSubjectObservationV3
            ? ScoreSubjectObservationV3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectObservationV3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? ScoreSubjectSessionV3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? ScoreSubjectSessionV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectSessionV3))]
#endif
        public bool IsScoreSubjectSessionV3 => ScoreSubjectSessionV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreSubjectSessionV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? value)
        {
            value = ScoreSubjectSessionV3;
            return IsScoreSubjectSessionV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3> PickScoreSubjectSessionV3() => IsScoreSubjectSessionV3
            ? ScoreSubjectSessionV3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectSessionV3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? ScoreSubjectExperimentV3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? ScoreSubjectExperimentV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectExperimentV3))]
#endif
        public bool IsScoreSubjectExperimentV3 => ScoreSubjectExperimentV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreSubjectExperimentV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? value)
        {
            value = ScoreSubjectExperimentV3;
            return IsScoreSubjectExperimentV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3> PickScoreSubjectExperimentV3() => IsScoreSubjectExperimentV3
            ? ScoreSubjectExperimentV3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectExperimentV3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3> value) => new ScoreSubjectV3((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>?(ScoreSubjectV3 @this) => @this.ScoreSubjectTraceV3;

        /// <summary>
        ///
        /// </summary>
        public ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? value)
        {
            ScoreSubjectTraceV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreSubjectV3 FromScoreSubjectTraceV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? value) => new ScoreSubjectV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3> value) => new ScoreSubjectV3((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>?(ScoreSubjectV3 @this) => @this.ScoreSubjectObservationV3;

        /// <summary>
        ///
        /// </summary>
        public ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? value)
        {
            ScoreSubjectObservationV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreSubjectV3 FromScoreSubjectObservationV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? value) => new ScoreSubjectV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3> value) => new ScoreSubjectV3((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>?(ScoreSubjectV3 @this) => @this.ScoreSubjectSessionV3;

        /// <summary>
        ///
        /// </summary>
        public ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? value)
        {
            ScoreSubjectSessionV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreSubjectV3 FromScoreSubjectSessionV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? value) => new ScoreSubjectV3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3> value) => new ScoreSubjectV3((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>?(ScoreSubjectV3 @this) => @this.ScoreSubjectExperimentV3;

        /// <summary>
        ///
        /// </summary>
        public ScoreSubjectV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? value)
        {
            ScoreSubjectExperimentV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreSubjectV3 FromScoreSubjectExperimentV3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? value) => new ScoreSubjectV3(value);

        /// <summary>
        ///
        /// </summary>
        public ScoreSubjectV3(
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>? scoreSubjectTraceV3,
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>? scoreSubjectObservationV3,
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>? scoreSubjectSessionV3,
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>? scoreSubjectExperimentV3
            )
        {
            ScoreSubjectTraceV3 = scoreSubjectTraceV3;
            ScoreSubjectObservationV3 = scoreSubjectObservationV3;
            ScoreSubjectSessionV3 = scoreSubjectSessionV3;
            ScoreSubjectExperimentV3 = scoreSubjectExperimentV3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ScoreSubjectExperimentV3 as object ??
            ScoreSubjectSessionV3 as object ??
            ScoreSubjectObservationV3 as object ??
            ScoreSubjectTraceV3 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ScoreSubjectTraceV3?.ToString() ??
            ScoreSubjectObservationV3?.ToString() ??
            ScoreSubjectSessionV3?.ToString() ??
            ScoreSubjectExperimentV3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsScoreSubjectTraceV3 && !IsScoreSubjectObservationV3 && !IsScoreSubjectSessionV3 && !IsScoreSubjectExperimentV3 || !IsScoreSubjectTraceV3 && IsScoreSubjectObservationV3 && !IsScoreSubjectSessionV3 && !IsScoreSubjectExperimentV3 || !IsScoreSubjectTraceV3 && !IsScoreSubjectObservationV3 && IsScoreSubjectSessionV3 && !IsScoreSubjectExperimentV3 || !IsScoreSubjectTraceV3 && !IsScoreSubjectObservationV3 && !IsScoreSubjectSessionV3 && IsScoreSubjectExperimentV3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>?, TResult>? scoreSubjectTraceV3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>?, TResult>? scoreSubjectObservationV3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>?, TResult>? scoreSubjectSessionV3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>?, TResult>? scoreSubjectExperimentV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreSubjectTraceV3 && scoreSubjectTraceV3 != null)
            {
                return scoreSubjectTraceV3(ScoreSubjectTraceV3!);
            }
            else if (IsScoreSubjectObservationV3 && scoreSubjectObservationV3 != null)
            {
                return scoreSubjectObservationV3(ScoreSubjectObservationV3!);
            }
            else if (IsScoreSubjectSessionV3 && scoreSubjectSessionV3 != null)
            {
                return scoreSubjectSessionV3(ScoreSubjectSessionV3!);
            }
            else if (IsScoreSubjectExperimentV3 && scoreSubjectExperimentV3 != null)
            {
                return scoreSubjectExperimentV3(ScoreSubjectExperimentV3!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>?>? scoreSubjectTraceV3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>?>? scoreSubjectObservationV3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>?>? scoreSubjectSessionV3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>?>? scoreSubjectExperimentV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreSubjectTraceV3)
            {
                scoreSubjectTraceV3?.Invoke(ScoreSubjectTraceV3!);
            }
            else if (IsScoreSubjectObservationV3)
            {
                scoreSubjectObservationV3?.Invoke(ScoreSubjectObservationV3!);
            }
            else if (IsScoreSubjectSessionV3)
            {
                scoreSubjectSessionV3?.Invoke(ScoreSubjectSessionV3!);
            }
            else if (IsScoreSubjectExperimentV3)
            {
                scoreSubjectExperimentV3?.Invoke(ScoreSubjectExperimentV3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>?>? scoreSubjectTraceV3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>?>? scoreSubjectObservationV3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>?>? scoreSubjectSessionV3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>?>? scoreSubjectExperimentV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreSubjectTraceV3)
            {
                scoreSubjectTraceV3?.Invoke(ScoreSubjectTraceV3!);
            }
            else if (IsScoreSubjectObservationV3)
            {
                scoreSubjectObservationV3?.Invoke(ScoreSubjectObservationV3!);
            }
            else if (IsScoreSubjectSessionV3)
            {
                scoreSubjectSessionV3?.Invoke(ScoreSubjectSessionV3!);
            }
            else if (IsScoreSubjectExperimentV3)
            {
                scoreSubjectExperimentV3?.Invoke(ScoreSubjectExperimentV3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScoreSubjectTraceV3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>),
                ScoreSubjectObservationV3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>),
                ScoreSubjectSessionV3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>),
                ScoreSubjectExperimentV3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>),
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
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectTraceV32, global::Langfuse.ScoreSubjectTraceV3>?>.Default.Equals(ScoreSubjectTraceV3, other.ScoreSubjectTraceV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectObservationV32, global::Langfuse.ScoreSubjectObservationV3>?>.Default.Equals(ScoreSubjectObservationV3, other.ScoreSubjectObservationV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectSessionV32, global::Langfuse.ScoreSubjectSessionV3>?>.Default.Equals(ScoreSubjectSessionV3, other.ScoreSubjectSessionV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectV3ScoreSubjectExperimentV32, global::Langfuse.ScoreSubjectExperimentV3>?>.Default.Equals(ScoreSubjectExperimentV3, other.ScoreSubjectExperimentV3)
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
