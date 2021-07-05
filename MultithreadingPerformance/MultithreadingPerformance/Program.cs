using System;
using System.Threading;
using System.Diagnostics;

namespace MultithreadingPerformance
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Processor Count: {0}", Environment.ProcessorCount);

            Stopwatch stopwatch = Stopwatch.StartNew();
            EvenNumbersSum();
            OddNumbersSum();
            stopwatch.Stop();
            Console.WriteLine("Total milliseconds without multiple threads = {0}", stopwatch.ElapsedMilliseconds);

            stopwatch = Stopwatch.StartNew();
            Thread T1 = new Thread(EvenNumbersSum);
            Thread T2 = new Thread(OddNumbersSum);

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();
            stopwatch.Stop();
            Console.WriteLine("Total milliseconds with multiple threads = {0}", stopwatch.ElapsedMilliseconds);
        }

        public static void EvenNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i <= 500000000; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of even numbers = {0}", sum);
        }

        public static void OddNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of of odd numbers = {0}", sum);
        }
    }

    

    
}
