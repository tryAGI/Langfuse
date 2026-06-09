#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Request body for creating an evaluator.<br/>
    /// If the same `name` already exists in your project, Langfuse creates the next version and returns it.<br/>
    /// Existing evaluation rules in the same project are then moved to that new latest version automatically.<br/>
    /// If `type` is omitted, Langfuse defaults it to `llm_as_judge` for backwards compatibility.
    /// </summary>
    public readonly partial struct UnstableCreateEvaluatorRequest : global::System.IEquatable<UnstableCreateEvaluatorRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? UnstableCreateEvaluatorRequestVariant1 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? UnstableCreateEvaluatorRequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCreateEvaluatorRequestVariant1))]
#endif
        public bool IsUnstableCreateEvaluatorRequestVariant1 => UnstableCreateEvaluatorRequestVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableCreateEvaluatorRequestVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? value)
        {
            value = UnstableCreateEvaluatorRequestVariant1;
            return IsUnstableCreateEvaluatorRequestVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest> PickUnstableCreateEvaluatorRequestVariant1() => IsUnstableCreateEvaluatorRequestVariant1
            ? UnstableCreateEvaluatorRequestVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCreateEvaluatorRequestVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? UnstableCreateEvaluatorRequestVariant2 { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? UnstableCreateEvaluatorRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCreateEvaluatorRequestVariant2))]
#endif
        public bool IsUnstableCreateEvaluatorRequestVariant2 => UnstableCreateEvaluatorRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableCreateEvaluatorRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? value)
        {
            value = UnstableCreateEvaluatorRequestVariant2;
            return IsUnstableCreateEvaluatorRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest> PickUnstableCreateEvaluatorRequestVariant2() => IsUnstableCreateEvaluatorRequestVariant2
            ? UnstableCreateEvaluatorRequestVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCreateEvaluatorRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableCreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest> value) => new UnstableCreateEvaluatorRequest((global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?(UnstableCreateEvaluatorRequest @this) => @this.UnstableCreateEvaluatorRequestVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UnstableCreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? value)
        {
            UnstableCreateEvaluatorRequestVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstableCreateEvaluatorRequest FromUnstableCreateEvaluatorRequestVariant1(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? value) => new UnstableCreateEvaluatorRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableCreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest> value) => new UnstableCreateEvaluatorRequest((global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?(UnstableCreateEvaluatorRequest @this) => @this.UnstableCreateEvaluatorRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnstableCreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? value)
        {
            UnstableCreateEvaluatorRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstableCreateEvaluatorRequest FromUnstableCreateEvaluatorRequestVariant2(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? value) => new UnstableCreateEvaluatorRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public UnstableCreateEvaluatorRequest(
            global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? unstableCreateEvaluatorRequestVariant1,
            global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? unstableCreateEvaluatorRequestVariant2
            )
        {
            UnstableCreateEvaluatorRequestVariant1 = unstableCreateEvaluatorRequestVariant1;
            UnstableCreateEvaluatorRequestVariant2 = unstableCreateEvaluatorRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnstableCreateEvaluatorRequestVariant2 as object ??
            UnstableCreateEvaluatorRequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnstableCreateEvaluatorRequestVariant1?.ToString() ??
            UnstableCreateEvaluatorRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnstableCreateEvaluatorRequestVariant1 && !IsUnstableCreateEvaluatorRequestVariant2 || !IsUnstableCreateEvaluatorRequestVariant1 && IsUnstableCreateEvaluatorRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?, TResult>? unstableCreateEvaluatorRequestVariant1 = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?, TResult>? unstableCreateEvaluatorRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateEvaluatorRequestVariant1 && unstableCreateEvaluatorRequestVariant1 != null)
            {
                return unstableCreateEvaluatorRequestVariant1(UnstableCreateEvaluatorRequestVariant1!);
            }
            else if (IsUnstableCreateEvaluatorRequestVariant2 && unstableCreateEvaluatorRequestVariant2 != null)
            {
                return unstableCreateEvaluatorRequestVariant2(UnstableCreateEvaluatorRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?>? unstableCreateEvaluatorRequestVariant1 = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?>? unstableCreateEvaluatorRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateEvaluatorRequestVariant1)
            {
                unstableCreateEvaluatorRequestVariant1?.Invoke(UnstableCreateEvaluatorRequestVariant1!);
            }
            else if (IsUnstableCreateEvaluatorRequestVariant2)
            {
                unstableCreateEvaluatorRequestVariant2?.Invoke(UnstableCreateEvaluatorRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?>? unstableCreateEvaluatorRequestVariant1 = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?>? unstableCreateEvaluatorRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateEvaluatorRequestVariant1)
            {
                unstableCreateEvaluatorRequestVariant1?.Invoke(UnstableCreateEvaluatorRequestVariant1!);
            }
            else if (IsUnstableCreateEvaluatorRequestVariant2)
            {
                unstableCreateEvaluatorRequestVariant2?.Invoke(UnstableCreateEvaluatorRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableCreateEvaluatorRequestVariant1,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>),
                UnstableCreateEvaluatorRequestVariant2,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>),
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
        public bool Equals(UnstableCreateEvaluatorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant12, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?>.Default.Equals(UnstableCreateEvaluatorRequestVariant1, other.UnstableCreateEvaluatorRequestVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestVariant22, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?>.Default.Equals(UnstableCreateEvaluatorRequestVariant2, other.UnstableCreateEvaluatorRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnstableCreateEvaluatorRequest obj1, UnstableCreateEvaluatorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnstableCreateEvaluatorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnstableCreateEvaluatorRequest obj1, UnstableCreateEvaluatorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnstableCreateEvaluatorRequest o && Equals(o);
        }
    }
}
