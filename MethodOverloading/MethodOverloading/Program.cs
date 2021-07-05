using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main()
        {
            //A method with same name can be overloaded based on number, type and kind of parameters
            Add(10, 20);
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum is {0}", FN + SN);
        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum is {0}", FN + SN + TN);
        }

        public static void Add(int FN, int SN, int TN, int FourthNumber)
        {
            Console.WriteLine("Sum is {0}", FN + SN + TN + FourthNumber);
        }

        public static void Add(float FN, float SN)
        {
            Console.WriteLine("Sum is {0}", FN + SN);
        }

        public static void Add(float FN, int SN)
        {
            Console.WriteLine("Sum is {0}", FN + SN);
        }

        public static void Add(int FN, float SN)
        {
            Console.WriteLine("Sum is {0}", FN + SN);
        }

        public static void Add(int FN, int SN, out int Sum)
        {
            Console.WriteLine("Sum is {0}", FN + SN);
            Sum = FN + SN;
        }
    }
}
