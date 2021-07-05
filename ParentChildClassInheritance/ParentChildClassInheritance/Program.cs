using System;

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass Constructor Called");
    }

    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    //public ChildClass()
    //{
    //    Console.WriteLine("ChildClass Constructor Called");
    //}

    //Use base keyword to initialize Parent constructor with parameter from the child constructor
    public ChildClass() : base("Derived class controlling Parent Class")
    {
        Console.WriteLine("ChildClass Constructor Called");
    }
}

namespace ParentChildClassInheritance
{
    class Program
    {
        static void Main()
        {
            ChildClass CC = new ChildClass();
            
        }
    }
}
