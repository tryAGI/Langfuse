#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Provide exactly one of content or sha256Hash for each path.
    /// </summary>
    public readonly partial struct SkillVersionFileCreateInput : global::System.IEquatable<SkillVersionFileCreateInput>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.SkillVersionFileInput? SkillVersionFileInput { get; init; }
#else
        public global::Langfuse.SkillVersionFileInput? SkillVersionFileInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkillVersionFileInput))]
#endif
        public bool IsSkillVersionFileInput => SkillVersionFileInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSkillVersionFileInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.SkillVersionFileInput? value)
        {
            value = SkillVersionFileInput;
            return IsSkillVersionFileInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileInput PickSkillVersionFileInput() => SkillVersionFileInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SkillVersionFileInput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.SkillVersionFileReference? SkillVersionFileReference { get; init; }
#else
        public global::Langfuse.SkillVersionFileReference? SkillVersionFileReference { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkillVersionFileReference))]
#endif
        public bool IsSkillVersionFileReference => SkillVersionFileReference != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSkillVersionFileReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.SkillVersionFileReference? value)
        {
            value = SkillVersionFileReference;
            return IsSkillVersionFileReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.SkillVersionFileReference PickSkillVersionFileReference() => SkillVersionFileReference is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SkillVersionFileReference' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SkillVersionFileCreateInput(global::Langfuse.SkillVersionFileInput value) => new SkillVersionFileCreateInput((global::Langfuse.SkillVersionFileInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.SkillVersionFileInput?(SkillVersionFileCreateInput @this) => @this.SkillVersionFileInput;

        /// <summary>
        ///
        /// </summary>
        public SkillVersionFileCreateInput(global::Langfuse.SkillVersionFileInput? value)
        {
            SkillVersionFileInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SkillVersionFileCreateInput FromSkillVersionFileInput(global::Langfuse.SkillVersionFileInput? value) => new SkillVersionFileCreateInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SkillVersionFileCreateInput(global::Langfuse.SkillVersionFileReference value) => new SkillVersionFileCreateInput((global::Langfuse.SkillVersionFileReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.SkillVersionFileReference?(SkillVersionFileCreateInput @this) => @this.SkillVersionFileReference;

        /// <summary>
        ///
        /// </summary>
        public SkillVersionFileCreateInput(global::Langfuse.SkillVersionFileReference? value)
        {
            SkillVersionFileReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SkillVersionFileCreateInput FromSkillVersionFileReference(global::Langfuse.SkillVersionFileReference? value) => new SkillVersionFileCreateInput(value);

        /// <summary>
        ///
        /// </summary>
        public SkillVersionFileCreateInput(
            global::Langfuse.SkillVersionFileInput? skillVersionFileInput,
            global::Langfuse.SkillVersionFileReference? skillVersionFileReference
            )
        {
            SkillVersionFileInput = skillVersionFileInput;
            SkillVersionFileReference = skillVersionFileReference;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SkillVersionFileReference as object ??
            SkillVersionFileInput as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SkillVersionFileInput?.ToString() ??
            SkillVersionFileReference?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSkillVersionFileInput && !IsSkillVersionFileReference || !IsSkillVersionFileInput && IsSkillVersionFileReference;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.SkillVersionFileInput, TResult>? skillVersionFileInput = null,
            global::System.Func<global::Langfuse.SkillVersionFileReference, TResult>? skillVersionFileReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SkillVersionFileInput is { } __value0 && skillVersionFileInput != null)
            {
                return skillVersionFileInput(__value0);
            }
            else if (SkillVersionFileReference is { } __value1 && skillVersionFileReference != null)
            {
                return skillVersionFileReference(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.SkillVersionFileInput>? skillVersionFileInput = null,

            global::System.Action<global::Langfuse.SkillVersionFileReference>? skillVersionFileReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SkillVersionFileInput is { } __value0)
            {
                skillVersionFileInput?.Invoke(__value0);
            }
            else if (SkillVersionFileReference is { } __value1)
            {
                skillVersionFileReference?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.SkillVersionFileInput>? skillVersionFileInput = null,
            global::System.Action<global::Langfuse.SkillVersionFileReference>? skillVersionFileReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SkillVersionFileInput is { } __value0)
            {
                skillVersionFileInput?.Invoke(__value0);
            }
            else if (SkillVersionFileReference is { } __value1)
            {
                skillVersionFileReference?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SkillVersionFileInput,
                typeof(global::Langfuse.SkillVersionFileInput),
                SkillVersionFileReference,
                typeof(global::Langfuse.SkillVersionFileReference),
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
        public bool Equals(SkillVersionFileCreateInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.SkillVersionFileInput?>.Default.Equals(SkillVersionFileInput, other.SkillVersionFileInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.SkillVersionFileReference?>.Default.Equals(SkillVersionFileReference, other.SkillVersionFileReference)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SkillVersionFileCreateInput obj1, SkillVersionFileCreateInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SkillVersionFileCreateInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SkillVersionFileCreateInput obj1, SkillVersionFileCreateInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SkillVersionFileCreateInput o && Equals(o);
        }
    }
}
