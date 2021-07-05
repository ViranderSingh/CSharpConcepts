using System;

namespace CoffeeMachineDoWhile
{
    class Program
    {
        static void Main()
        {
            int TotalCoffeeCost = 0;
            string UserDecision = string.Empty;

            do
            {
                int UserChoice = -1;

                do
                {
                    Console.WriteLine("Please enter a coffee size : 1 - Small, 2 - Medium, 3 - Large");

                    UserChoice = int.Parse(Console.ReadLine());

                    switch (UserChoice)
                    {
                        case 1:
                            TotalCoffeeCost += 1;
                            break;
                        case 2:
                            TotalCoffeeCost += 2;
                            break;
                        case 3:
                            TotalCoffeeCost += 3;
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid", UserChoice);
                            break;
                    }
                } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);

                do
                {
                    Console.WriteLine("Do you want to buy another cofee - Yes or No");
                    UserDecision = Console.ReadLine().ToUpper();

                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine("You choice {0} is invalid.. Please try again", UserDecision);
                    }
                } while (UserDecision != "YES" && UserDecision != "NO");
            } while (UserDecision.ToUpper() != "NO");

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Total Bill Amount is : {0}", TotalCoffeeCost);
        }
    }
}
