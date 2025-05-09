namespace Sports.Blazor.Service;

using Microsoft.JSInterop;
using Sports.Blazor.Service.Interface;
using System.Threading.Tasks;

public sealed class LocalStorageService(IJSRuntime jsRuntime)
    : ILocalStorageService
{
    public async Task<string?> GetString(string key)
    {
        return await jsRuntime.InvokeAsync<string>($"window.localStorage.getItem", key);
    }

    public async Task<bool?> GetBool(string key)
    {
        var asString = await GetString(key);
        if (string.IsNullOrEmpty(asString))
        {
            return null;
        }

        return bool.Parse(asString);
    }
    public async Task Set(string key, string value)
    {
        await jsRuntime.InvokeAsync<string>($"window.localStorage.setItem", key, value);
    }
}
