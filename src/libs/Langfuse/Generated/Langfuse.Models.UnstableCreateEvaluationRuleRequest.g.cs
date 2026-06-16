#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Request body for creating an evaluation rule.<br/>
    /// Checklist for agents and SDK clients:<br/>
    /// - reference an existing evaluator family by `evaluator.name` and `evaluator.scope`<br/>
    /// - choose `target=observation` or `target=experiment`<br/>
    /// - if `target=experiment` and you want a dataset filter, call `GET /api/public/v2/datasets` first and use dataset `id` values in `filter[].value`<br/>
    /// - for `llm_as_judge`, fetch or inspect the evaluator first and provide a complete variable mapping for every evaluator variable<br/>
    /// - for `code`, do not send variables or mappings; Langfuse stores the fixed code runtime mapping automatically<br/>
    /// - optionally narrow execution with `filter`<br/>
    /// - set `enabled=true` only when you want live execution immediately
    /// </summary>
    public readonly partial struct UnstableCreateEvaluationRuleRequest : global::System.IEquatable<UnstableCreateEvaluationRuleRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest? UnstableCreateLlmAsJudgeEvaluationRuleRequest { get; init; }
#else
        public global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest? UnstableCreateLlmAsJudgeEvaluationRuleRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCreateLlmAsJudgeEvaluationRuleRequest))]
#endif
        public bool IsUnstableCreateLlmAsJudgeEvaluationRuleRequest => UnstableCreateLlmAsJudgeEvaluationRuleRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableCreateLlmAsJudgeEvaluationRuleRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest? value)
        {
            value = UnstableCreateLlmAsJudgeEvaluationRuleRequest;
            return IsUnstableCreateLlmAsJudgeEvaluationRuleRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest PickUnstableCreateLlmAsJudgeEvaluationRuleRequest() => IsUnstableCreateLlmAsJudgeEvaluationRuleRequest
            ? UnstableCreateLlmAsJudgeEvaluationRuleRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCreateLlmAsJudgeEvaluationRuleRequest' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.UnstableCreateCodeEvaluationRuleRequest? UnstableCreateCodeEvaluationRuleRequest { get; init; }
#else
        public global::Langfuse.UnstableCreateCodeEvaluationRuleRequest? UnstableCreateCodeEvaluationRuleRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableCreateCodeEvaluationRuleRequest))]
#endif
        public bool IsUnstableCreateCodeEvaluationRuleRequest => UnstableCreateCodeEvaluationRuleRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnstableCreateCodeEvaluationRuleRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.UnstableCreateCodeEvaluationRuleRequest? value)
        {
            value = UnstableCreateCodeEvaluationRuleRequest;
            return IsUnstableCreateCodeEvaluationRuleRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Langfuse.UnstableCreateCodeEvaluationRuleRequest PickUnstableCreateCodeEvaluationRuleRequest() => IsUnstableCreateCodeEvaluationRuleRequest
            ? UnstableCreateCodeEvaluationRuleRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableCreateCodeEvaluationRuleRequest' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableCreateEvaluationRuleRequest(global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest value) => new UnstableCreateEvaluationRuleRequest((global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest?(UnstableCreateEvaluationRuleRequest @this) => @this.UnstableCreateLlmAsJudgeEvaluationRuleRequest;

        /// <summary>
        /// 
        /// </summary>
        public UnstableCreateEvaluationRuleRequest(global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest? value)
        {
            UnstableCreateLlmAsJudgeEvaluationRuleRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstableCreateEvaluationRuleRequest FromUnstableCreateLlmAsJudgeEvaluationRuleRequest(global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest? value) => new UnstableCreateEvaluationRuleRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnstableCreateEvaluationRuleRequest(global::Langfuse.UnstableCreateCodeEvaluationRuleRequest value) => new UnstableCreateEvaluationRuleRequest((global::Langfuse.UnstableCreateCodeEvaluationRuleRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Langfuse.UnstableCreateCodeEvaluationRuleRequest?(UnstableCreateEvaluationRuleRequest @this) => @this.UnstableCreateCodeEvaluationRuleRequest;

        /// <summary>
        /// 
        /// </summary>
        public UnstableCreateEvaluationRuleRequest(global::Langfuse.UnstableCreateCodeEvaluationRuleRequest? value)
        {
            UnstableCreateCodeEvaluationRuleRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnstableCreateEvaluationRuleRequest FromUnstableCreateCodeEvaluationRuleRequest(global::Langfuse.UnstableCreateCodeEvaluationRuleRequest? value) => new UnstableCreateEvaluationRuleRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public UnstableCreateEvaluationRuleRequest(
            global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest? unstableCreateLlmAsJudgeEvaluationRuleRequest,
            global::Langfuse.UnstableCreateCodeEvaluationRuleRequest? unstableCreateCodeEvaluationRuleRequest
            )
        {
            UnstableCreateLlmAsJudgeEvaluationRuleRequest = unstableCreateLlmAsJudgeEvaluationRuleRequest;
            UnstableCreateCodeEvaluationRuleRequest = unstableCreateCodeEvaluationRuleRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnstableCreateCodeEvaluationRuleRequest as object ??
            UnstableCreateLlmAsJudgeEvaluationRuleRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UnstableCreateLlmAsJudgeEvaluationRuleRequest?.ToString() ??
            UnstableCreateCodeEvaluationRuleRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnstableCreateLlmAsJudgeEvaluationRuleRequest && !IsUnstableCreateCodeEvaluationRuleRequest || !IsUnstableCreateLlmAsJudgeEvaluationRuleRequest && IsUnstableCreateCodeEvaluationRuleRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest, TResult>? unstableCreateLlmAsJudgeEvaluationRuleRequest = null,
            global::System.Func<global::Langfuse.UnstableCreateCodeEvaluationRuleRequest, TResult>? unstableCreateCodeEvaluationRuleRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateLlmAsJudgeEvaluationRuleRequest && unstableCreateLlmAsJudgeEvaluationRuleRequest != null)
            {
                return unstableCreateLlmAsJudgeEvaluationRuleRequest(UnstableCreateLlmAsJudgeEvaluationRuleRequest!);
            }
            else if (IsUnstableCreateCodeEvaluationRuleRequest && unstableCreateCodeEvaluationRuleRequest != null)
            {
                return unstableCreateCodeEvaluationRuleRequest(UnstableCreateCodeEvaluationRuleRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest>? unstableCreateLlmAsJudgeEvaluationRuleRequest = null,

            global::System.Action<global::Langfuse.UnstableCreateCodeEvaluationRuleRequest>? unstableCreateCodeEvaluationRuleRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateLlmAsJudgeEvaluationRuleRequest)
            {
                unstableCreateLlmAsJudgeEvaluationRuleRequest?.Invoke(UnstableCreateLlmAsJudgeEvaluationRuleRequest!);
            }
            else if (IsUnstableCreateCodeEvaluationRuleRequest)
            {
                unstableCreateCodeEvaluationRuleRequest?.Invoke(UnstableCreateCodeEvaluationRuleRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest>? unstableCreateLlmAsJudgeEvaluationRuleRequest = null,
            global::System.Action<global::Langfuse.UnstableCreateCodeEvaluationRuleRequest>? unstableCreateCodeEvaluationRuleRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableCreateLlmAsJudgeEvaluationRuleRequest)
            {
                unstableCreateLlmAsJudgeEvaluationRuleRequest?.Invoke(UnstableCreateLlmAsJudgeEvaluationRuleRequest!);
            }
            else if (IsUnstableCreateCodeEvaluationRuleRequest)
            {
                unstableCreateCodeEvaluationRuleRequest?.Invoke(UnstableCreateCodeEvaluationRuleRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableCreateLlmAsJudgeEvaluationRuleRequest,
                typeof(global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest),
                UnstableCreateCodeEvaluationRuleRequest,
                typeof(global::Langfuse.UnstableCreateCodeEvaluationRuleRequest),
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
        public bool Equals(UnstableCreateEvaluationRuleRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.UnstableCreateLlmAsJudgeEvaluationRuleRequest?>.Default.Equals(UnstableCreateLlmAsJudgeEvaluationRuleRequest, other.UnstableCreateLlmAsJudgeEvaluationRuleRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.UnstableCreateCodeEvaluationRuleRequest?>.Default.Equals(UnstableCreateCodeEvaluationRuleRequest, other.UnstableCreateCodeEvaluationRuleRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnstableCreateEvaluationRuleRequest obj1, UnstableCreateEvaluationRuleRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnstableCreateEvaluationRuleRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnstableCreateEvaluationRuleRequest obj1, UnstableCreateEvaluationRuleRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnstableCreateEvaluationRuleRequest o && Equals(o);
        }
    }
}
