using System;
using System.Text;

namespace StringBuilderVsSystemString
{
    class Program
    {
        static void Main()
        {
            //Creates garbage objects which is later collected by the garbage collector
            //string userString = "C#";
            //userString += " video";
            //userString += " for";
            //userString += " developers";
            //Console.WriteLine(userString);

            //Does NOT create garbage object which improves the performance as the space occupied in the heap is less 
            //StringBuilder userString = new StringBuilder("C#");
            //userString.Append(" video");
            //userString.Append(" for");
            //userString.Append(" developers");
            //Console.WriteLine(userString);

            //string userString = string.Empty;
            //for(int i = 1; i <=10000; i++)
            //{
            //    userString += i.ToString() + " ";
            //}
            //Console.WriteLine(userString);

            StringBuilder userString = new StringBuilder(" ");
            for (int i = 1; i <= 10000; i++)
            {
                userString.Append(i.ToString() + " ");
            }
            Console.WriteLine(userString);
        }
    }
}
