using System;

namespace CommonOperators
{
    class Program
    {
        static void Main()
        {
            int Numerator = 10;
            int Denominator = 2;
            //int Result = Numerator / Denominator; //'/' gives quotient
            int Result = Numerator % Denominator;   //'%' gives denominator

            Console.WriteLine("Result = {0}", Result);

            int Num1 = 20;
            int Num2 = 20;
            int Mul = Num1 * Num2;

            Console.WriteLine("Result = {0}", Mul);

            //Check if the given number is true or false
            int Num3 = 5;
            bool IsNum5;

            if (Num3 == 5)
            {
                IsNum5 = true;
            }
            else
            {
                IsNum5 = false;
            }

            Console.WriteLine("Number == 5 is {0}", IsNum5);

            //Writing the above code using Ternary Operators
            int Num4 = 10;

            bool IsNum10 = Num4 == 10 ? true : false;

            Console.WriteLine("Number == 10 is {0}", IsNum10);
        }
    }
}
