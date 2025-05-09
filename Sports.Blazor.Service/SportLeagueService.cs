namespace Sports.Blazor.Service;

using Microsoft.Extensions.Options;
using Sports.Blazor.Model;
using Sports.Blazor.Model.Config;
using Sports.Blazor.Model.Response;
using Sports.Blazor.Service.Interface;
using System.Net.Http.Json;
using System.Text.Json;

public sealed class SportLeagueService(IOptions<ApiConfig> apiConfigOptions)
    : ISportLeagueService
{
    private readonly ApiConfig _apiConfig = apiConfigOptions.Value;

    public async Task<IEnumerable<SportLeague>> Get(string sportType) 
    {
        using var client = new HttpClient();
        var url = $"{_apiConfig.Url}/api/sports/{sportType}/leagues";
        var result = await client.GetAsync(url);
        var serializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        var leagueResponse = await result.Content.ReadFromJsonAsync<GetSportLeaguesResponse>();
        return leagueResponse!
            .Leagues
            .Where(league => !string.IsNullOrEmpty(league.DisplayName) && league.LeagueType != LeagueType.None);
    }

    public async Task<SportLeagueWeek?> GetWeek(string leagueType)
    {
        using var client = new HttpClient();
        var url = $"{_apiConfig.Url}/api/leagues/{leagueType}/season/currentweek";
        var result = await client.GetAsync(url);
        if(result.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return null;
        }

        var serializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        return await result.Content.ReadFromJsonAsync<SportLeagueWeek>();
    }

    public async Task<SportLeagueEvent[]?> GetWeekEvents(string leagueType)
    {
        using var client = new HttpClient();
        var url = $"{_apiConfig.Url}/api/leagues/{leagueType}/season/currentweek/events";
        var result = await client.GetAsync(url);
        if (result.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return null;
        }

        var serializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        return await result.Content.ReadFromJsonAsync<SportLeagueEvent[]>();
    }
}
