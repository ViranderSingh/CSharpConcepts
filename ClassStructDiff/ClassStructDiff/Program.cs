using System;

//public sealed class Customer //Sealed keyword prevents Customer class from being used as a base class
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Customer()   //A class can have an explicit parameterless constructor whereas a struct can't
    {

    }
    ~Customer()     //Only classes can have Destructors but not a struct
    {

    }
}

namespace ClassStructDiff
{
    class Program
    {
        static void Main()
        {
            //int i = 0;

            //if(i == 10)
            //{
            //    int j = 20;
            //    Customer C1 = new Customer();
            //    C1.Id = 101;
            //    C1.Name = "Mark";
            //}

            //Console.WriteLine("Hello");

            int i = 10;
            int j = i;

            j += 1;

            Console.WriteLine("i = {0} && j = {1}", i, j);

            Customer C1 = new Customer();
            C1.Id = 101;
            C1.Name = "Mark";

            Customer C2 = C1;
            C2.Name = "Mary";

            Console.WriteLine("C1.Name = {0} && C2.Name = {1}", C1.Name, C2.Name);

        }
    }
}
