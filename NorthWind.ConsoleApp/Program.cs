
using NorthWind.Entities.Interfaces;
using NorthWind.ConsoleApp.Services;
using NorthWind.Writers;

IUserActionWriter writer = new DebugWriter();

AppLogger logger = new AppLogger(writer);
logger.WriteLog("Application started.");

ProductService Service=new ProductService(writer);
Service.Add("Demo", "Azucar refinada");
