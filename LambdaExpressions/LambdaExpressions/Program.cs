using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main()
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ID = 101, Name = "Mark"},
                new Employee{ID = 102, Name = "John"},
                new Employee{ID = 103, Name = "Mary"}
            };

            //Using Anonymous Method
            //Employee employee = listEmployees.Find(delegate (Employee Emp) { return Emp.ID == 102; });
            //Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);

            //Using Lambda Expression
            //Employee employee = listEmployees.Find(Emp => Emp.ID == 102);   //One way
            Employee employee = listEmployees.Find((Employee Emp) => Emp.ID == 102);    //Second Way but first way is easy
            Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);

            int count = listEmployees.Count(Emp => Emp.Name.StartsWith("M"));
            Console.WriteLine("Number of employee whose names start with M are {0}", count);
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
