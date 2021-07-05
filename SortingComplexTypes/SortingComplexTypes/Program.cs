using System;
using System.Collections.Generic;

namespace SortingComplexTypes
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
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            //Based on Salary
            Console.WriteLine("This is before sorting");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            listCustomers.Sort();       //An overload of Sort()

            Console.WriteLine("This is after sorting");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            listCustomers.Reverse();

            Console.WriteLine("This is in desceding order");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            //Based on Name (One way)
            //Console.WriteLine("This is before sorting");

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine(c.Name);
            //}

            //listCustomers.Sort();

            //Console.WriteLine("This is after sorting");

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine(c.Name);
            //}

            //listCustomers.Reverse();

            //Console.WriteLine("This is in desceding order");

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine(c.Name);
            //}

            //Based on Name (Second Way)
            Console.WriteLine("This is before sorting");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            SortByName sortByName = new SortByName();
            //listCustomers.Sort(sortByName);     //An overload of Sort. Sort(IComparer<Customer>)
            listCustomers.Sort(1, 2, sortByName);   //An overload of Sort. Sort(index, count, IComparer<Customer>)

            Console.WriteLine("This is after sorting");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            listCustomers.Reverse();

            Console.WriteLine("This is in desceding order");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            //Based on ID
            //Console.WriteLine("This is before sorting");

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine(c.ID);
            //}

            //Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);  //Comparison<Customer> is a delegate and a delegate is a function pointer
            //listCustomers.Sort(customerComparer);       //An overload of Sort. Sort(Comparison<Customer>).

            //The above code can be simplified to below code
            //listCustomers.Sort(delegate (Customer c1, Customer c2)
            //{
            //    return c1.ID.CompareTo(c2.ID);
            //});

            //The above code can be further simplified to below code
            //listCustomers.Sort((c1, c2) => c1.ID.CompareTo(c2.ID));

            //Console.WriteLine("This is after sorting");

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine(c.ID);
            //}

            //listCustomers.Reverse();

            //Console.WriteLine("This is in desceding order");

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine(c.ID);
            //}
            
        }
        //Signature of this function must match the signature of the delegate Comparison<>
        //private static int CompareCustomer(Customer x, Customer y)
        //{
        //    return x.ID.CompareTo(y.ID);
        //}
    }

    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            //One way of doing it
            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else
            //    return 0;

            //Since salary is int, we can make use of .CompareTo()
            //Second way of doing it
            return this.Salary.CompareTo(other.Salary);

            //Sorting based on Names (One way)
            //return this.Name.CompareTo(this.Name);
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            //Sorting based on Names (Second way)
            return x.Name.CompareTo(y.Name);
        }
    }
}
