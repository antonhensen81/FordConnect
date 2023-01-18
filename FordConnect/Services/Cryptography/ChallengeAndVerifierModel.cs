namespace FordConnect.Services.Cryptography
{
    public class ChallengeAndVerifierModel
    {
        public string CodeChallenge { get; }
        public string CodeVerifier { get; }

        public ChallengeAndVerifierModel(string codeChallenge, string codeVerifier)
        {
            CodeChallenge = codeChallenge;
            CodeVerifier = codeVerifier;
        }
    }

}
