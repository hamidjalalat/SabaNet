using BlazorBootstrap;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NGSmart.WebBlazor.Ecare;
using NGSmart.WebBlazor.Ecare.DependencyInjections;
using NGSmart.WebBlazor.Ecare.Services;
using System.Reflection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.Services.RegisterServices();
builder.Services.AddBlazorBootstrap();

builder.Services.Scan(scan => scan
    .FromAssemblies(typeof(PostService).GetTypeInfo().Assembly)
        .AddClasses(classes => classes.InExactNamespaceOf<PostService>())
            .AsSelf()
            .WithTransientLifetime());

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
