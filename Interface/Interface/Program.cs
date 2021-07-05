using System;

//Interface
interface ICustomer1
{
    void Print1();
}

interface ICustomer2 : ICustomer1
{
    void Print2();
}

//Class inheriting from an interface
public class Customer : ICustomer2       //Multiple interface inheritance is possible
{
    public void Print2()
    {
        Console.WriteLine("Print2 method");
    }

    public void Print1()
    {
        Console.WriteLine("Print1 method");
    }
}

//public class Sample
//{

//}

namespace Interface
{
    class Program       //class Program : Customer, Sample //Multiple class inheritance is NOT possible
    {
        static void Main()
        {
            Customer C1 = new Customer();
            C1.Print1();
            C1.Print2();

            ICustomer1 Cust = new Customer();       //Interface referance variable can point to a derived class object
            Cust.Print1();
        }
    }
}
