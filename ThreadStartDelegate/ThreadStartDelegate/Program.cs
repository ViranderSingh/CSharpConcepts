using System;
using System.Threading;

namespace ThreadStartDelegate
{
    class Program
    {
        static void Main()
        {
            //Thread T1 = new Thread(Numbers.PrintNumbers);   //First Overload of thread
            //Thread T1 = new Thread(new ThreadStart(Numbers.PrintNumbers));      //Second overload of thread 

            //Different ways to instantiate a thread
            //Thread T1 = new Thread(delegate () { Numbers.PrintNumbers(); });
            //Thread T1 = new Thread(() => Numbers.PrintNumbers());

            //Instatntiating a thread of a non-static function
            Numbers numbers = new Numbers();    //Create new instance of the class
            Thread T1 = new Thread(numbers.PrintNumbers); //Use the instance variable to call the non-static function
            T1.Start();
        }
    }

    class Numbers
    {
        //Static functionu
        //public static void PrintNumbers()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //Non-Static Function
        public void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
