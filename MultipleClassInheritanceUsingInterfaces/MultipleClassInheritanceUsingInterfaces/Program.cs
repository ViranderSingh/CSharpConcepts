using System;

interface IA
{
    void AMethod();
}

class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}

interface IB
{
    void BMethod();
}

class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}

//You cannot inherit multiple classes but a class can inherit multiple interfaces and
//We can use this to inherit multiple classes using interfaces. 
class AB : IA, IB
{
    A a = new A();
    B b = new B();

    public void AMethod()
    {
        a.AMethod();
    }

    public void BMethod()
    {
        b.BMethod();
    }
}

namespace MultipleClassInheritanceUsingInterfaces
{
    class Program
    {
        static void Main()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }
}
