using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            //Dictionary

            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            //Dictionary is a collection of key and value pairs
            //We are specifying the types of key and value below
            //Dictionary<int, Customer> dictionaryCusotmers = new Dictionary<int, Customer>();

            //Use Dictionary.Add() to add data to the dictionary
            //dictionaryCusotmers.Add(customer1.ID, customer1);
            //dictionaryCusotmers.Add(customer2.ID, customer2);
            //dictionaryCusotmers.Add(customer3.ID, customer3);

            //Keys within a dictionary must be unique
            //You can check if the key already exists using .ContainsKey() and then add it
            //if (!dictionaryCusotmers.ContainsKey(customer1.ID))
            //{
            //    dictionaryCusotmers.Add(customer1.ID, customer3);
            //}

            //You can check if the key exists or not
            //if (dictionaryCusotmers.ContainsKey(135))
            //{
            //    Customer cust = dictionaryCusotmers[135];
            //}

            //Retrieving value of a customer based on the key
            //Customer customer119 = dictionaryCusotmers[119];

            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);

            //foreach (var customerKeyValuePair in dictionaryCusotmers)     //var is an implicitly typed variable which is to be avoided for readability
            //foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCusotmers)
            //{
            //    //Looping through all the values based on keys
            //    Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
            //    Customer cust = customerKeyValuePair.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //    Console.WriteLine("--------------------------------------------------------------------");
            //}

            //Looping though to get only keys
            //foreach (int key in dictionaryCusotmers.Keys)
            //{
            //    Console.WriteLine(key);
            //}

            //Looping through to get only values
            //foreach (Customer cust in dictionaryCusotmers.Values)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //    Console.WriteLine("--------------------------------------------------------");
            //}

            //----------------------------------------------------------------------------------------------
            //Methods of Dictionary class

            //TryGetValue(), used to chceck if the key already exists or not and return the corresponding valuje if it does
            //Customer cust;
            //if (dictionaryCusotmers.TryGetValue(101, out cust))
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("The key is not found");
            //}

            //Count(), used to find total number of items in a dictionary
            //You can also find total number of items in a dictionary using .count property
            //Console.WriteLine("Total items = {0}", dictionaryCusotmers.Count);
            //Using Count()
            //Console.WriteLine("Total items = {0}", dictionaryCusotmers.Count(kvp => kvp.Value.Salary > 4000));

            //Remove(), used to remove an item from the dictionary
            //dictionaryCusotmers.Remove(101);

            //Clear(), used to remove all the items of a dictionary
            //dictionaryCusotmers.Clear();

            //-------------------------------------------------------------------------------------------
            //Converting an array into a dictionary
            //Customer[] customers = new Customer[3];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;

            //Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            //foreach(KeyValuePair<int, Customer> kvp in dict)
            //{
            //    Console.WriteLine("Key = {0}", kvp.Key);
            //    Customer cust = kvp.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name,cust.Salary);
            //}

            //Converting a list into a dictionary
            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            foreach (KeyValuePair<int, Customer> kvp in dict)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }

        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
