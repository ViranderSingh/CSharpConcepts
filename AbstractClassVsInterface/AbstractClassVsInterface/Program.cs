using System;

public abstract class Customer
{
    int Id;
    public void Print()
    {
        Console.WriteLine("Print Method");
    }
}

public interface ICustomer
{
    void Print();
}

namespace AbstractClassVsInterface
{
    class Program
    {
        static void Main()
        {
            
        }
    }
}
