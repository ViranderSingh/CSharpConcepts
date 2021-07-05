using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main()
        {
            string UserChoice = "";

            do
            { 
            Console.WriteLine("Please enter your Target");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserTarget)
            {
                Console.Write(Start + " ");
                Start += 2;
            }

                Console.WriteLine("");

            do
            {
                Console.WriteLine("Do you want to Continue - Yes or No?");

                UserChoice = Console.ReadLine().ToUpper();

                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Invalid choice, please say Yes or No");
                }
            } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
        }
    }
}
