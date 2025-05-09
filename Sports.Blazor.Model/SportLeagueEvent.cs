namespace Sports.Blazor.Model;

public class SportLeagueEvent
{
    public string? Id { get; init; }
    public SportCompetitor FirstTeam { get; init; }
    public SportCompetitor SecondTeam { get; init; }
    public DateTime? GameTime { get; init; }
    public DateTime? GameTimeLocal => GameTime!.Value.ToLocalTime();
    public bool IsFinished { get; init; }
    public bool IsInFuture { get; init; }
    public bool IsLive { get; init; }
    public string? StatusType { get; init; }
    public string? DownDistance { get; init; }
    public string[]? BroadcastStations { get; init; }
}
