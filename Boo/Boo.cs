using System;

namespace TryAutoFac.Interceptor
{
    public class Boo : IBoo
    {
        public void Say(string message)
        {
            Console.WriteLine("Boo!");
        }

    }
}