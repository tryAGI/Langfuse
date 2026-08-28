#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Initial evaluator definition with metadata and definition fields at the same level. The returned evaluator starts at version `1`.
    /// </summary>
    public readonly partial struct CreateEvaluatorRequest : global::System.IEquatable<CreateEvaluatorRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? CreateLlmAsJudgeEvaluatorRequest { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? CreateLlmAsJudgeEvaluatorRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateLlmAsJudgeEvaluatorRequest))]
#endif
        public bool IsCreateLlmAsJudgeEvaluatorRequest => CreateLlmAsJudgeEvaluatorRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateLlmAsJudgeEvaluatorRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? value)
        {
            value = CreateLlmAsJudgeEvaluatorRequest;
            return IsCreateLlmAsJudgeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest> PickCreateLlmAsJudgeEvaluatorRequest() => IsCreateLlmAsJudgeEvaluatorRequest
            ? CreateLlmAsJudgeEvaluatorRequest!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateLlmAsJudgeEvaluatorRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? CreateCodeEvaluatorRequest { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? CreateCodeEvaluatorRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateCodeEvaluatorRequest))]
#endif
        public bool IsCreateCodeEvaluatorRequest => CreateCodeEvaluatorRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateCodeEvaluatorRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? value)
        {
            value = CreateCodeEvaluatorRequest;
            return IsCreateCodeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest> PickCreateCodeEvaluatorRequest() => IsCreateCodeEvaluatorRequest
            ? CreateCodeEvaluatorRequest!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateCodeEvaluatorRequest' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest> value) => new CreateEvaluatorRequest((global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>?(CreateEvaluatorRequest @this) => @this.CreateLlmAsJudgeEvaluatorRequest;

        /// <summary>
        ///
        /// </summary>
        public CreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? value)
        {
            CreateLlmAsJudgeEvaluatorRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateEvaluatorRequest FromCreateLlmAsJudgeEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? value) => new CreateEvaluatorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest> value) => new CreateEvaluatorRequest((global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>?(CreateEvaluatorRequest @this) => @this.CreateCodeEvaluatorRequest;

        /// <summary>
        ///
        /// </summary>
        public CreateEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? value)
        {
            CreateCodeEvaluatorRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateEvaluatorRequest FromCreateCodeEvaluatorRequest(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? value) => new CreateEvaluatorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateEvaluatorRequest(
            global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>? createLlmAsJudgeEvaluatorRequest,
            global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>? createCodeEvaluatorRequest
            )
        {
            CreateLlmAsJudgeEvaluatorRequest = createLlmAsJudgeEvaluatorRequest;
            CreateCodeEvaluatorRequest = createCodeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateCodeEvaluatorRequest as object ??
            CreateLlmAsJudgeEvaluatorRequest as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CreateLlmAsJudgeEvaluatorRequest?.ToString() ??
            CreateCodeEvaluatorRequest?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreateLlmAsJudgeEvaluatorRequest && !IsCreateCodeEvaluatorRequest || !IsCreateLlmAsJudgeEvaluatorRequest && IsCreateCodeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>?, TResult>? createLlmAsJudgeEvaluatorRequest = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>?, TResult>? createCodeEvaluatorRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateLlmAsJudgeEvaluatorRequest && createLlmAsJudgeEvaluatorRequest != null)
            {
                return createLlmAsJudgeEvaluatorRequest(CreateLlmAsJudgeEvaluatorRequest!);
            }
            else if (IsCreateCodeEvaluatorRequest && createCodeEvaluatorRequest != null)
            {
                return createCodeEvaluatorRequest(CreateCodeEvaluatorRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>?>? createLlmAsJudgeEvaluatorRequest = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>?>? createCodeEvaluatorRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateLlmAsJudgeEvaluatorRequest)
            {
                createLlmAsJudgeEvaluatorRequest?.Invoke(CreateLlmAsJudgeEvaluatorRequest!);
            }
            else if (IsCreateCodeEvaluatorRequest)
            {
                createCodeEvaluatorRequest?.Invoke(CreateCodeEvaluatorRequest!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>?>? createLlmAsJudgeEvaluatorRequest = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>?>? createCodeEvaluatorRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateLlmAsJudgeEvaluatorRequest)
            {
                createLlmAsJudgeEvaluatorRequest?.Invoke(CreateLlmAsJudgeEvaluatorRequest!);
            }
            else if (IsCreateCodeEvaluatorRequest)
            {
                createCodeEvaluatorRequest?.Invoke(CreateCodeEvaluatorRequest!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateLlmAsJudgeEvaluatorRequest,
                typeof(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>),
                CreateCodeEvaluatorRequest,
                typeof(global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>),
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
        public bool Equals(CreateEvaluatorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateLlmAsJudgeEvaluatorRequest2, global::Langfuse.CreateLlmAsJudgeEvaluatorRequest>?>.Default.Equals(CreateLlmAsJudgeEvaluatorRequest, other.CreateLlmAsJudgeEvaluatorRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.CreateEvaluatorRequestCreateCodeEvaluatorRequest2, global::Langfuse.CreateCodeEvaluatorRequest>?>.Default.Equals(CreateCodeEvaluatorRequest, other.CreateCodeEvaluatorRequest)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateEvaluatorRequest obj1, CreateEvaluatorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEvaluatorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateEvaluatorRequest obj1, CreateEvaluatorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEvaluatorRequest o && Equals(o);
        }
    }
}
