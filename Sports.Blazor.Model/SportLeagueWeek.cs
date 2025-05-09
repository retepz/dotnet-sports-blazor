namespace Sports.Blazor.Model;

public sealed record SportLeagueWeek
{
    public int Number { get; init; }
    public DateTime? StartDate { get; init; }
    public DateTime? EndDate { get; init; }
    public string DisplayName { get; init; }
}
