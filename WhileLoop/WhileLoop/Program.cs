using System;

namespace WhileLoop
{
    class Program
    {
        static void Main()
        {
            //Printing even numbers using while loop
            Console.WriteLine("Please enter your target:");
            int UserChoice = int.Parse(Console.ReadLine());

            int Start = 0;
                
            while(Start <= UserChoice)
            {
                Console.Write(Start+ " ");
                Start += 2;
            }
        }
    }
}
