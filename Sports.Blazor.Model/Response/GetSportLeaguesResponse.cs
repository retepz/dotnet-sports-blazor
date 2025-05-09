namespace Sports.Blazor.Model.Response;
public sealed record GetSportLeaguesResponse
{
    public required SportLeague[] Leagues { get; init; }
}
