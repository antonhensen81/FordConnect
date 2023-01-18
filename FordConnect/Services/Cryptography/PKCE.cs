using System.Security.Cryptography;
using System.Text;

namespace FordConnect.Services.Cryptography;

internal class PKCE
{
    public static ChallengeAndVerifierModel Generate()
    {
        var rng = RandomNumberGenerator.Create();

        var bytes = new byte[32];
        rng.GetBytes(bytes);

        // It is recommended to use a URL-safe string as code_verifier.
        // See section 4 of RFC 7636 for more details.
        var codeVerifier = Convert.ToBase64String(bytes)
            .TrimEnd('=')
            .Replace('+', '-')
            .Replace('/', '_');

        using var sha256 = SHA256.Create();
        var challengeBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier));
        var codeChallenge = Convert.ToBase64String(challengeBytes)
            .TrimEnd('=')
            .Replace('+', '-')
            .Replace('/', '_');

        return new ChallengeAndVerifierModel(codeChallenge, codeVerifier);
    }
}