using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");

            int UserNumber = int.Parse(Console.ReadLine());

            switch(UserNumber)
            {
                case 10:
                    Console.WriteLine("User number is 10");
                    break;
                case 20:
                    Console.WriteLine("User number is 20");
                    break;
                case 30:
                    Console.WriteLine("User number is 30");
                    break;
                case 40:
                case 50:
                case 60:
                    Console.WriteLine("User number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("User number is neither 10 nor 20 nor 30");
                    break;
            }
        }
    }
}
