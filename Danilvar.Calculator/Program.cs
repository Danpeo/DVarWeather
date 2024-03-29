using Danilvar.Calculator;
using Danilvar.Calculator.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("ServerApi")
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(builder.Configuration["ServerUrl"] ?? ""));

builder.Services.AddScoped<IWeatherService, WeatherService>();

await builder.Build().RunAsync();
