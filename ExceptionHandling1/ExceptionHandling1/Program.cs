using System;
using System.IO;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main()
        {
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"C:\Users\MandeepSingh\Documents\CSharpDemo\Demo1.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            //catch(Exception ex)
            catch(FileNotFoundException ex)
            {
                //Console.WriteLine(ex.FileName);
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine(ex.Message);
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);

                //Can also log the details is Db for later purposes
                Console.WriteLine("Please check if the file {0} exists", ex.FileName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally     //Release the resources only in the finally block as finally block is guaranteed to execute
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }

                Console.WriteLine("Finally Block");
            }
        }
    }
}
