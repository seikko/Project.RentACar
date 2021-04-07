
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Project.CORE.CrossCuttingConcerns.Caching;
using Project.CORE.CrossCuttingConcerns.Caching.Microsoft;
using Project.CORE.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project.CORE.DependencyResolvers
{
    public class CoreModule : ICoreModule //serviceTool
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();//IMemoryCache ınjection
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();

        }
    }
}
