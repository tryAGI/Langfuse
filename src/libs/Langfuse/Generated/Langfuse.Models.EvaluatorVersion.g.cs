#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EvaluatorVersion : global::System.IEquatable<EvaluatorVersion>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? LlmAsJudgeEvaluatorVersion { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? LlmAsJudgeEvaluatorVersion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LlmAsJudgeEvaluatorVersion))]
#endif
        public bool IsLlmAsJudgeEvaluatorVersion => LlmAsJudgeEvaluatorVersion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLlmAsJudgeEvaluatorVersion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? value)
        {
            value = LlmAsJudgeEvaluatorVersion;
            return IsLlmAsJudgeEvaluatorVersion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion> PickLlmAsJudgeEvaluatorVersion() => LlmAsJudgeEvaluatorVersion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LlmAsJudgeEvaluatorVersion' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? CodeEvaluatorVersion { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? CodeEvaluatorVersion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeEvaluatorVersion))]
#endif
        public bool IsCodeEvaluatorVersion => CodeEvaluatorVersion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeEvaluatorVersion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? value)
        {
            value = CodeEvaluatorVersion;
            return IsCodeEvaluatorVersion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion> PickCodeEvaluatorVersion() => CodeEvaluatorVersion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeEvaluatorVersion' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>? DecisionModelEvaluatorVersion { get; init; }
#else
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>? DecisionModelEvaluatorVersion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionModelEvaluatorVersion))]
#endif
        public bool IsDecisionModelEvaluatorVersion => DecisionModelEvaluatorVersion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionModelEvaluatorVersion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>? value)
        {
            value = DecisionModelEvaluatorVersion;
            return IsDecisionModelEvaluatorVersion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion> PickDecisionModelEvaluatorVersion() => DecisionModelEvaluatorVersion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionModelEvaluatorVersion' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluatorVersion(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion> value) => new EvaluatorVersion((global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>?(EvaluatorVersion @this) => @this.LlmAsJudgeEvaluatorVersion;

        /// <summary>
        ///
        /// </summary>
        public EvaluatorVersion(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? value)
        {
            LlmAsJudgeEvaluatorVersion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluatorVersion FromLlmAsJudgeEvaluatorVersion(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? value) => new EvaluatorVersion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluatorVersion(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion> value) => new EvaluatorVersion((global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>?(EvaluatorVersion @this) => @this.CodeEvaluatorVersion;

        /// <summary>
        ///
        /// </summary>
        public EvaluatorVersion(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? value)
        {
            CodeEvaluatorVersion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluatorVersion FromCodeEvaluatorVersion(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? value) => new EvaluatorVersion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EvaluatorVersion(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion> value) => new EvaluatorVersion((global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>?(EvaluatorVersion @this) => @this.DecisionModelEvaluatorVersion;

        /// <summary>
        ///
        /// </summary>
        public EvaluatorVersion(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>? value)
        {
            DecisionModelEvaluatorVersion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EvaluatorVersion FromDecisionModelEvaluatorVersion(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>? value) => new EvaluatorVersion(value);

        /// <summary>
        ///
        /// </summary>
        public EvaluatorVersion(
            global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>? llmAsJudgeEvaluatorVersion,
            global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>? codeEvaluatorVersion,
            global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>? decisionModelEvaluatorVersion
            )
        {
            LlmAsJudgeEvaluatorVersion = llmAsJudgeEvaluatorVersion;
            CodeEvaluatorVersion = codeEvaluatorVersion;
            DecisionModelEvaluatorVersion = decisionModelEvaluatorVersion;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DecisionModelEvaluatorVersion as object ??
            CodeEvaluatorVersion as object ??
            LlmAsJudgeEvaluatorVersion as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            LlmAsJudgeEvaluatorVersion?.ToString() ??
            CodeEvaluatorVersion?.ToString() ??
            DecisionModelEvaluatorVersion?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLlmAsJudgeEvaluatorVersion && !IsCodeEvaluatorVersion && !IsDecisionModelEvaluatorVersion || !IsLlmAsJudgeEvaluatorVersion && IsCodeEvaluatorVersion && !IsDecisionModelEvaluatorVersion || !IsLlmAsJudgeEvaluatorVersion && !IsCodeEvaluatorVersion && IsDecisionModelEvaluatorVersion;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>?, TResult>? llmAsJudgeEvaluatorVersion = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>?, TResult>? codeEvaluatorVersion = null,
            global::System.Func<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>?, TResult>? decisionModelEvaluatorVersion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LlmAsJudgeEvaluatorVersion is { } __value0 && llmAsJudgeEvaluatorVersion != null)
            {
                return llmAsJudgeEvaluatorVersion(__value0);
            }
            else if (CodeEvaluatorVersion is { } __value1 && codeEvaluatorVersion != null)
            {
                return codeEvaluatorVersion(__value1);
            }
            else if (DecisionModelEvaluatorVersion is { } __value2 && decisionModelEvaluatorVersion != null)
            {
                return decisionModelEvaluatorVersion(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>?>? llmAsJudgeEvaluatorVersion = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>?>? codeEvaluatorVersion = null,

            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>?>? decisionModelEvaluatorVersion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LlmAsJudgeEvaluatorVersion is { } __value0)
            {
                llmAsJudgeEvaluatorVersion?.Invoke(__value0);
            }
            else if (CodeEvaluatorVersion is { } __value1)
            {
                codeEvaluatorVersion?.Invoke(__value1);
            }
            else if (DecisionModelEvaluatorVersion is { } __value2)
            {
                decisionModelEvaluatorVersion?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>?>? llmAsJudgeEvaluatorVersion = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>?>? codeEvaluatorVersion = null,
            global::System.Action<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>?>? decisionModelEvaluatorVersion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LlmAsJudgeEvaluatorVersion is { } __value0)
            {
                llmAsJudgeEvaluatorVersion?.Invoke(__value0);
            }
            else if (CodeEvaluatorVersion is { } __value1)
            {
                codeEvaluatorVersion?.Invoke(__value1);
            }
            else if (DecisionModelEvaluatorVersion is { } __value2)
            {
                decisionModelEvaluatorVersion?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LlmAsJudgeEvaluatorVersion,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>),
                CodeEvaluatorVersion,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>),
                DecisionModelEvaluatorVersion,
                typeof(global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>),
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
        public bool Equals(EvaluatorVersion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionLlmAsJudgeEvaluatorVersion2, global::Langfuse.LlmAsJudgeEvaluatorVersion>?>.Default.Equals(LlmAsJudgeEvaluatorVersion, other.LlmAsJudgeEvaluatorVersion) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionCodeEvaluatorVersion2, global::Langfuse.CodeEvaluatorVersion>?>.Default.Equals(CodeEvaluatorVersion, other.CodeEvaluatorVersion) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.AllOf<global::Langfuse.EvaluatorVersionDecisionModelEvaluatorVersion2, global::Langfuse.DecisionModelEvaluatorVersion>?>.Default.Equals(DecisionModelEvaluatorVersion, other.DecisionModelEvaluatorVersion)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EvaluatorVersion obj1, EvaluatorVersion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvaluatorVersion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EvaluatorVersion obj1, EvaluatorVersion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvaluatorVersion o && Equals(o);
        }
    }
}
