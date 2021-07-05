using System;

public delegate void HelloFunctionDelegate(string Message);

namespace Delegate1
{
    class Program
    {
        static void Main()
        {
            //A Delegate is a type safe function pointer.

            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");
        }

        public static void Hello(string StrMessage)
        {
            Console.WriteLine(StrMessage);
        }
    }
}
