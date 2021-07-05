using System;

namespace Methods_2
{
    class Program
    {
        static void Main()
        {
            //Methods with Parameters
            Program P = new Program();
            int Sum = P.Add(30, 20);
            Console.WriteLine("Sum = {0}", Sum);
        }

        public int Add(int FN, int SN)
        {
            return FN + SN;
        }
    }
}
