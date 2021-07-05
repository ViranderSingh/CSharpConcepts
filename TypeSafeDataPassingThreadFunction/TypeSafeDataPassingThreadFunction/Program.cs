using System;
using System.Threading;

namespace TypeSafeDataPassingThreadFunction
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            Number number = new Number(target);
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            T1.Start();
        }
    }

    class Number
    {
        private int _target;
        public Number(int target)
        {
            this._target = target;
        }

        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
