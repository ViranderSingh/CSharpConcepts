using System;
using System.Collections.Generic;

namespace AnonymousMethods
{
    class Program
    {
        static void Main()
        {
            List<Employee> listEmployee = new List<Employee>()
            {
                new Employee{ID = 101, Name= "Mark"},
                new Employee{ID = 102, Name = "John"},
                new Employee{ID = 103, Name = "Mary"}
            };

            //Step 2
            //Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

            //Step 3
            //Employee employee = listEmployee.Find(emp => employeePredicate(emp));
            //Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);

            //using Anonymous method
            Employee employee = listEmployee.Find(delegate (Employee emp) { return emp.ID == 102; });
            Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);
        }

        //Step 1 
        //public static bool FindEmployee(Employee Emp)
        //{
        //    return Emp.ID == 102;
        //}
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
