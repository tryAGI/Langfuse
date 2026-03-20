
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// 
    /// </summary>
    public enum MembershipRole
    {
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MembershipRole value)
        {
            return value switch
            {
                MembershipRole.Owner => "OWNER",
                MembershipRole.Admin => "ADMIN",
                MembershipRole.Member => "MEMBER",
                MembershipRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "OWNER" => MembershipRole.Owner,
                "ADMIN" => MembershipRole.Admin,
                "MEMBER" => MembershipRole.Member,
                "VIEWER" => MembershipRole.Viewer,
                _ => null,
            };
        }
    }
}