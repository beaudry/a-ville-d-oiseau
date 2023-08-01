using A_villes_d_oiseau;
using A_villes_d_oiseau.Services;
using A_villes_d_oiseau.Villes;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<VilleService>();
builder.Services.AddScoped<FiligraneService>();

await builder.Build().RunAsync();
