namespace Sports.Blazor.Model;

public sealed record Sport
{
    public string Id { get; init; }

    public string DisplayName { get; init; }

    public string[]? Logos { get; init; }
}
