using System;
using Castle.DynamicProxy;

namespace TryAutoFac.Interceptor
{
    public class AuthorizationInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("BeforeMethodExecuting, AuthorizationInterceptor başladı.");

            invocation.Proceed();

            Console.WriteLine("AfterMethodExecuted, AuthorizationInterceptor bitti.");
        }
    }
}