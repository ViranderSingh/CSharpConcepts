using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ListCollectionMethods
{
    class Program
    {
        static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };
            Customer customer2 = new Customer()
            {
                ID = 103,
                Name = "John",
                Salary = 7000
            };
            Customer customer3 = new Customer()
            {
                ID = 102,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer> listCustomers = new List<Customer>(100);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            //TrueForAll() returns bool value for the specified predicate
            //Console.WriteLine("Are all salaries greater than 5000 = " + 
            //    listCustomers.TrueForAll(cust => cust.Salary > 5000));

            //Console.WriteLine("Are all salaries greater than 3000 = " +
            //    listCustomers.TrueForAll(cust => cust.Salary > 3000));

            //AsReadOnly() lets you read an object at a specific index and also read the objects in a list
            //ReadOnlyCollection<Customer> readonlyCollection = listCustomers.AsReadOnly();     //avaialble in System.Collections.ObjectModel class
            ////readonlyCollection[0]
            //Console.WriteLine("Items = " + readonlyCollection.Count);

            //TrimExcess() sets the capacity to needed items and frees the memory overhead by trimming the unused capacity. This increases the performance
            //TrimExcess() is usefull only if the capacity used is below 90% of the total capacity.
            Console.WriteLine("Capacity before trimming = " + listCustomers.Capacity);
            listCustomers.TrimExcess();
            Console.WriteLine("Capacity after trimming = " + listCustomers.Capacity);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
