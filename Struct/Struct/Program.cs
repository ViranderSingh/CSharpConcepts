using System;

public struct Customer
{
    //Private Fields
    private int _id;
    private string _name;

    //Public Properties
    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }

    //Constructor
    public Customer (int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    //Print Method
    public void print()
    {
        Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
    }
}

namespace Struct
{
    class Program
    {
        static void Main()
        {
            Customer C1 = new Customer(101, "Virander Singh");  //Here we initialize values using Constructor
            C1.print();


            //C1.Id = 101;
            //C1.Name = "Virander Singh";

            //Console.WriteLine("Id = {0}", C1.Id);
            //Console.WriteLine("Name = {0}", C1.Name);

            Customer C2 = new Customer();   //Automatic parameterless constructor is created
            C2.Id = 102;                    //We use Properties to assign the values to the encapsulated fields
            C2.Name = "Jasbir Singh";
            C2.print();

            Customer C3 = new Customer      //You can make use of Object Initializer Syntax to intialze the private fields
            {
                Id = 103,
                Name = "Gulbir Singh"
            };
            C3.print();
        }
    }
}
