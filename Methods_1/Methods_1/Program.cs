using System;

namespace Methods_1
{
    class Program
    {
        public static void Main()       //Static method has static modifier
        {
            //To invoke an instance method, an object of the class has to be created 
            Program p = new Program();
            p.NonStaticEvenNumbers(30);

            //A static method can be invoked using the class name directly
            Program.StaticEvennumbers();
        }

        public void NonStaticEvenNumbers(int Target)       //Without the static keyword, its known as an Instance Method
        {
            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }

        public static void StaticEvennumbers()     //Static method
        {
            int Start = 0;

            while (Start <= 20)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }
    }
}
