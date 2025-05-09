namespace Sports.Blazor.Model;

public sealed record SportLeagueSeason
{
    public string Id { get; init; }
    public string DisplayName { get; init; }
    public SportLeagueSeasonType Type { get; init; }
    public int Year { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public bool IsOffSeason { get; init; }
    public bool DatesAreInSeason { get; init; }
    public bool TypeIsOffSeason { get; init; }
}
