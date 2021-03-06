using System;
using System.Collections.Generic;

namespace LamdaExpressionInsteadOfDelegate
{
    class Program
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 40000, Experience = 4 });
            empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

            //Instead of pointing a delegate to a function, we can make use of Lambda Expression
            //IsPromotable ispromotable = new IsPromotable(Promote);
            //Employee.PromoteEmployee(empList, ispromotable);

            //Lambda Expression
            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
        }

        //public static bool Promote(Employee emp)
        //{
        //    if (emp.Experience >= 5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}

delegate bool IsPromotable(Employee empl);

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)   //We use delegate as a second parameter
    {
        foreach (Employee employee in employeeList)
        {
            //The criteria for an employee to get a promotion is hard coded
            //Hence this method isn't reusable
            //We can make methods reusable using delegates
            //if (employee.Experience >= 5)
            //{
            //    Console.WriteLine(employee.Name + " promoted");
            //}

            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }

}