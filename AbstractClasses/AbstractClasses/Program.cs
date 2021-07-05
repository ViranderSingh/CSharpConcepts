using System;

public abstract class Customer
{
    //An abstract class May or May Not contain an abstract member
    public abstract void Print();

    public void Print1()
    {
        Console.WriteLine("Print1 method");
    }
}
    
namespace AbstractClasses
{
    //public abstract class Program : Customer
    class Program : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
        static void Main()
        {
            //abstract class cannot be instantiated

            //Program P = new Program();
            //P.Print();

            Customer C = new Program();
            C.Print();
        }
    }
}
