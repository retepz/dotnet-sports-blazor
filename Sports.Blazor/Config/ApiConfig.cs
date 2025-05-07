namespace Sports.Blazor.Config;

public sealed record ApiConfig
{
    public required string Url { get; init; }
}
