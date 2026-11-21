
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// How Langfuse authenticates to the bucket.<br/>
    /// - `ACCESS_KEYS`: stored access key ID and secret access key.<br/>
    /// - `ROLE_ARN`: Langfuse assumes an IAM role in your AWS account (Amazon S3 only). Langfuse's cross-account role (`crossAccountRoleArn`) assumes your role with the integration's `externalId`, using a session limited to writing under the configured prefix. Requires an Enterprise plan and a deployment that configures a cross-account role; `crossAccountRoleArn` is not null when both apply.
    /// </summary>
    public enum BlobStorageIntegrationAuthType
    {
        /// <summary>
        /// stored access key ID and secret access key.
        /// </summary>
        AccessKeys,
        /// <summary>
        /// Langfuse assumes an IAM role in your AWS account (Amazon S3 only). Langfuse's cross-account role (`crossAccountRoleArn`) assumes your role with the integration's `externalId`, using a session limited to writing under the configured prefix. Requires an Enterprise plan and a deployment that configures a cross-account role; `crossAccountRoleArn` is not null when both apply.
        /// </summary>
        RoleArn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageIntegrationAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageIntegrationAuthType value)
        {
            return value switch
            {
                BlobStorageIntegrationAuthType.AccessKeys => "ACCESS_KEYS",
                BlobStorageIntegrationAuthType.RoleArn => "ROLE_ARN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageIntegrationAuthType? ToEnum(string value)
        {
            return value switch
            {
                "ACCESS_KEYS" => BlobStorageIntegrationAuthType.AccessKeys,
                "ROLE_ARN" => BlobStorageIntegrationAuthType.RoleArn,
                _ => null,
            };
        }
    }
}