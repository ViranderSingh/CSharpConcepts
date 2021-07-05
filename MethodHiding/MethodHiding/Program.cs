using System;

public class Employee
{
    public string FirstName;
    public string Lastname;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + Lastname);
    }
}

public class PartTimeEmployee : Employee
{
    //Child Class method hides the base class method with same method name
    //Use new keyword to hide a base class member
    public new void PrintFullName()
    {
        //base.PrintFullName();   //Use base keyword to call the base class member/method
        Console.WriteLine(FirstName + " " + Lastname + " - Contractor");
    }
}

public class FullTimeEmployee : Employee
{

}

namespace MethodHiding
{
    class Program
    {
        static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.Lastname = "Employee";
            FTE.PrintFullName();

            //PartTimeEmployee PTE = new PartTimeEmployee();
            Employee PTE = new PartTimeEmployee();      //A child class object can be assigned to a parent class reference variable so that a parent class method is invoked. Visa-Versa isnt possible
            PTE.FirstName = "PartTime";
            PTE.Lastname = "LastName";
            PTE.PrintFullName();
            //((Employee)PTE).PrintFullName();        //Cast child type to parent type and invoke the hidden member
        }
    }
}
