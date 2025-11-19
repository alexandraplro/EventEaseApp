using EventEaseApp;
using EventEaseApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddSingleton<RegistrationService>();
builder.Services.AddSingleton<EventService>();
builder.Services.AddSingleton<SessionService>();
builder.Logging.SetMinimumLevel(LogLevel.Debug);



await builder.Build().RunAsync();
