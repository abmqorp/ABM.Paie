using ABM.Paie.Formation;
using ABM.Paie.Formation.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IUriProvider, UriProvider>();
builder.Services.AddSingleton<INewsService, NewsService>();
builder.Services.Configure<Common.Tools.Tips.Options>(_ => { });
builder.Services.AddScoped<Common.Tools.Tips.Service>();

var culture = new CultureInfo("fr-FR");
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

await builder.Build().RunAsync();
