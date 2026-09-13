
#nullable enable

namespace Langfuse
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Authorize using basic authentication.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>

        public void AuthorizeUsingBasic(
            string username,
            string password);
    }
}