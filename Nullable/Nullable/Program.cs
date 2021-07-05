using System;

namespace Nullable
{
    class Program
    {
        static void Main()
        {
            bool? IsNotMajor = true;

            if (IsNotMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (IsNotMajor == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User did not answer the question");
            }
        }
    }
}
