namespace Sports.Blazor.Model;

public sealed record SportLeagueSeasonType
{
    public string Name { get; init; }
    public DateTime? StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}
