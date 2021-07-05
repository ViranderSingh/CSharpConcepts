using System;

namespace CoffeeMachineUsingSwitch
{
    class Program
    {
        static void Main()
        {
            //using goto is a bad programming and the right way is by using loops
            int TotalCoffeeCost = 0;

            Start:
            Console.WriteLine("Please enter a coffee size : 1 - Small, 2 - Medium, 3 - Large");

            int UserChoice = int.Parse(Console.ReadLine());

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
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do you want to buy another cofee - Yes or No");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("You choice {0} is invalid.. Please try again", UserDecision);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Total Bill Amount is : {0}", TotalCoffeeCost);
        }
    }
}
