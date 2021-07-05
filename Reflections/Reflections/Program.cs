using System;
using System.Reflection;

namespace Reflections
{
    class Program
    {
        static void Main()
        {
            //Customer C1 = new Customer();       //This is called Early Binding

            //Reflections are used in Late Binding(Where the class or the code in it is unknown at compile time)

            //Type T = Type.GetType("Reflections.Customer");  //Type class is present in System Namespace
            //Type T = typeof(Customer);      //Instead of Type.GetType() static method, we can also use typeof()
            //We can also use GetType on instance of a class
            Customer C1 = new Customer();
            Type T = C1.GetType();
            Console.WriteLine("Name = {0}; Namespace = {1}; FullName = {2}", T.Name, T.Namespace, T.FullName);

            Console.WriteLine("");

            Console.WriteLine("Properties in Customer Class");
            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + "\t" + property.Name);
            }

            Console.WriteLine("");

            Console.WriteLine("Methods in Customer Class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + "\t" + method.Name);
            }

            Console.WriteLine("");

            Console.WriteLine("Constructors in Customer Class");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}

