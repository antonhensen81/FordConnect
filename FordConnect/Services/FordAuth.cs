using FordConnect.Helpers;
using FordConnect.Models;
using FordConnect.Services.Cryptography;
using HtmlAgilityPack;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Web;

namespace FordConnect.Services;

internal class FordAuth
{
    private string baseUrl = "https://sso.ci.ford.com";
    public static RestClient client;
    string clientId = "9fb503e0-715b-47e8-adfd-ad4b7770f73b";
    private Regions.Region region;

    public FordAuth(Regions.Region region)
    {
        this.region = region;
        client = new RestClient(baseUrl);
    }

    public AuthorizationToken? GetAccessTokenFromCredentials(string username, string password)
    {
        var pkce = PKCE.Generate();
        var (code, grantId) = AttemptLogin(pkce.CodeChallenge, username, password);

        var response = Authenticate(code, grantId, pkce);
        if (response.Content != null)
        {
            return GetAuthorizationToken(response.Content);
        }
        return null;
    }

    private RestResponse Authenticate(string code, string grantId, ChallengeAndVerifierModel pkce)
    {
        var request = new RestRequest("oidc/endpoint/default/token");

        request.AddQueryParameter("client_id", clientId);
        request.AddQueryParameter("grant_type", "authorization_code");
        request.AddQueryParameter("code", code);
        request.AddQueryParameter("redirect_uri", "fordapp://userauthorized");
        request.AddQueryParameter("grant_id", grantId);
        request.AddQueryParameter("code_verifier", pkce.CodeVerifier);

        AddDefaultHeaders(request);
        request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

        var response = client.Execute(request, Method.Post);
        return response;
    }

    private AuthorizationToken? GetAuthorizationToken(string content)
    {
        var token = JsonConvert.DeserializeObject<AuthenticationToken>(content);

        var newClient = new RestClient("https://api.mps.ford.com");
        var newRequest = new RestRequest("api/token/v2/cat-with-ci-access-token", Method.Post);
        AddDefaultHeaders(newRequest);
        newRequest.AddHeader("Content-Type", "application/json");
        newRequest.AddHeader("Application-Id", Regions.GetRegionApplicationIdentifier(region));

        newRequest.AddJsonBody(new { ciToken = token.AccessToken });
        var newResponse = newClient.Execute(newRequest);
        if (newResponse.StatusCode == HttpStatusCode.OK && newResponse.Content != null)
        {
            var result = JsonConvert.DeserializeObject<AuthorizationToken>(newResponse.Content);
            return result;
        }

        throw new Exception("Failed to authorize");
    }

    private (string code, string grantId) AttemptLogin(string codeChallenge, string username, string password)
    {
        var authUrl = GetAuthUrl(codeChallenge);
        var request = new RestRequest(authUrl, Method.Post);
        request.AddQueryParameter("operation", "verify");
        request.AddQueryParameter("login-form-type", "pwd");
        request.AddQueryParameter("username", username);
        request.AddQueryParameter("password", password);

        request.AddHeader("maxRedirects", 0);
        request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
        AddDefaultHeaders(request);

        var response = client.Execute(request);
        if (response.StatusCode == HttpStatusCode.Found)
        {
            var redirectUrl = response.Headers?.First(x => x.Name == "Location").Value?.ToString();
            if (!string.IsNullOrEmpty(redirectUrl))
            {
                var myUri = new Uri(redirectUrl);
                var code = HttpUtility.ParseQueryString(myUri.Query).Get("code");
                var grantId = HttpUtility.ParseQueryString(myUri.Query).Get("grant_id");
                if (!string.IsNullOrEmpty(code) && !string.IsNullOrEmpty(grantId))
                {
                    return (code, grantId);
                }
            }
        }

        throw new Exception("Failed to login");
    }

    private string GetAuthUrl(string codeChallenge)
    {
        var request = new RestRequest($"v1.0/endpoint/default/authorize");
        request.AddQueryParameter("redirect_uri", "fordapp://userauthorized");
        request.AddQueryParameter("response_type", "code");
        request.AddQueryParameter("scope", "openid");
        request.AddQueryParameter("max_age", "3600");
        request.AddQueryParameter("client_id", clientId);
        request.AddQueryParameter("code_challenge", codeChallenge + "=");
        request.AddQueryParameter("code_challenge_method", "S256");

        AddDefaultHeaders(request);
        var response = client.Execute(request);

        var doc = new HtmlDocument();
        doc.LoadHtml(response.Content);
        var loginUrlContainerDiv = doc.DocumentNode.SelectSingleNode("//div[@class='ibm-ci-data-container']");
        var loginUrl = loginUrlContainerDiv.Attributes.FirstOrDefault(x => x.Name == "data-ibm-login-url")?.Value;
        if (loginUrl == null)
        {
            throw new Exception("Failed to get authentication URL");
        }
        return loginUrl;
    }

    private static void AddDefaultHeaders(RestRequest request)
    {
        request.AddHeader("Accept", "*/*");
        request.AddHeader("User-Agent", "FordPass/24 CFNetwork/1399 Darwin/22.1.0");
        request.AddHeader("Accept-Encoding", "gzip, deflate, br");
    }
}