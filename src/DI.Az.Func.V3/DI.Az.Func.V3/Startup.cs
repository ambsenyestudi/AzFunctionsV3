using DI.Az.Func.V3.App.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
[assembly: FunctionsStartup(typeof(DI.Az.Func.V3.Startup))]
namespace DI.Az.Func.V3
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IGreetingService, GreetingService>();
        }
    }
}
