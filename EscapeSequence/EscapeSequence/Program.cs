using System;

namespace EscapeSequence
{
    class Program
    {
        static void Main()
        {
            string Name = "\"Virander\"";   //Escape sequence preceeds with a backslash \
            Console.WriteLine(Name);

            string S = "One\nTwo\nThree";
            Console.WriteLine(S);

            //Without the Verbatim Literal, the readability is less as shown below
            //string Path = "H:\\Virander Singh\\Training\\2. C Sharp";

            //With the Verbatim Literal, the readability is better as shown below
            string Path = @"H:\Virander Singh\Training\2. C Sharp";
            Console.WriteLine(Path);
        }
    }
}
