using System;

public class A
{
    public virtual void Print()
    {
        Console.WriteLine("A Print Method");
    }
}

public class B : A
{
    public override void Print()
    {
        Console.WriteLine("B Print Method");
    }
}

public class C : A
{
    public override void Print()
    {
        Console.WriteLine("C Print Method");
    }
}

public class D : B, C       //Multiple class inheritance is Not possible in C#
{
   
}

namespace DiamondProblem
{
    class Program
    {
        static void Main()
        {
            D d = new D();
            d.Print();
        }
    }
}
