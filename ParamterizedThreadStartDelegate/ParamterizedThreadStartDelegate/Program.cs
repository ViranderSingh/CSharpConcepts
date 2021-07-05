using System;
using System.Threading;

namespace ParamterizedThreadStartDelegate
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the target number:");
            object target = Console.ReadLine();

            Number numbers = new Number();
            //ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(numbers.PrintNumbers);
            //Thread T1 = new Thread(parameterizedThreadStart);

            Thread T1 = new Thread(numbers.PrintNumbers);  //Compiler implicitely converts this code to the above comented code
            T1.Start(target);
        }
    }

    class Number
    {
        public void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
