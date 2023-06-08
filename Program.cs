using FagestKeyGenerator.WebAPP;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System;
using FagestKeyGenerator.WebAPP.Services;
using Microsoft.Extensions.Hosting;
using FagestKeyGenerator.WebAPP.Configuration;
using DevExpress.Blazor;
using FagestKeyGenerator.WebAPP.Services.Implementation;
using FagestKeyGenerator.WebAPP.Services.Interfaces.Login;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

var services = builder.Services;
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

services.AddOptions();
services.AddAuthorizationCore();
services.AddScoped<CustomStateProvider>();
services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<CustomStateProvider>());
services.AddScoped<IAuthService, AuthService>();
services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);
await builder.Build().RunAsync();



