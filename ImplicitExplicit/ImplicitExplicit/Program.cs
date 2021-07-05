using System;

namespace ImplicitExplicit
{
    class Program
    {
        static void Main()
        {
            //Implicit Conversion
            //Float is a bigger datatype than int. So, No loss
            //of data and exceptions. Hence, implicit conversion
            //int i = 100;

            //float f = i;
            //Console.WriteLine(f);

            //Cannot implicitly convert float to int
            //Fractional part will be lost. Float is a
            //bigger data type than int, so there is
            //also a possibility of overflow exception
            //Explicit Conversion with Type Cast Operator
            //float f = 123.45F;

            //int i = (int)f;

            //Console.WriteLine(i);


            //Explicit Conversion with Convert Class
            //float f = 123.45F;

            //int i = Convert.ToInt32(f);

            //Console.WriteLine(i);


            //Explicit Overflow
            float f = 1222222222233333333333.143F;

            //int i = (int)f;   //false value
            int i = Convert.ToInt32(f); //System.OverflowException

            Console.WriteLine(i);
        }
    }
}
