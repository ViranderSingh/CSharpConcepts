using System;

namespace ReadingWritingToConsole
{
    class Program
    {
        static void Main()
        {
            ////Prompting the user for a name
            //Console.WriteLine("Please enter a name:");

            ////Reading the name entered by user
            //string UserName = Console.ReadLine();

            ////Concatenating entered name with Hello word and printing
            //Console.WriteLine("Hello " + UserName);

            ////Placeholder syntax with Hello word and print
            //Console.WriteLine("Hello {0}", UserName);

            Console.WriteLine("Please enter your first name:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hello {0}, {1}", FirstName, LastName);
        }
    }
}
