using System;

namespace ForLoop
{
    class Program
    {
        static void Main()
        {
            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            foreach (int k in Numbers)      //there is no chance of getting an IndexOutOfRange Exception with foreach loop
            {
                Console.WriteLine(k);
            }

            //for (int j = 0; j < Numbers.Length; j++)
            //{
            //    Console.WriteLine(Numbers[j]);
            //}

            //Console.WriteLine("");

            //int i = 0;
            //while(i < Numbers.Length)
            //{
            //    Console.WriteLine(Numbers[i]);
            //    i++;
            //}
            
        }
    }
}
