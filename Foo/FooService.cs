using System;
using Autofac.Extras.DynamicProxy;

namespace TryAutoFac.Interceptor
{
    //[Intercept(typeof(AuthorizationInterceptor))]
    public class FooService : IFooService
    {
        public IBoo _testBoo { get; set; }
        public void Say(string message)
        {
            _testBoo.Say("Boo: Property injection!");

            Console.WriteLine(message);
        }
    }
}