#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Metadata-only update or complete flattened definition replacement. At least one field must be provided.
    /// </summary>
    public readonly partial struct UpdateEvaluatorRequest : global::System.IEquatable<UpdateEvaluatorRequest>
    {
        /// <summary>
        /// Metadata-only update. At least one field must be provided.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.UpdateEvaluatorMetadataRequest? UpdateEvaluatorMetadataRequest { get; init; }
#else
        public global::Langfuse.UpdateEvaluatorMetadataRequest? UpdateEvaluatorMetadataRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateEvaluatorMetadataRequest))]
#endif
        public bool IsUpdateEvaluatorMetadataRequest => UpdateEvaluatorMetadataRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateEvaluatorMetadataRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.UpdateEvaluatorMetadataRequest? value)
        {
            value = UpdateEvaluatorMetadataRequest;
            return IsUpdateEvaluatorMetadataRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateEvaluatorMetadataRequest PickUpdateEvaluatorMetadataRequest() => IsUpdateEvaluatorMetadataRequest
            ? UpdateEvaluatorMetadataRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateEvaluatorMetadataRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? UpdateLlmAsJudgeEvaluatorRequest { get; init; }
#else
        public global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? UpdateLlmAsJudgeEvaluatorRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateLlmAsJudgeEvaluatorRequest))]
#endif
        public bool IsUpdateLlmAsJudgeEvaluatorRequest => UpdateLlmAsJudgeEvaluatorRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateLlmAsJudgeEvaluatorRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? value)
        {
            value = UpdateLlmAsJudgeEvaluatorRequest;
            return IsUpdateLlmAsJudgeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest PickUpdateLlmAsJudgeEvaluatorRequest() => IsUpdateLlmAsJudgeEvaluatorRequest
            ? UpdateLlmAsJudgeEvaluatorRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateLlmAsJudgeEvaluatorRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.UpdateCodeEvaluatorRequest? UpdateCodeEvaluatorRequest { get; init; }
#else
        public global::Langfuse.UpdateCodeEvaluatorRequest? UpdateCodeEvaluatorRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateCodeEvaluatorRequest))]
#endif
        public bool IsUpdateCodeEvaluatorRequest => UpdateCodeEvaluatorRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateCodeEvaluatorRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.UpdateCodeEvaluatorRequest? value)
        {
            value = UpdateCodeEvaluatorRequest;
            return IsUpdateCodeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UpdateCodeEvaluatorRequest PickUpdateCodeEvaluatorRequest() => IsUpdateCodeEvaluatorRequest
            ? UpdateCodeEvaluatorRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateCodeEvaluatorRequest' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateEvaluatorRequest(global::Langfuse.UpdateEvaluatorMetadataRequest value) => new UpdateEvaluatorRequest((global::Langfuse.UpdateEvaluatorMetadataRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.UpdateEvaluatorMetadataRequest?(UpdateEvaluatorRequest @this) => @this.UpdateEvaluatorMetadataRequest;

        /// <summary>
        ///
        /// </summary>
        public UpdateEvaluatorRequest(global::Langfuse.UpdateEvaluatorMetadataRequest? value)
        {
            UpdateEvaluatorMetadataRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateEvaluatorRequest FromUpdateEvaluatorMetadataRequest(global::Langfuse.UpdateEvaluatorMetadataRequest? value) => new UpdateEvaluatorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateEvaluatorRequest(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest value) => new UpdateEvaluatorRequest((global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest?(UpdateEvaluatorRequest @this) => @this.UpdateLlmAsJudgeEvaluatorRequest;

        /// <summary>
        ///
        /// </summary>
        public UpdateEvaluatorRequest(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? value)
        {
            UpdateLlmAsJudgeEvaluatorRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateEvaluatorRequest FromUpdateLlmAsJudgeEvaluatorRequest(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? value) => new UpdateEvaluatorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateEvaluatorRequest(global::Langfuse.UpdateCodeEvaluatorRequest value) => new UpdateEvaluatorRequest((global::Langfuse.UpdateCodeEvaluatorRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.UpdateCodeEvaluatorRequest?(UpdateEvaluatorRequest @this) => @this.UpdateCodeEvaluatorRequest;

        /// <summary>
        ///
        /// </summary>
        public UpdateEvaluatorRequest(global::Langfuse.UpdateCodeEvaluatorRequest? value)
        {
            UpdateCodeEvaluatorRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateEvaluatorRequest FromUpdateCodeEvaluatorRequest(global::Langfuse.UpdateCodeEvaluatorRequest? value) => new UpdateEvaluatorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateEvaluatorRequest(
            global::Langfuse.UpdateEvaluatorMetadataRequest? updateEvaluatorMetadataRequest,
            global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest? updateLlmAsJudgeEvaluatorRequest,
            global::Langfuse.UpdateCodeEvaluatorRequest? updateCodeEvaluatorRequest
            )
        {
            UpdateEvaluatorMetadataRequest = updateEvaluatorMetadataRequest;
            UpdateLlmAsJudgeEvaluatorRequest = updateLlmAsJudgeEvaluatorRequest;
            UpdateCodeEvaluatorRequest = updateCodeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UpdateCodeEvaluatorRequest as object ??
            UpdateLlmAsJudgeEvaluatorRequest as object ??
            UpdateEvaluatorMetadataRequest as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UpdateEvaluatorMetadataRequest?.ToString() ??
            UpdateLlmAsJudgeEvaluatorRequest?.ToString() ??
            UpdateCodeEvaluatorRequest?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUpdateEvaluatorMetadataRequest && !IsUpdateLlmAsJudgeEvaluatorRequest && !IsUpdateCodeEvaluatorRequest || !IsUpdateEvaluatorMetadataRequest && IsUpdateLlmAsJudgeEvaluatorRequest && !IsUpdateCodeEvaluatorRequest || !IsUpdateEvaluatorMetadataRequest && !IsUpdateLlmAsJudgeEvaluatorRequest && IsUpdateCodeEvaluatorRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.UpdateEvaluatorMetadataRequest, TResult>? updateEvaluatorMetadataRequest = null,
            global::System.Func<global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest, TResult>? updateLlmAsJudgeEvaluatorRequest = null,
            global::System.Func<global::Langfuse.UpdateCodeEvaluatorRequest, TResult>? updateCodeEvaluatorRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateEvaluatorMetadataRequest && updateEvaluatorMetadataRequest != null)
            {
                return updateEvaluatorMetadataRequest(UpdateEvaluatorMetadataRequest!);
            }
            else if (IsUpdateLlmAsJudgeEvaluatorRequest && updateLlmAsJudgeEvaluatorRequest != null)
            {
                return updateLlmAsJudgeEvaluatorRequest(UpdateLlmAsJudgeEvaluatorRequest!);
            }
            else if (IsUpdateCodeEvaluatorRequest && updateCodeEvaluatorRequest != null)
            {
                return updateCodeEvaluatorRequest(UpdateCodeEvaluatorRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.UpdateEvaluatorMetadataRequest>? updateEvaluatorMetadataRequest = null,

            global::System.Action<global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest>? updateLlmAsJudgeEvaluatorRequest = null,

            global::System.Action<global::Langfuse.UpdateCodeEvaluatorRequest>? updateCodeEvaluatorRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateEvaluatorMetadataRequest)
            {
                updateEvaluatorMetadataRequest?.Invoke(UpdateEvaluatorMetadataRequest!);
            }
            else if (IsUpdateLlmAsJudgeEvaluatorRequest)
            {
                updateLlmAsJudgeEvaluatorRequest?.Invoke(UpdateLlmAsJudgeEvaluatorRequest!);
            }
            else if (IsUpdateCodeEvaluatorRequest)
            {
                updateCodeEvaluatorRequest?.Invoke(UpdateCodeEvaluatorRequest!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.UpdateEvaluatorMetadataRequest>? updateEvaluatorMetadataRequest = null,
            global::System.Action<global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest>? updateLlmAsJudgeEvaluatorRequest = null,
            global::System.Action<global::Langfuse.UpdateCodeEvaluatorRequest>? updateCodeEvaluatorRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateEvaluatorMetadataRequest)
            {
                updateEvaluatorMetadataRequest?.Invoke(UpdateEvaluatorMetadataRequest!);
            }
            else if (IsUpdateLlmAsJudgeEvaluatorRequest)
            {
                updateLlmAsJudgeEvaluatorRequest?.Invoke(UpdateLlmAsJudgeEvaluatorRequest!);
            }
            else if (IsUpdateCodeEvaluatorRequest)
            {
                updateCodeEvaluatorRequest?.Invoke(UpdateCodeEvaluatorRequest!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UpdateEvaluatorMetadataRequest,
                typeof(global::Langfuse.UpdateEvaluatorMetadataRequest),
                UpdateLlmAsJudgeEvaluatorRequest,
                typeof(global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest),
                UpdateCodeEvaluatorRequest,
                typeof(global::Langfuse.UpdateCodeEvaluatorRequest),
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
        public bool Equals(UpdateEvaluatorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.UpdateEvaluatorMetadataRequest?>.Default.Equals(UpdateEvaluatorMetadataRequest, other.UpdateEvaluatorMetadataRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.UpdateLlmAsJudgeEvaluatorRequest?>.Default.Equals(UpdateLlmAsJudgeEvaluatorRequest, other.UpdateLlmAsJudgeEvaluatorRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.UpdateCodeEvaluatorRequest?>.Default.Equals(UpdateCodeEvaluatorRequest, other.UpdateCodeEvaluatorRequest)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateEvaluatorRequest obj1, UpdateEvaluatorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateEvaluatorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateEvaluatorRequest obj1, UpdateEvaluatorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateEvaluatorRequest o && Equals(o);
        }
    }
}
