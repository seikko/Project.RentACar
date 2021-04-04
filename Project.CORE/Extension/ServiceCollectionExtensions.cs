using Microsoft.Extensions.DependencyInjection;
using Project.CORE.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.CORE.Extension
{
   public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection,ICoreModule[] modules)
        {
            foreach (var item in modules)
            {
                item.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}
