using System;

namespace ToStringMethod
{
    class Program
    {
        static void Main()
        {
            int Number = 101;

            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Virander";
            C1.LastName = "Singh";

            //Console.WriteLine(C1.ToString());     //without the override of ToString(), we dont get a meaningful result
            Console.WriteLine(Convert.ToString(C1));
        }
        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return this.LastName + ", " + this.FirstName;
            }
        }
    }
}
