using System;

namespace BreakContinue
{
    class Program
    {
        static void Main()
        {
            //Example of break
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);

            //    if (i == 10)
            //        break;
            //}

            //Example of continue
            for (int j = 0; j <= 20; j++)
            {
                if (j % 2 == 1)
                    continue;

                Console.WriteLine(j);
            }
        }
    }
}
