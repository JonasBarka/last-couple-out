using LastCoupleOut;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using Infrastructure.Repository;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddRadzenComponents();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<IAttendeeRepository, AttendeeRepository>();

await builder.Build().RunAsync();
