using System;

namespace ExceptionHandlingAbuse
{
    class Program
    {
        static void Main()
        {
            //Exmple of Exception Handling Abuse
            try
            {
                Console.WriteLine("Please enter Numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter Denominator");
                int Denominator = Convert.ToInt32(Console.ReadLine());

                int Result = Numerator / Denominator;
                Console.WriteLine("Result = {0}", Result);
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Only numbers between {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
