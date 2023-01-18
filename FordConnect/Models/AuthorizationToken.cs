namespace FordConnect.Models;

internal class AuthorizationToken
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public string FordConsumerId { get; set; }
    public int ExpiresIn { get; set; }
    public int RefreshExpiresIn { get; set; }
}