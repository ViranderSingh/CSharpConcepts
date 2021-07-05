using System;
using System.Threading;
using System.Diagnostics;

namespace ProtectingSharedResources
{
    class Program
    {
        static int Total = 0;

        static void Main()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            //AddOneMillion();
            //AddOneMillion();
            //AddOneMillion();
            //Console.WriteLine("Total = {0}", Total);

            Thread T1 = new Thread(Program.AddOneMillion);
            Thread T2 = new Thread(Program.AddOneMillion);
            Thread T3 = new Thread(Program.AddOneMillion);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            Console.WriteLine("Total = {0}", Total);

            stopwatch.Stop();
            Console.WriteLine("In Milliseconds : {0}",stopwatch.ElapsedMilliseconds);
            Console.WriteLine("In Ticks : {0}", stopwatch.ElapsedTicks);

            Console.WriteLine("Tick per millisecond {0}", TimeSpan.TicksPerMillisecond);
        }

        //public static void AddOneMillion()
        //{
        //    for (int i = 1; i <= 1000000; i++)
        //    {
        //        Total++;
        //    }
        //}

        //Using Interlocked.Increment() method 
        //public static void AddOneMillion()
        //{
        //    for (int i = 1; i <= 1000000; i++)
        //    {
        //        Interlocked.Increment(ref Total);
        //    }
        //}

        //Using Lock
        //static object _lock = new object();
        //public static void AddOneMillion()
        //{
        //    for (int i = 1; i <= 1000000; i++)
        //    {
        //        lock (_lock)
        //        {
        //            Total++;
        //        }                
        //    }
        //}

        //Using Monitor
        //static object _lock = new object();
        //public static void AddOneMillion()
        //{
        //    for (int i = 1; i < 1000000; i++)
        //    {
        //        Monitor.Enter(_lock);
        //        try
        //        {
        //            Total++;
        //        }
        //        finally
        //        {
        //            Monitor.Exit(_lock);
        //        }
        //    }
        //}

        //In C# 4, Monitor implementation
        static object _lock = new object();
        public static void AddOneMillion()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                bool lockTaken = false;

                Monitor.Enter(_lock, ref lockTaken);
                try
                {
                    Total++;
                }
                finally
                {
                    if (lockTaken)
                    {
                        Monitor.Exit(_lock);
                    }
                }
            }
        }
    }
}
