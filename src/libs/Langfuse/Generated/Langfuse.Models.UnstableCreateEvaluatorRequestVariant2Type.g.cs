
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnstableCreateEvaluatorRequestVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableCreateEvaluatorRequestVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableCreateEvaluatorRequestVariant2Type value)
        {
            return value switch
            {
                UnstableCreateEvaluatorRequestVariant2Type.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableCreateEvaluatorRequestVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "code" => UnstableCreateEvaluatorRequestVariant2Type.Code,
                _ => null,
            };
        }
    }
}