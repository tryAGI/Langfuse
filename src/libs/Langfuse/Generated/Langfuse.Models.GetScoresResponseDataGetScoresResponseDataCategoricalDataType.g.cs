
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum GetScoresResponseDataGetScoresResponseDataCategoricalDataType
    {
        /// <summary>
        ///
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetScoresResponseDataGetScoresResponseDataCategoricalDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScoresResponseDataGetScoresResponseDataCategoricalDataType value)
        {
            return value switch
            {
                GetScoresResponseDataGetScoresResponseDataCategoricalDataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScoresResponseDataGetScoresResponseDataCategoricalDataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => GetScoresResponseDataGetScoresResponseDataCategoricalDataType.Categorical,
                _ => null,
            };
        }
    }
}