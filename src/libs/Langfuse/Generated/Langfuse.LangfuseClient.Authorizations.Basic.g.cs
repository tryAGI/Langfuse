
#nullable enable

namespace Langfuse
{
    public sealed partial class LangfuseClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingBasic(
            string username,
            string password)
        {
            username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            password = password ?? throw new global::System.ArgumentNullException(nameof(password));

            Authorizations.Clear();
            Authorizations.Add(new global::Langfuse.EndPointAuthorization
            {
                Type = "Http",
                Location = "Header",
                Name = "Basic",
                Value = global::System.Convert.ToBase64String(
                    global::System.Text.Encoding.UTF8.GetBytes($"{username}:{password}")),
            });
        }
    }
}