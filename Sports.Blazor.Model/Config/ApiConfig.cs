namespace Sports.Blazor.Model.Config;

public sealed record ApiConfig
{
    public required string Url { get; init; }
}
