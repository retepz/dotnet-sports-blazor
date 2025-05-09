namespace Sports.Blazor.Service.Interface;

public interface ILocalStorageService
{
    Task<string?> GetString(string key);
    Task<bool?> GetBool(string key);
    Task Set(string key, string value);
}
