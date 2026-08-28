#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Langfuse
{
    /// <summary>
    /// Connects one prompt variable to source data.
    /// </summary>
    public readonly partial struct PromptVariableMapping : global::System.IEquatable<PromptVariableMapping>
    {
        /// <summary>
        /// Connects one prompt variable to source data.<br/>
        /// `source` is `null` when the mapping is incomplete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.PromptVariableMappingRead? PromptVariableMappingRead { get; init; }
#else
        public global::Langfuse.PromptVariableMappingRead? PromptVariableMappingRead { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptVariableMappingRead))]
#endif
        public bool IsPromptVariableMappingRead => PromptVariableMappingRead != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPromptVariableMappingRead(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.PromptVariableMappingRead? value)
        {
            value = PromptVariableMappingRead;
            return IsPromptVariableMappingRead;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.PromptVariableMappingRead PickPromptVariableMappingRead() => IsPromptVariableMappingRead
            ? PromptVariableMappingRead!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PromptVariableMappingRead' but the value was {ToString()}.");

        /// <summary>
        /// **Deprecated:** Connects one prompt variable to data from a legacy trace or dataset evaluation rule.<br/>
        /// `langfuseObject` selects the object kind. `objectName` separately selects a named observation and is `null` for trace and dataset-item mappings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Langfuse.LegacyPromptVariableMapping? LegacyPromptVariableMapping { get; init; }
#else
        public global::Langfuse.LegacyPromptVariableMapping? LegacyPromptVariableMapping { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyPromptVariableMapping))]
#endif
        public bool IsLegacyPromptVariableMapping => LegacyPromptVariableMapping != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLegacyPromptVariableMapping(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Langfuse.LegacyPromptVariableMapping? value)
        {
            value = LegacyPromptVariableMapping;
            return IsLegacyPromptVariableMapping;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Langfuse.LegacyPromptVariableMapping PickLegacyPromptVariableMapping() => IsLegacyPromptVariableMapping
            ? LegacyPromptVariableMapping!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LegacyPromptVariableMapping' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptVariableMapping(global::Langfuse.PromptVariableMappingRead value) => new PromptVariableMapping((global::Langfuse.PromptVariableMappingRead?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.PromptVariableMappingRead?(PromptVariableMapping @this) => @this.PromptVariableMappingRead;

        /// <summary>
        ///
        /// </summary>
        public PromptVariableMapping(global::Langfuse.PromptVariableMappingRead? value)
        {
            PromptVariableMappingRead = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptVariableMapping FromPromptVariableMappingRead(global::Langfuse.PromptVariableMappingRead? value) => new PromptVariableMapping(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptVariableMapping(global::Langfuse.LegacyPromptVariableMapping value) => new PromptVariableMapping((global::Langfuse.LegacyPromptVariableMapping?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Langfuse.LegacyPromptVariableMapping?(PromptVariableMapping @this) => @this.LegacyPromptVariableMapping;

        /// <summary>
        ///
        /// </summary>
        public PromptVariableMapping(global::Langfuse.LegacyPromptVariableMapping? value)
        {
            LegacyPromptVariableMapping = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptVariableMapping FromLegacyPromptVariableMapping(global::Langfuse.LegacyPromptVariableMapping? value) => new PromptVariableMapping(value);

        /// <summary>
        ///
        /// </summary>
        public PromptVariableMapping(
            global::Langfuse.PromptVariableMappingRead? promptVariableMappingRead,
            global::Langfuse.LegacyPromptVariableMapping? legacyPromptVariableMapping
            )
        {
            PromptVariableMappingRead = promptVariableMappingRead;
            LegacyPromptVariableMapping = legacyPromptVariableMapping;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            LegacyPromptVariableMapping as object ??
            PromptVariableMappingRead as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PromptVariableMappingRead?.ToString() ??
            LegacyPromptVariableMapping?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPromptVariableMappingRead && !IsLegacyPromptVariableMapping || !IsPromptVariableMappingRead && IsLegacyPromptVariableMapping;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Langfuse.PromptVariableMappingRead, TResult>? promptVariableMappingRead = null,
            global::System.Func<global::Langfuse.LegacyPromptVariableMapping, TResult>? legacyPromptVariableMapping = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPromptVariableMappingRead && promptVariableMappingRead != null)
            {
                return promptVariableMappingRead(PromptVariableMappingRead!);
            }
            else if (IsLegacyPromptVariableMapping && legacyPromptVariableMapping != null)
            {
                return legacyPromptVariableMapping(LegacyPromptVariableMapping!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Langfuse.PromptVariableMappingRead>? promptVariableMappingRead = null,

            global::System.Action<global::Langfuse.LegacyPromptVariableMapping>? legacyPromptVariableMapping = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPromptVariableMappingRead)
            {
                promptVariableMappingRead?.Invoke(PromptVariableMappingRead!);
            }
            else if (IsLegacyPromptVariableMapping)
            {
                legacyPromptVariableMapping?.Invoke(LegacyPromptVariableMapping!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Langfuse.PromptVariableMappingRead>? promptVariableMappingRead = null,
            global::System.Action<global::Langfuse.LegacyPromptVariableMapping>? legacyPromptVariableMapping = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPromptVariableMappingRead)
            {
                promptVariableMappingRead?.Invoke(PromptVariableMappingRead!);
            }
            else if (IsLegacyPromptVariableMapping)
            {
                legacyPromptVariableMapping?.Invoke(LegacyPromptVariableMapping!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PromptVariableMappingRead,
                typeof(global::Langfuse.PromptVariableMappingRead),
                LegacyPromptVariableMapping,
                typeof(global::Langfuse.LegacyPromptVariableMapping),
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
        public bool Equals(PromptVariableMapping other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.PromptVariableMappingRead?>.Default.Equals(PromptVariableMappingRead, other.PromptVariableMappingRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Langfuse.LegacyPromptVariableMapping?>.Default.Equals(LegacyPromptVariableMapping, other.LegacyPromptVariableMapping)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PromptVariableMapping obj1, PromptVariableMapping obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptVariableMapping>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PromptVariableMapping obj1, PromptVariableMapping obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptVariableMapping o && Equals(o);
        }
    }
}
