#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Provide exactly one of content or sha256Hash for each path.
    /// </summary>
    public readonly partial struct UnstableSkillVersionFileCreateInput : global::System.IEquatable<UnstableSkillVersionFileCreateInput>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.UnstableSkillVersionFileInput? UnstableSkillVersionFileInput { get; init; }
#else
        public global::Langfuse.UnstableSkillVersionFileInput? UnstableSkillVersionFileInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableSkillVersionFileInput))]
#endif
        public bool IsUnstableSkillVersionFileInput => UnstableSkillVersionFileInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableSkillVersionFileInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.UnstableSkillVersionFileInput? value)
        {
            value = UnstableSkillVersionFileInput;
            return IsUnstableSkillVersionFileInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileInput PickUnstableSkillVersionFileInput() => IsUnstableSkillVersionFileInput
            ? UnstableSkillVersionFileInput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableSkillVersionFileInput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.UnstableSkillVersionFileReference? UnstableSkillVersionFileReference { get; init; }
#else
        public global::Langfuse.UnstableSkillVersionFileReference? UnstableSkillVersionFileReference { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnstableSkillVersionFileReference))]
#endif
        public bool IsUnstableSkillVersionFileReference => UnstableSkillVersionFileReference != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnstableSkillVersionFileReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.UnstableSkillVersionFileReference? value)
        {
            value = UnstableSkillVersionFileReference;
            return IsUnstableSkillVersionFileReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.UnstableSkillVersionFileReference PickUnstableSkillVersionFileReference() => IsUnstableSkillVersionFileReference
            ? UnstableSkillVersionFileReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnstableSkillVersionFileReference' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableSkillVersionFileCreateInput(global::Langfuse.UnstableSkillVersionFileInput value) => new UnstableSkillVersionFileCreateInput((global::Langfuse.UnstableSkillVersionFileInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.UnstableSkillVersionFileInput?(UnstableSkillVersionFileCreateInput @this) => @this.UnstableSkillVersionFileInput;

        /// <summary>
        ///
        /// </summary>
        public UnstableSkillVersionFileCreateInput(global::Langfuse.UnstableSkillVersionFileInput? value)
        {
            UnstableSkillVersionFileInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableSkillVersionFileCreateInput FromUnstableSkillVersionFileInput(global::Langfuse.UnstableSkillVersionFileInput? value) => new UnstableSkillVersionFileCreateInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnstableSkillVersionFileCreateInput(global::Langfuse.UnstableSkillVersionFileReference value) => new UnstableSkillVersionFileCreateInput((global::Langfuse.UnstableSkillVersionFileReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.UnstableSkillVersionFileReference?(UnstableSkillVersionFileCreateInput @this) => @this.UnstableSkillVersionFileReference;

        /// <summary>
        ///
        /// </summary>
        public UnstableSkillVersionFileCreateInput(global::Langfuse.UnstableSkillVersionFileReference? value)
        {
            UnstableSkillVersionFileReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnstableSkillVersionFileCreateInput FromUnstableSkillVersionFileReference(global::Langfuse.UnstableSkillVersionFileReference? value) => new UnstableSkillVersionFileCreateInput(value);

        /// <summary>
        ///
        /// </summary>
        public UnstableSkillVersionFileCreateInput(
            global::Langfuse.UnstableSkillVersionFileInput? unstableSkillVersionFileInput,
            global::Langfuse.UnstableSkillVersionFileReference? unstableSkillVersionFileReference
            )
        {
            UnstableSkillVersionFileInput = unstableSkillVersionFileInput;
            UnstableSkillVersionFileReference = unstableSkillVersionFileReference;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UnstableSkillVersionFileReference as object ??
            UnstableSkillVersionFileInput as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UnstableSkillVersionFileInput?.ToString() ??
            UnstableSkillVersionFileReference?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnstableSkillVersionFileInput && !IsUnstableSkillVersionFileReference || !IsUnstableSkillVersionFileInput && IsUnstableSkillVersionFileReference;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.UnstableSkillVersionFileInput, TResult>? unstableSkillVersionFileInput = null,
            global::System.Func<global::Langfuse.UnstableSkillVersionFileReference, TResult>? unstableSkillVersionFileReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableSkillVersionFileInput && unstableSkillVersionFileInput != null)
            {
                return unstableSkillVersionFileInput(UnstableSkillVersionFileInput!);
            }
            else if (IsUnstableSkillVersionFileReference && unstableSkillVersionFileReference != null)
            {
                return unstableSkillVersionFileReference(UnstableSkillVersionFileReference!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.UnstableSkillVersionFileInput>? unstableSkillVersionFileInput = null,

            global::System.Action<global::Langfuse.UnstableSkillVersionFileReference>? unstableSkillVersionFileReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableSkillVersionFileInput)
            {
                unstableSkillVersionFileInput?.Invoke(UnstableSkillVersionFileInput!);
            }
            else if (IsUnstableSkillVersionFileReference)
            {
                unstableSkillVersionFileReference?.Invoke(UnstableSkillVersionFileReference!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.UnstableSkillVersionFileInput>? unstableSkillVersionFileInput = null,
            global::System.Action<global::Langfuse.UnstableSkillVersionFileReference>? unstableSkillVersionFileReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnstableSkillVersionFileInput)
            {
                unstableSkillVersionFileInput?.Invoke(UnstableSkillVersionFileInput!);
            }
            else if (IsUnstableSkillVersionFileReference)
            {
                unstableSkillVersionFileReference?.Invoke(UnstableSkillVersionFileReference!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnstableSkillVersionFileInput,
                typeof(global::Langfuse.UnstableSkillVersionFileInput),
                UnstableSkillVersionFileReference,
                typeof(global::Langfuse.UnstableSkillVersionFileReference),
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
        public bool Equals(UnstableSkillVersionFileCreateInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.UnstableSkillVersionFileInput?>.Default.Equals(UnstableSkillVersionFileInput, other.UnstableSkillVersionFileInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.UnstableSkillVersionFileReference?>.Default.Equals(UnstableSkillVersionFileReference, other.UnstableSkillVersionFileReference)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UnstableSkillVersionFileCreateInput obj1, UnstableSkillVersionFileCreateInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnstableSkillVersionFileCreateInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnstableSkillVersionFileCreateInput obj1, UnstableSkillVersionFileCreateInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnstableSkillVersionFileCreateInput o && Equals(o);
        }
    }
}
