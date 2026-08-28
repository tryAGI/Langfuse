
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateEvaluatorRequestCreateCodeEvaluatorRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvaluatorRequestCreateCodeEvaluatorRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvaluatorRequestCreateCodeEvaluatorRequestType value)
        {
            return value switch
            {
                CreateEvaluatorRequestCreateCodeEvaluatorRequestType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvaluatorRequestCreateCodeEvaluatorRequestType? ToEnum(string value)
        {
            return value switch
            {
                "code" => CreateEvaluatorRequestCreateCodeEvaluatorRequestType.Code,
                _ => null,
            };
        }
    }
}