
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequestType value)
        {
            return value switch
            {
                UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequestType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequestType? ToEnum(string value)
        {
            return value switch
            {
                "code" => UnstableCreateEvaluatorRequestUnstableCreateCodeEvaluatorRequestType.Code,
                _ => null,
            };
        }
    }
}