namespace Sports.Blazor.Model;

public sealed record SportLeague
{
    public string? Id { get; init; }

    public LeagueType LeagueType { get; init; }

    public string? ShortName { get; init; }

    public string? DisplayName { get; init; }

    public string? Name { get; init; }

    public string? Abbreviation { get; init; }

    public string[]? Logos { get; init; }
}
