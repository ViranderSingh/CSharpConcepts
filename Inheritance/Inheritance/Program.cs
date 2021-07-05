using System;

public class Employee
{
    public string FirstName;        //Never make fields as public. This is just for this example
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}

//Multi-Level Inheritance is possible in C# but multiple class inheritance isn't possible
//public class A : PartTimeEmployee
//{

//}

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Virander";
            FTE.LastName = "Singh";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Jasbir";
            PTE.LastName = "Singh";
            PTE.HourlyRate = 200;
            PTE.PrintFullName();

            //A A1 = new A();
            //A1.HourlyRate = 100;
        }
    }
}


