namespace Langfuse.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LangfuseClient GetAuthenticatedClient()
    {
        var publicKey =
            Environment.GetEnvironmentVariable("LANGFUSE_PUBLIC_KEY") is { Length: > 0 } publicKeyValue
                ? publicKeyValue
                : throw new AssertInconclusiveException("LANGFUSE_PUBLIC_KEY environment variable is not found.");
        var secretKey =
            Environment.GetEnvironmentVariable("LANGFUSE_SECRET_KEY") is { Length: > 0 } secretKeyValue
                ? secretKeyValue
                : throw new AssertInconclusiveException("LANGFUSE_SECRET_KEY environment variable is not found.");

        var client = new LangfuseClient(
            username: publicKey,
            password: secretKey);

        return client;
    }
}
