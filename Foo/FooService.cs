using System;
using Autofac.Extras.DynamicProxy;

namespace TryAutoFac.Interceptor
{
    //[Intercept(typeof(AuthorizationInterceptor))]
    public class FooService : IFooService
    {
        public void Say(string message)
        {
            Console.WriteLine(message);
        }
    }
}