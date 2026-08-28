#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Request body for creating an evaluator.<br/>
    /// If the same `name` already exists in your project, Langfuse creates the next version and returns it.<br/>
    /// Existing evaluation rules automatically use the latest evaluator version.<br/>
    /// If `type` is omitted, Langfuse defaults it to `llm_as_judge` for backwards compatibility.
    /// </summary>
    public readonly partial struct UnstableCreateEvaluatorRequest : global::System.IEquatable<UnstableCreateEvaluatorRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? UnstableCreateLlmAsJudgeEvaluatorRequest { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? UnstableCreateLlmAsJudgeEvaluatorRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCreateLlmAsJudgeEvaluatorRequest))]
#endif
        public bool IsUnstableCreateLlmAsJudgeEvaluatorRequest => UnstableCreateLlmAsJudgeEvaluatorRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableCreateLlmAsJudgeEvaluatorRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? value)
        {
            value = UnstableCreateLlmAsJudgeEvaluatorRequest;
            return IsUnstableCreateLlmAsJudgeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest> PickUnstableCreateLlmAsJudgeEvaluatorRequest() => IsUnstableCreateLlmAsJudgeEvaluatorRequest
            ? UnstableCreateLlmAsJudgeEvaluatorRequest!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCreateLlmAsJudgeEvaluatorRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? UnstableCreateCodeEvaluatorRequest { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? UnstableCreateCodeEvaluatorRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCreateCodeEvaluatorRequest))]
#endif
        public bool IsUnstableCreateCodeEvaluatorRequest => UnstableCreateCodeEvaluatorRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableCreateCodeEvaluatorRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? value)
        {
            value = UnstableCreateCodeEvaluatorRequest;
            return IsUnstableCreateCodeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest> PickUnstableCreateCodeEvaluatorRequest() => IsUnstableCreateCodeEvaluatorRequest
            ? UnstableCreateCodeEvaluatorRequest!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCreateCodeEvaluatorRequest' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableCreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest> value) => new UnstableCreateEvaluatorRequest((global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?(UnstableCreateEvaluatorRequest @this) => @this.UnstableCreateLlmAsJudgeEvaluatorRequest;

        /// <summary>
        ///
        /// </summary>
        public UnstableCreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? value)
        {
            UnstableCreateLlmAsJudgeEvaluatorRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableCreateEvaluatorRequest FromUnstableCreateLlmAsJudgeEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? value) => new UnstableCreateEvaluatorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableCreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest> value) => new UnstableCreateEvaluatorRequest((global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?(UnstableCreateEvaluatorRequest @this) => @this.UnstableCreateCodeEvaluatorRequest;

        /// <summary>
        ///
        /// </summary>
        public UnstableCreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? value)
        {
            UnstableCreateCodeEvaluatorRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableCreateEvaluatorRequest FromUnstableCreateCodeEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? value) => new UnstableCreateEvaluatorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public UnstableCreateEvaluatorRequest(
            global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>? unstableCreateLlmAsJudgeEvaluatorRequest,
            global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>? unstableCreateCodeEvaluatorRequest
            )
        {
            UnstableCreateLlmAsJudgeEvaluatorRequest = unstableCreateLlmAsJudgeEvaluatorRequest;
            UnstableCreateCodeEvaluatorRequest = unstableCreateCodeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UnstableCreateCodeEvaluatorRequest as object ??
            UnstableCreateLlmAsJudgeEvaluatorRequest as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UnstableCreateLlmAsJudgeEvaluatorRequest?.ToString() ??
            UnstableCreateCodeEvaluatorRequest?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnstableCreateLlmAsJudgeEvaluatorRequest && !IsUnstableCreateCodeEvaluatorRequest || !IsUnstableCreateLlmAsJudgeEvaluatorRequest && IsUnstableCreateCodeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?, TResult>? unstableCreateLlmAsJudgeEvaluatorRequest = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?, TResult>? unstableCreateCodeEvaluatorRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateLlmAsJudgeEvaluatorRequest && unstableCreateLlmAsJudgeEvaluatorRequest != null)
            {
                return unstableCreateLlmAsJudgeEvaluatorRequest(UnstableCreateLlmAsJudgeEvaluatorRequest!);
            }
            else if (IsUnstableCreateCodeEvaluatorRequest && unstableCreateCodeEvaluatorRequest != null)
            {
                return unstableCreateCodeEvaluatorRequest(UnstableCreateCodeEvaluatorRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?>? unstableCreateLlmAsJudgeEvaluatorRequest = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?>? unstableCreateCodeEvaluatorRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateLlmAsJudgeEvaluatorRequest)
            {
                unstableCreateLlmAsJudgeEvaluatorRequest?.Invoke(UnstableCreateLlmAsJudgeEvaluatorRequest!);
            }
            else if (IsUnstableCreateCodeEvaluatorRequest)
            {
                unstableCreateCodeEvaluatorRequest?.Invoke(UnstableCreateCodeEvaluatorRequest!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?>? unstableCreateLlmAsJudgeEvaluatorRequest = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?>? unstableCreateCodeEvaluatorRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateLlmAsJudgeEvaluatorRequest)
            {
                unstableCreateLlmAsJudgeEvaluatorRequest?.Invoke(UnstableCreateLlmAsJudgeEvaluatorRequest!);
            }
            else if (IsUnstableCreateCodeEvaluatorRequest)
            {
                unstableCreateCodeEvaluatorRequest?.Invoke(UnstableCreateCodeEvaluatorRequest!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableCreateLlmAsJudgeEvaluatorRequest,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>),
                UnstableCreateCodeEvaluatorRequest,
                typeof(global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>),
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
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.UnstableCreateLlmAsJudgeEvaluatorRequest>?>.Default.Equals(UnstableCreateLlmAsJudgeEvaluatorRequest, other.UnstableCreateLlmAsJudgeEvaluatorRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequest2, global::Langfuse.UnstableCreateCodeEvaluatorRequest>?>.Default.Equals(UnstableCreateCodeEvaluatorRequest, other.UnstableCreateCodeEvaluatorRequest)
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
