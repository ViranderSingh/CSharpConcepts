using System;
using System.IO;

namespace InnerException
{
    class Program
    {
        static void Main()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;

                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    //string filePath = @"C:\Users\MandeepSingh\Documents\CSharpDemo\Log.txt"; //right path with correct filename
                    string filePath = @"C:\Users\MandeepSingh\Documents\CSharpDemo\Log1.txt";

                    if (File.Exists(filePath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.WriteLine(ex.GetType().Name);
                        streamWriter.WriteLine(ex.Message);
                        streamWriter.Close();
                        //Console.WriteLine(ex.Message);
                        Console.WriteLine("There is a problem, please try later");
                    }
                    else
                    {
                        //Pass the Inner Exception as a parameter to the current exception constructor
                        //If not done, the inner exception is set to null value
                        throw new FileNotFoundException(filePath + " is not present", ex);  
                    }

                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("Current Exception = {0}", exception.GetType().Name);

                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
                }
            }
        }
    }
}
