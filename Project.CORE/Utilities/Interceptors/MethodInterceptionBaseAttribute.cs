using Castle.DynamicProxy;
using System;

namespace Project.CORE.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }//öncelik hangi attribute once calıssın 

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
