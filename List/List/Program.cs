using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main()
        {
            //List

            Customer customer1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "RetailCustomer"
            };
            Customer customer2 = new Customer
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };
            Customer customer3 = new Customer
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "RetailCustomer"
            };
            Customer customer4 = new Customer
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };
            Customer customer5 = new Customer
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            //Arrays don't grow in size automatically
            //Trying to initiate 3rd object in an array by declaring 2 objects yields IndexOutOfRange exception
            //Customer[] customers = new Customer[2];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;

            //Lists grow in size automatically
            //List<Customer> cust = new List<Customer>(2);    //you can initialize additional item in a list even after specifying a lesser item size
            //cust.Add(customer1);
            //cust.Add(customer2);
            //cust.Add(customer3);

            //Customer c = cust[0];     //List is index based and we can use the index number to retrieve the corresponding value
            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);

            //Iterating through List using for and foreach
            //foreach (Customer c in cust)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            //}

            //Its better to use foreach than using for loop to avoid any exceptions
            //for (int i = 0; i < cust.Count; i++)
            //{
            //    Customer c = cust[i];
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            //}

            //----------------------------------------------------------------------------------------------------------------------
            //Functions () in Lists

            //You can initialize a list with an object of its derived class
            //SavingsCustomer sc = new SavingsCustomer();
            //cust.Add(sc);

            //You can insert an object at any location in the list using its index and .Insert()
            //cust.Insert(0, customer3);

            //foreach (Customer c in cust)
            //{
            //    Console.WriteLine(c.ID);
            //}

            //You can find the index of a given object by using .IndexOf()
            //Console.WriteLine(cust.IndexOf(customer3));
            //Console.WriteLine(cust.IndexOf(customer3, 1));  //searching index of customer3 starting from index 1
            //Console.WriteLine(cust.IndexOf(customer3, 1, 3));   //searching 3 objects for index of customer3 starting from index 1 

            //Contains() checks if an object exists in the list or not. Returns bool
            //if (cust.Contains(customer3))
            //{
            //    Console.WriteLine("Customer3 object exists in the list");
            //}
            //else
            //{
            //    Console.WriteLine("Customer3 object does not exists in the list");
            //}

            //Exists() checks if an object exists in the list based on a condition. Returns bool
            //if (cust.Exists(cust => cust.Name.StartsWith("P")))
            //{
            //    Console.WriteLine("Customer with intial letter P exists");
            //}
            //else
            //{
            //    Console.WriteLine("Customer with intial letter P does not exist");
            //}

            //Find() searches and returns first matching object from the list
            //Customer c = cust.Find(cust => cust.Salary > 5000);
            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);

            //FindLast() searches and returns last matching object from the list
            //Customer c = cust.FindLast(cust => cust.Salary > 5000);
            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);

            //FindAll() searches and returns all matching objects from the list
            //List<Customer> customers = cust.FindAll(cust => cust.Salary > 5000);
            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            //}

            //FindIndex() finds first matching index of an object with specific condition
            //int index = cust.FindIndex(cust => cust.Salary > 5000);
            //int index = cust.FindIndex(2, cust => cust.Salary > 5000);  //You can also specify the start index
            //int index = cust.FindIndex(0, 3, cust => cust.Salary > 5000);   //You can specify start index and also the count
            //Console.WriteLine("Index = {0}", index);

            //FindLastIndex() finds last matching index of an object with specific condition
            //int index = cust.FindLastIndex(cust => cust.Salary > 5000);
            //Console.WriteLine("Index = {0}", index);

            //Conversion
            //Converting an array to a List
            //Customer[] customerArray = new Customer[3];
            //customerArray[0] = customer1;
            //customerArray[1] = customer2;
            //customerArray[2] = customer3;

            //List<Customer> listCustomers = customerArray.ToList();
            //foreach(Customer c in listCustomers)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            //}

            //Converting a list to an array
            //List<Customer> cust = new List<Customer>();    
            //cust.Add(customer1);
            //cust.Add(customer2);
            //cust.Add(customer3);

            //Customer[] customerArray = cust.ToArray();
            //foreach (Customer c in customerArray)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            //}

            //Converting a list to a Dictionary
            //List<Customer> cust = new List<Customer>();
            //cust.Add(customer1);
            //cust.Add(customer2);
            //cust.Add(customer3);

            //Dictionary<int, Customer> dictionary = cust.ToDictionary(x => x.ID);
            //foreach (KeyValuePair<int, Customer> kvp in dictionary)
            //{
            //    Console.WriteLine("Key = {0}",kvp.Key);
            //    Customer c = kvp.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            //}

            //------------------------------------------------------------------------------------------------------------
            //Ranges in Lists

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            //AddRange() appends one list to another
            //listCustomers.AddRange(listCorporateCustomers);

            //Check if the objects/items are appended to the list or not
            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            //}

            //GetRange() retrieves list of items from a list (start index, count)
            //listCustomers.AddRange(listCorporateCustomers);
            //List<Customer> customers = listCustomers.GetRange(3, 2);    //Gives details of all corporate customers
            //List<Customer> customers = listCustomers.GetRange(0, 3);    //Gives details of all retail customers

            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            //}

            //InsertRange() inserts another list at specified index (Target index, List to be added)
            //listCustomers.Insert(0, customer4);       //insert allows you to add only one item to the list
            //listCustomers.InsertRange(3, listCorporateCustomers);

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            //}

            //RemoveRange() removes objects from a list (Start index, count)
            //listCustomers.AddRange(listCorporateCustomers);
            //listCustomers.Remove(customer1);    //lets you remove one customer item
            //listCustomers.RemoveAt(4);  //lets you remove an item at a given index
            //listCustomers.RemoveAll(cust => cust.Salary > 5000);    //lets you remove all the items of a list with a condition
            //listCustomers.RemoveRange(3, 2);    //lets you remove specified items from a specified index

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            //}
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        //For understanding ranges
        public string Type { get; set; }
    }

    public class SavingsCustomer : Customer
    {

    }
}
