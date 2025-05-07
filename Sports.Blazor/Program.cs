namespace Sports.Blazor;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Sports.Blazor.Config;
using Sports.Blazor.Service;
using Sports.Blazor.Service.Interface;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder
            .Services
            .AddOptions()
            .Configure<ApiConfig>(apiConfig => builder.Configuration.GetSection("Api").Bind(apiConfig))
            .AddScoped<ISportLeagueService, SportLeagueService>()
            .AddScoped(sp => new HttpClient 
            { 
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            });

        await builder.Build().RunAsync();
    }
}
