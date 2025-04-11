using Microsoft.Extensions.DependencyInjection;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddService
        (this IServiceCollection services)
    {
        services.AddSingleton<IAppLogger, AppLogger>();
        services.AddSingleton<IProductService, ProductService>();
        return services;
    }

}
