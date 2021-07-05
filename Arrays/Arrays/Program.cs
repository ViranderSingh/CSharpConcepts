using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;

            Console.WriteLine("{0} is an Even Number", EvenNumbers[1]);
        }
    }
}
