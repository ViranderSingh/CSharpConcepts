using System;

namespace ParseTryParse
{
    class Program
    {
        static void Main()
        {
            //Parse from str to int
            //string StrNumber = "100";

            //string StrNumber = "100TF"; //System.FormatException
            //int i = int.Parse(StrNumber);

            //Console.WriteLine(i);


            //TryParse from str to Int
            string StrNumber = "100rt";

            int Result = 0;
            bool IsConversionSuccessful = int.TryParse(StrNumber, out Result);

            if(IsConversionSuccessful)
            {
                Console.WriteLine("Result is {0}", Result);
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}
