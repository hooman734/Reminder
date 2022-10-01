using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RWAPP.Interface.InMemory;
using RWAPP.UseCase.EventUseCase;
using RWAPP.UseCase.EventUseCase.Interface;
using RWAPP.UseCase.PluginInterface;
using RWAPP.WebApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add Services
builder.Services.AddSingleton<IRepository, Repository>();
builder.Services.AddTransient<IViewAllEventsByNameUseCase, ViewAllEventsByNameUseCase>();
builder.Services.AddTransient<IAddNewEventUseCase, AddNewEventUseCase>();
    
    
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
