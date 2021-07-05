using System;
using System.Collections.Generic;

namespace StackCollection
{
    class Program
    {
        static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };
            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Ken",
                Gender = "Male"
            };
            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Valarie",
                Gender = "Female"
            };

            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            //Pop() removes and returns last added/remaining item in the stack
            Customer c1 = stackCustomers.Pop();
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", c1.ID, c1.Name, c1.Gender);
            Console.WriteLine("Number  of items in the stack are = {0}", stackCustomers.Count);

            //Customer c2 = stackCustomers.Pop();
            //Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", c2.ID, c2.Name, c2.Gender);
            //Console.WriteLine("Number  of items in the stack are = {0}", stackCustomers.Count);

            //Customer c3 = stackCustomers.Pop();
            //Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", c3.ID, c3.Name, c3.Gender);
            //Console.WriteLine("Number  of items in the stack are = {0}", stackCustomers.Count);

            //Customer c4 = stackCustomers.Pop();
            //Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", c4.ID, c4.Name, c4.Gender);
            //Console.WriteLine("Number  of items in the stack are = {0}", stackCustomers.Count);

            //Customer c5 = stackCustomers.Pop();
            //Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", c5.ID, c5.Name, c5.Gender);
            //Console.WriteLine("Number  of items in the stack are = {0}", stackCustomers.Count);

            //Peek() return last added item in the stack without removing it
            //Customer c1 = stackCustomers.Peek();
            //Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", c1.ID, c1.Name, c1.Gender);
            //Console.WriteLine("Number  of items in the stack are = {0}", stackCustomers.Count);

            //foreach (Customer c in stackCustomers)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", c.ID, c.Name, c.Gender);
            //    Console.WriteLine("Number  of items in the stack are = {0}", stackCustomers.Count);
            //}

            if (stackCustomers.Contains(customer5))
            {
                Console.WriteLine("Customer5 exists");
            }
            else
            {
                Console.WriteLine("Customer5 doesn't exist");
            }
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
