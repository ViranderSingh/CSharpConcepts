using System;

namespace Methods_3
{
    class Program
    {
        public static void Main()
        {
            //Pass by Value where i and j are pointing to different memory locations
            int i = 0;

            SimpleMethod(i);

            Console.WriteLine(i);

            //Pass by reference where k and l are pointing to the same memory location
            int k = 0;

            AnotherSimpleMethod(ref k);

            Console.WriteLine(k);

            //Output parameter
            int Total = 0;
            int Product = 0;

            Calculate(10, 20, out Total, out Product);

            Console.WriteLine("Total = {0}, Product = {1}", Total, Product);

            //Paramater Arrays
            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            //ParamsMethod();                       //Params lets you call methods without method paramter or method arguments 

            //ParamsMethod(Numbers);                //Params lets you call the parameter arrays

            ParamsMethod(1, 2, 3, 4, 5, 6);         //Params lets you put all the arguments in the array directly

        }

        public static void SimpleMethod(int j)
        {
            j = 101;
        }

        public static void AnotherSimpleMethod(ref int l)
        {
            l = 101;
        }

        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;

            Product = FN * SN;
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements", Numbers.Length);

            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
