using Blazor_ui;
using Blazor_ui.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(GlobalStatic.uriName) });
builder.Services.AddScoped<ProdutoService>();
builder.Services.AddScoped<PedidoService>();

await builder.Build().RunAsync();
