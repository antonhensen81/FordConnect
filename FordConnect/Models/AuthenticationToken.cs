using Newtonsoft.Json;

namespace FordConnect.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class AuthenticationToken
{
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }

    [JsonProperty("scope")]
    public string Scope { get; set; }

    [JsonProperty("grant_id")]
    public string GrantId { get; set; }

    [JsonProperty("id_token")]
    public string IdToken { get; set; }

    [JsonProperty("token_type")]
    public string TokenType { get; set; }

    [JsonProperty("expires_in")]
    public int ExpiresIn { get; set; }
}

//
// internal class AuthenticationToken
// {
//     public string AccessToken { get; set; }
//     public string RefreshToken { get; set; }
//     public string Scope { get; set; }
//     public string GrantId { get; set; }
//     public string IdToken { get; set; }
//     public string TokenType { get; set; }
//     public int ExpiresIn { get; set; }
// }