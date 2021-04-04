
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Project.CORE.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.CORE.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
