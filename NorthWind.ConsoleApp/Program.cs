
using NorthWind.Entities.Interfaces;
using NorthWind.ConsoleApp.Services;
using NorthWind.Writers;
using Microsoft.Extensions.Hosting;

var Builder = Host

IUserActionWriter writer = new FileWriter();

AppLogger logger = new AppLogger(writer);
logger.WriteLog("Application started.");

ProductService Service=new ProductService(writer);
Service.Add("Demo", "Azucar refinada");
