#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// A reference to the entity this score is attached to. Discriminated by "kind" — one of trace, observation, session, or experiment.
    /// </summary>
    public readonly partial struct ScoreSubject : global::System.IEquatable<ScoreSubject>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>? ScoreSubjectVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>? ScoreSubjectVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectVariant1))]
#endif
        public bool IsScoreSubjectVariant1 => ScoreSubjectVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScoreSubjectVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>? value)
        {
            value = ScoreSubjectVariant1;
            return IsScoreSubjectVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace> PickScoreSubjectVariant1() => IsScoreSubjectVariant1
            ? ScoreSubjectVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>? ScoreSubjectVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>? ScoreSubjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectVariant2))]
#endif
        public bool IsScoreSubjectVariant2 => ScoreSubjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScoreSubjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>? value)
        {
            value = ScoreSubjectVariant2;
            return IsScoreSubjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation> PickScoreSubjectVariant2() => IsScoreSubjectVariant2
            ? ScoreSubjectVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>? ScoreSubjectVariant3 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>? ScoreSubjectVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectVariant3))]
#endif
        public bool IsScoreSubjectVariant3 => ScoreSubjectVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScoreSubjectVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>? value)
        {
            value = ScoreSubjectVariant3;
            return IsScoreSubjectVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession> PickScoreSubjectVariant3() => IsScoreSubjectVariant3
            ? ScoreSubjectVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>? ScoreSubjectVariant4 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>? ScoreSubjectVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreSubjectVariant4))]
#endif
        public bool IsScoreSubjectVariant4 => ScoreSubjectVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScoreSubjectVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>? value)
        {
            value = ScoreSubjectVariant4;
            return IsScoreSubjectVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment> PickScoreSubjectVariant4() => IsScoreSubjectVariant4
            ? ScoreSubjectVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreSubjectVariant4' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreSubject(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace> value) => new ScoreSubject((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>?(ScoreSubject @this) => @this.ScoreSubjectVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ScoreSubject(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>? value)
        {
            ScoreSubjectVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScoreSubject FromScoreSubjectVariant1(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>? value) => new ScoreSubject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreSubject(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation> value) => new ScoreSubject((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>?(ScoreSubject @this) => @this.ScoreSubjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ScoreSubject(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>? value)
        {
            ScoreSubjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScoreSubject FromScoreSubjectVariant2(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>? value) => new ScoreSubject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreSubject(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession> value) => new ScoreSubject((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>?(ScoreSubject @this) => @this.ScoreSubjectVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ScoreSubject(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>? value)
        {
            ScoreSubjectVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScoreSubject FromScoreSubjectVariant3(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>? value) => new ScoreSubject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreSubject(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment> value) => new ScoreSubject((global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>?(ScoreSubject @this) => @this.ScoreSubjectVariant4;

        /// <summary>
        /// 
        /// </summary>
        public ScoreSubject(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>? value)
        {
            ScoreSubjectVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScoreSubject FromScoreSubjectVariant4(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>? value) => new ScoreSubject(value);

        /// <summary>
        /// 
        /// </summary>
        public ScoreSubject(
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>? scoreSubjectVariant1,
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>? scoreSubjectVariant2,
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>? scoreSubjectVariant3,
            global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>? scoreSubjectVariant4
            )
        {
            ScoreSubjectVariant1 = scoreSubjectVariant1;
            ScoreSubjectVariant2 = scoreSubjectVariant2;
            ScoreSubjectVariant3 = scoreSubjectVariant3;
            ScoreSubjectVariant4 = scoreSubjectVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScoreSubjectVariant4 as object ??
            ScoreSubjectVariant3 as object ??
            ScoreSubjectVariant2 as object ??
            ScoreSubjectVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScoreSubjectVariant1?.ToString() ??
            ScoreSubjectVariant2?.ToString() ??
            ScoreSubjectVariant3?.ToString() ??
            ScoreSubjectVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScoreSubjectVariant1 && !IsScoreSubjectVariant2 && !IsScoreSubjectVariant3 && !IsScoreSubjectVariant4 || !IsScoreSubjectVariant1 && IsScoreSubjectVariant2 && !IsScoreSubjectVariant3 && !IsScoreSubjectVariant4 || !IsScoreSubjectVariant1 && !IsScoreSubjectVariant2 && IsScoreSubjectVariant3 && !IsScoreSubjectVariant4 || !IsScoreSubjectVariant1 && !IsScoreSubjectVariant2 && !IsScoreSubjectVariant3 && IsScoreSubjectVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>?, TResult>? scoreSubjectVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>?, TResult>? scoreSubjectVariant2 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>?, TResult>? scoreSubjectVariant3 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>?, TResult>? scoreSubjectVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreSubjectVariant1 && scoreSubjectVariant1 != null)
            {
                return scoreSubjectVariant1(ScoreSubjectVariant1!);
            }
            else if (IsScoreSubjectVariant2 && scoreSubjectVariant2 != null)
            {
                return scoreSubjectVariant2(ScoreSubjectVariant2!);
            }
            else if (IsScoreSubjectVariant3 && scoreSubjectVariant3 != null)
            {
                return scoreSubjectVariant3(ScoreSubjectVariant3!);
            }
            else if (IsScoreSubjectVariant4 && scoreSubjectVariant4 != null)
            {
                return scoreSubjectVariant4(ScoreSubjectVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>?>? scoreSubjectVariant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>?>? scoreSubjectVariant2 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>?>? scoreSubjectVariant3 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>?>? scoreSubjectVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreSubjectVariant1)
            {
                scoreSubjectVariant1?.Invoke(ScoreSubjectVariant1!);
            }
            else if (IsScoreSubjectVariant2)
            {
                scoreSubjectVariant2?.Invoke(ScoreSubjectVariant2!);
            }
            else if (IsScoreSubjectVariant3)
            {
                scoreSubjectVariant3?.Invoke(ScoreSubjectVariant3!);
            }
            else if (IsScoreSubjectVariant4)
            {
                scoreSubjectVariant4?.Invoke(ScoreSubjectVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>?>? scoreSubjectVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>?>? scoreSubjectVariant2 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>?>? scoreSubjectVariant3 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>?>? scoreSubjectVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreSubjectVariant1)
            {
                scoreSubjectVariant1?.Invoke(ScoreSubjectVariant1!);
            }
            else if (IsScoreSubjectVariant2)
            {
                scoreSubjectVariant2?.Invoke(ScoreSubjectVariant2!);
            }
            else if (IsScoreSubjectVariant3)
            {
                scoreSubjectVariant3?.Invoke(ScoreSubjectVariant3!);
            }
            else if (IsScoreSubjectVariant4)
            {
                scoreSubjectVariant4?.Invoke(ScoreSubjectVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScoreSubjectVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>),
                ScoreSubjectVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>),
                ScoreSubjectVariant3,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>),
                ScoreSubjectVariant4,
                typeof(global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>),
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
        public bool Equals(ScoreSubject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant12, global::Langfuse.ScoreSubjectTrace>?>.Default.Equals(ScoreSubjectVariant1, other.ScoreSubjectVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant22, global::Langfuse.ScoreSubjectObservation>?>.Default.Equals(ScoreSubjectVariant2, other.ScoreSubjectVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant32, global::Langfuse.ScoreSubjectSession>?>.Default.Equals(ScoreSubjectVariant3, other.ScoreSubjectVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.ScoreSubjectVariant42, global::Langfuse.ScoreSubjectExperiment>?>.Default.Equals(ScoreSubjectVariant4, other.ScoreSubjectVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ScoreSubject obj1, ScoreSubject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScoreSubject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ScoreSubject obj1, ScoreSubject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScoreSubject o && Equals(o);
        }
    }
}
