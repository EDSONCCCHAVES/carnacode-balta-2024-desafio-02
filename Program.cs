using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Imc.Services; // Certifique-se de incluir o namespace correto para o seu serviço
using Imc; // Seu namespace principal

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registro do serviço HttpClient
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Registro do seu serviço HistoricoIMCService
builder.Services.AddSingleton<HistoricoIMCService>();

await builder.Build().RunAsync();
