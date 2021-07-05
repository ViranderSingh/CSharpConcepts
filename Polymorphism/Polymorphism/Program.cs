using System;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    //Use virtual keyword to indicate that a base class method can be overriden from any derived class
    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    //Any method declared as virtual in the base class can be overriden in the derived class using override keyword
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Full Time");
    }
}

public class PartTimeEmployee : Employee
{
    //Any method declared as virtual in the base class can be overriden in the derived class using override keyword
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Part Time");
    }
}

public class TemporaryEmployee : Employee
{
    //Any method declared as virtual in the base class can be overriden in the derived class using override keyword
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Temporary");
    }
}

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
