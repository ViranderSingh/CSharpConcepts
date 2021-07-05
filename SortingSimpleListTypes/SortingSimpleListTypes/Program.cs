using System;
using System.Collections.Generic;

namespace SortingSimpleListTypes
{
    class Program
    {
        static void Main()
        {
            //List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            //Console.WriteLine("Numbers without sorting");

            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //numbers.Sort();

            //Console.WriteLine("Numbers after sorting");

            //foreach (int sortedN in numbers)
            //{
            //    Console.WriteLine(sortedN);
            //}

            //numbers.Reverse();

            //Console.WriteLine("Numbers in reverse order after sorting/ descending order");

            //foreach (int descN in numbers)
            //{
            //    Console.WriteLine(descN);
            //}

            //------------------------------------------------------------------------------------

            //List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };
            //Console.WriteLine("Alphabets without sorting");

            //foreach (string alpha in alphabets)
            //{
            //    Console.WriteLine(alpha);
            //}

            //alphabets.Sort();
            //Console.WriteLine("Alphabets after sorting");

            //foreach (string sortedAlpha in alphabets)
            //{
            //    Console.WriteLine(sortedAlpha);
            //}

            //alphabets.Reverse();
            //Console.WriteLine("Alphabets in descending order");

            //foreach (string descAlpha in alphabets)
            //{
            //    Console.WriteLine(descAlpha);
            //}

            //------------------------------------------------------------------------------------

            //Complex types cannot be sorted with .Sort() until IComparable interface is implemented
            //In simple types, the Icomparable interface is implemented already
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

            listCustomers.Sort();   //Yields an exception at runtime

           
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
