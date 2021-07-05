using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncDelegate
{
    class Program
    {
        static void Main()
        {
            //Example 1
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ID = 101, Name = "Mark"},
                new Employee{ID = 102, Name = "John"},
                new Employee{ID = 103, Name = "Mary"}
            };


            //Using Func Delegate
            //Func<Employee, string> selector = employee => "Name = " + employee.Name;
            //IEnumerable<string> names = listEmployees.Select(selector);

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Lambda expression can also be used to achieve the same thing
            IEnumerable<string> names = listEmployees.Select(employee => "Name = " + employee.Name);
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Example 2
            Func<int, int, string> funcDelegate = (firstNumber, secondNumber) => "Sum = " + (firstNumber + secondNumber).ToString();

            string result = funcDelegate(10, 20);
            Console.WriteLine(result);
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
