using System;

namespace ToStringVsConvertToString
{
    class Program
    {
        static void Main()
        {
            Customer C1 = new Customer();
            //string str = C1.ToString();       //.ToString() gives NullReferenceException if C1 is null
            string str = Convert.ToString(C1);  //Convert.ToString() creates an empty string if C1 is null
            Console.WriteLine(str);
        }

        public class Customer
        {
            public string Name { get; set; }

            public override string ToString()
            {
                return base.ToString();
            }
        }
    }
}
