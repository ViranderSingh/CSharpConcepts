using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueCollection
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
                Name =  "Pam",
                Gender = "Female"
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name =  "John",
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

            //Enqueue() method is used to add items to a queue
            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            //Dequeue() method is used to remove and return an item from a queue
            //Customer c1 = queueCustomers.Dequeue();
            //Console.WriteLine("ID =  {0}, Name = {1}, Gender = {2}", c1.ID, c1.Name, c1.Gender);
            //Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);

            //Customer c2 = queueCustomers.Dequeue();
            //Console.WriteLine("ID =  {0}, Name = {1}, Gender = {2}", c2.ID, c2.Name, c2.Gender);
            //Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);

            //Customer c3 = queueCustomers.Dequeue();
            //Console.WriteLine("ID =  {0}, Name = {1}, Gender = {2}", c3.ID, c3.Name, c3.Gender);
            //Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);

            //Customer c4 = queueCustomers.Dequeue();
            //Console.WriteLine("ID =  {0}, Name = {1}, Gender = {2}", c4.ID, c4.Name, c4.Gender);
            //Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);

            //Customer c5 = queueCustomers.Dequeue();
            //Console.WriteLine("ID =  {0}, Name = {1}, Gender = {2}", c5.ID, c5.Name, c5.Gender);
            //Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);

            //foreach (Customer c in queueCustomers)
            //{
            //    Console.WriteLine("ID =  {0}, Name = {1}, Gender = {2}", c.ID, c.Name, c.Gender);
            //    Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);
            //}

            //Peek() method is used to return an item from a queue without removing it
            //Customer c1 = queueCustomers.Peek();
            //Console.WriteLine("ID =  {0}, Name = {1}, Gender = {2}", c1.ID, c1.Name, c1.Gender);
            //Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);

            if (queueCustomers.Contains(customer1))
            {
                Console.WriteLine("Customer1 exists");
            }
            else
            {
                Console.WriteLine("Customer1 does not exist");
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
