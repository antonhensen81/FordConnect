using FordConnect.Helpers;
using FordConnect.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace FordConnect.Services;

internal class Vehicle
{
    private readonly string vin;
    private readonly string username;
    private readonly string password;
    private string? accessToken;
    private readonly Regions.Region region;
    private readonly string baseUrl = "https://usapi.cv.ford.com";

    public Vehicle(string vin, string username, string password, Regions.Region region)
    {
        this.vin = vin;
        this.username = username;
        this.password = password;
        this.region = region;
    }

    public void Initialize()
    {
        var auth = new FordAuth(region);
        var token = auth.GetAccessTokenFromCredentials(username, password);
        if (token == null)
        {
            throw new Exception("Sign in failed");
        }
        accessToken = token.AccessToken;
    }

    public CarStatus GetStatus()
    {
        return ExecuteRequest<CarStatus>(new RestRequest($"api/vehicles/v5/{vin}/status"));
    }

    public CommandResponse Start()
    {
        return ExecuteRequest<CommandResponse>(new RestRequest($"api/vehicles/v5/{vin}/engine/start", Method.Put));
    }

    public CommandResponse Stop()
    {
        return ExecuteRequest<CommandResponse>(new RestRequest($"api/vehicles/v5/{vin}/engine/start", Method.Delete));
    }

    public CommandResponse Lock()
    {
        return ExecuteRequest<CommandResponse>(new RestRequest($"api/vehicles/v5/{vin}/doors/lock", Method.Put));
    }

    public CommandResponse Unlock()
    {
        return ExecuteRequest<CommandResponse>(new RestRequest($"api/vehicles/v5/{vin}/doors/lock", Method.Delete));
    }

    private T ExecuteRequest<T>(RestRequest request)
    {
        var client = new RestClient(baseUrl);
        AddDefaultHeaders(request);
        var response = client.Execute(request);

        if (response.StatusCode == HttpStatusCode.OK && response.Content != null)
        {
            return Deserialize<T>(response.Content);
        }

        throw new Exception($"Failed to execute request: {request}"); // not tested. No idea what it outputs
    }

    private void AddDefaultHeaders(RestRequest request)
    {
        if (accessToken == null)
        {
            throw new Exception("Not initialized. Token not set");
        }
        request.AddHeader("auth-token", accessToken);
        request.AddHeader("Accept", "*/*");
        request.AddHeader("Accept-Language", "en-US");
        request.AddHeader("User-Agent", "FordPass/24 CFNetwork/1399 Darwin/22.1.0");
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        request.AddHeader("Application-Id", Regions.GetRegionApplicationIdentifier(region));
        request.AddHeader("locale", "en-US");
        request.AddHeader("countryCode", Regions.GetRegionCountryCode(region));
    }

    private static T Deserialize<T>(string content)
    {
        var deserialized = JsonConvert.DeserializeObject<T>(content);
        if (deserialized != null)
        {
            return deserialized;
        }

        throw new Exception("Failed to deserialize status response");
    }
}