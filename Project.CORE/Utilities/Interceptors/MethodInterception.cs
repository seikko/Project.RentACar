using Castle.DynamicProxy;
using System;

namespace Project.CORE.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        //invocation bussines method'u demektir. 
        protected virtual void OnBefore(IInvocation invocation) { }//once calıscak
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        //hata alınca calısıcak
        protected virtual void OnSuccess(IInvocation invocation) { }//basarılı olunca calısıcak
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();//Once calıstırmayı dene
            }
            catch (Exception e)
            {
                isSuccess = false;//hata verirse burayı calıstır
                OnException(invocation, e);
                throw;
            }
            finally
            {
                //ister calıssın ister hata versin burası calıssın.
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
