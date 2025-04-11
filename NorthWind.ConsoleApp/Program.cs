
using NorthWind.Entities.Interfaces;
using NorthWind.ConsoleApp.Services;
using NorthWind.Writers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddNorthWindService();


using IHost AppHost = Builder.Build();

IAppLogger logger = AppHost.Services.GetRequiredService<IAppLogger>();
logger.WriteLog("Application started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar refinada");
