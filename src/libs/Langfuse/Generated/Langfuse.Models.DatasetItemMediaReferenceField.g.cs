
#nullable enable

namespace Langfuse
{
    /// <summary>
    ///
    /// </summary>
    public enum DatasetItemMediaReferenceField
    {
        /// <summary>
        ///
        /// </summary>
        ExpectedOutput,
        /// <summary>
        ///
        /// </summary>
        Input,
        /// <summary>
        ///
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetItemMediaReferenceFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetItemMediaReferenceField value)
        {
            return value switch
            {
                DatasetItemMediaReferenceField.ExpectedOutput => "expectedOutput",
                DatasetItemMediaReferenceField.Input => "input",
                DatasetItemMediaReferenceField.Metadata => "metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetItemMediaReferenceField? ToEnum(string value)
        {
            return value switch
            {
                "expectedOutput" => DatasetItemMediaReferenceField.ExpectedOutput,
                "input" => DatasetItemMediaReferenceField.Input,
                "metadata" => DatasetItemMediaReferenceField.Metadata,
                _ => null,
            };
        }
    }
}