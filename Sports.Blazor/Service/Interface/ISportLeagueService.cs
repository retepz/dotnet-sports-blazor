namespace Sports.Blazor.Service.Interface;

using Sports.Blazor.Model;

public interface ISportLeagueService
{
    Task<IEnumerable<SportLeague>> Get(string sportType);
}
