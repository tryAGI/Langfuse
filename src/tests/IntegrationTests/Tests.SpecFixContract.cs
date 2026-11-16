namespace Langfuse.IntegrationTests;

/// <summary>
/// What generate.sh arranges, checked without credentials.
///
/// Langfuse authenticates with HTTP Basic — a public key as the username and a secret key as the
/// password — which the upstream document does not describe on its own: generate.sh passes
/// `--security-scheme Http:Header:Basic`. Drop or change that flag and the generated client sends
/// the wrong thing while still compiling, and the first sign is a 401 at runtime.
///
/// Every other test here needs real keys and reports inconclusive without them, so this suite
/// printed `Skipped!` and exited 0 — which reads exactly like a passing run. These two touch no
/// network.
/// </summary>
[TestClass]
public class SpecFixContractTests
{
    [TestMethod]
    public void TheClientSendsBasicCredentialsTheSpecFixAsksFor()
    {
        using var client = new global::Langfuse.LangfuseClient("public-key", "secret-key");

        var authorization = client.Authorizations.SingleOrDefault(
            x => x.Type == "Http" && x.Location == "Header");

        Assert.IsNotNull(
            authorization,
            "Expected one Http credential in the Header, found: " +
            string.Join(", ", client.Authorizations.Select(x => $"{x.Type}/{x.Location}/{x.Name}")) +
            ". This comes from --security-scheme Http:Header:Basic in generate.sh; if a spec " +
            "refresh changed it, fix the flag rather than this test.");
        Assert.AreEqual("Basic", authorization.Name);

        // Basic is the one scheme where the value is not the key as given: the two halves are
        // joined and base64-encoded, so asserting the encoding is what catches a client that
        // started sending the raw pair or only the secret.
        Assert.AreEqual(
            global::System.Convert.ToBase64String(
                global::System.Text.Encoding.UTF8.GetBytes("public-key:secret-key")),
            authorization.Value);
    }

    [TestMethod]
    public void TheDefaultBaseUrlIsTheOneTheSpecDeclares()
    {
        Assert.AreEqual("https://cloud.langfuse.com/", global::Langfuse.LangfuseClient.DefaultBaseUrl);
    }
}
