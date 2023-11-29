using BlazorServerApp1.Client.Pages;
using BlazorServerApp1.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<CounterService>();

await builder.Build().RunAsync();
