namespace Sports.Blazor.Model;

public class SportCompetitor
{
    public string Name { get; init; }
    public string Location { get; init; }
    public string Logo { get; init; }
    public string Score { get; init; }
    public bool IsHome { get; init; }
    public bool HasPossession { get; init; }
    public string? Record { get; init; }
    public string? Color { get; init; }
}
