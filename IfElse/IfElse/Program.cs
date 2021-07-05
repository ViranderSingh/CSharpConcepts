using System;

namespace IfElse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");

            int Number = int.Parse(Console.ReadLine());

            if (Number == 1)
            {
                Console.WriteLine("Entered number is 1");
            }
            //if (Number == 2)                  //all the if conditions are checked even after first condition is true
            //{
            //    Console.WriteLine("Entered number is 2");
            //}
            //if (Number == 3)
            //{
            //    Console.WriteLine("Entered number is 3");
            //}
            //if (Number != 1 && Number != 2 && Number != 3)
            //{
            //    Console.WriteLine("Entered number is not in between 1 and 3");
            //}

            //Else if condition is skipped if the first if condiotion is satisfied
            //else if (Number == 2)
            //{
            //    Console.WriteLine("Entered number is 2");
            //}
            //else if (Number == 3)
            //{
            //    Console.WriteLine("Entered number is 3");
            //}
            //else
            //{
            //    Console.WriteLine("Entered number is not in between 1 and 3");
            //}

            //Difference between || and |
            if (Number == 10 || Number == 20)       // || will skip 2nd condition if 1st condition is true 
            {
                Console.WriteLine("Entered Number is is either 10 or 20");
            }
            if (Number == 30 | Number == 40)        // | will check 2nd condition even if 1st condition is true
            {
                Console.WriteLine("Entered number is either 30 or 40");
            }

            //Difference between && and &
            if (Number == 50 && Number == 60)       // && will skip 2nd condition if 1st condition is false
            {
                Console.WriteLine("Entered number is either 50 or 60");
            }
            if (Number == 70 & Number == 80)        // & will check 2nd condition if even if 1st condition is false
            {
                Console.WriteLine("Entered number is either 70 or 80");
            }
        }
    }
}
