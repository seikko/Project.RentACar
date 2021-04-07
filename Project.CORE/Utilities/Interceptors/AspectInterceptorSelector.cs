using Castle.DynamicProxy;
using Project.CORE.CrossCuttingConcerns.Performance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Project.CORE.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>//class'ın attributlarını oku
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name) // metodun attributlarını oku (Log,Cache)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);



            return classAttributes.OrderBy(x => x.Priority).ToArray();//calısmasınıda oncelık degerıne gore sırala
        }
    }
}
