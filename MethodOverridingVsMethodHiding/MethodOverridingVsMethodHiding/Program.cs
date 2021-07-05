using System;

public class BaseClass
{
    public virtual void Print ()
    {
        Console.WriteLine("I'm a base class method");
    }
}

public class DerivedClass : BaseClass
{
    //public override void Print()
    //{
    //    Console.WriteLine("I'm a derived class method");
    //}

    public new void Print()
    {
        Console.WriteLine("I'm a derived class method");
    }
}

namespace MethodOverridingVsMethodHiding
{
    class Program
    {
        static void Main()
        {
            BaseClass B = new DerivedClass();
            B.Print();

            DerivedClass D = new DerivedClass();
            D.Print();
        }
    }
}
